// string path = "C:/Users/user/Desktop/обучение новое/C#/lesson1_HelloUser";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = "C:/Users/user/Desktop/обучение новое/C#/lesson1_HelloUser";
// CatalogInfo(path);

// void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// // 0    1    2    3     4    5    6    7    8    9    10  11
// // void InOrderTraversal(int pos = 1)
// // {
// //     if (pos < tree.Length)
// //     {
// //         int left = 2 * pos;
// //         int right = 2 * pos + 1;
// //         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
// //         Console.WriteLine(tree[pos]);
// //         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
// //     }
// // }
// // InOrderTraversal();


// decimal fRec = 0;
// decimal fIte = 0;

// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }

// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result = f0 + f1;

//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }

// // # 1 2 3 4 5 6 
// //V 1 1 2 3 5 8

// Console.ReadLine();

// DateTime dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciIteration{n} = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
//     fIte = 0;
// }
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// Console.WriteLine();
// Console.ReadLine();

// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion{n} = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
//     fRec = 0;
// }
// Console.ReadLine();


// int i = 0;
// void Rec()
// {
//     Console.WriteLine(i++);
//     Rec();
// }
// Rec();


int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}

PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}