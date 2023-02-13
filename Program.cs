
// // // string str = "abcdefg";
// // // Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
// // // Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

// // // int length = str.Length;
// // // Console.WriteLine("3) The length of '{0}' is {1}", str, length);


// //  Console.Write("Введите количество строк, которые хотите ввести: ");
// //             int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
// //             string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
// //             for (int i = 0; i < n; i++)
// //             {
// //                 Console.Write("Введите строку №{0}:\r\n    ", i + 1);
// //                 strs[i] = Console.ReadLine(); //Заполняем его
// //             }
// //             Console.WriteLine("Вы ввели следующие строки:");
// //             for (int i = 0; i < n; i++)
// //             {
// //                 Console.WriteLine($"В строке {strs[i]} , {strs[i].Length} элементов");
// //             }


// // Console.WriteLine(string.Join(", ", array));
// Console.WriteLine("Введите какой использовать вариант");

// int number = new Random().Next(100,1000);
// Console.WriteLine(" Ваше случайное число : " +number);

// int Var = Convert.ToInt32(Console.ReadLine());
// int num2 =0;
// switch (Var)
// {
//     case 1:

//         int num23=number%100;
//         num2=num23/10;
//         Console.WriteLine("Второе число : "+num2);
//         break;

//     case 2:

//         int num12=number/10;
//         num2=num12%10;
//         Console.WriteLine("Второе число : "+num2);
//         break;

Console.WriteLine("Ввести массив - 1 , использовать шаблон -2");
int Var = Convert.ToInt32(Console.ReadLine());
int count = 0;

int SizeArray(string array[])
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

void FillNewArray(int count, string array[])
{
    int temp = 0;
    string[] newArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[temp] = array[i];
            temp++;
        }
    }
}


switch (Var)
{
    case 1:
        Console.Write("Введите количество строк, которые хотите ввести: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] strs = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите строку {i + 1} :  ");
            strs[i] = Console.ReadLine();
        }
        Console.WriteLine("Ваш массив : " + string.Join(" | ", strs));
        SizeArray(strs);
        FillNewArray(count, strs);
        Console.WriteLine("Ваш массив : " + string.Join("/", newArray));


        break;

    case 2:
        string[] strs2 = new string[] { "Hello ", ", ", "World ", "!!!", " My ", "name ", "is ", "Mark ", ":)" };
        Console.WriteLine("Ваш массив : " + string.Join("/", strs2));
        SizeArray(strs2);
        FillNewArray(count, strs2);
        Console.WriteLine("Ваш массив : " + string.Join("/", newArray));
        break;
}