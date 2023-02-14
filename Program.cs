
int SizeArray(string[] array, int count)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            count++;
        }
    }
    return count;
}

void FillNewArray(int count, string[] array)
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
    Console.WriteLine("Ваш новый массив : " + string.Join("/", newArray));
}

Console.WriteLine("Ввести массив - 1 , использовать шаблон -2");
int Var = Convert.ToInt32(Console.ReadLine());
int count = 0;


switch (Var)
{
    case 1:
        Console.Write("Введите количество строк, которые хотите ввести: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] strs = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите строку {i + 1} :  ");
            strs[i] = Convert.ToString(Console.ReadLine());
        }
        Console.WriteLine("Ваш массив : " + string.Join(" | ", strs));
        int newSize=SizeArray(strs,count);
        FillNewArray(newSize, strs);
        break;

    case 2:
        string[] strs2 = new string[] { "Hello ", ", ", "World ", "!!!", " My", " name ", "is ", "Mark ", ":)" };
        Console.WriteLine("Ваш массив : " + string.Join("/", strs2));
        int newSize2=SizeArray(strs2,count);
        FillNewArray(newSize2, strs2);
        break;
}