using static System.Console;

WriteLine("Введите размер массива ");
int len = int.Parse(ReadLine()!);

string[] arr = GetArray(len);
PrintArray(arr);
WriteLine();
string[] newArray = ChoiceArray(arr);
PrintArray(newArray);


string[] GetArray(int size)
{

    string[] resultArray = new string[size];
    WriteLine ("Введите элементы массива" );

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = ReadLine()!;
    }

    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
}

string[] ChoiceArray(string[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3)
        {
            count++;
        }

    }


    string[] resultArray = new string[array.Length - count];

    
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                resultArray[j] = array[i];
                j++;
            }
        }
    

    return resultArray; 

}
