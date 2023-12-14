int [] array = CreateArray(10,10,0);
System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");
static int [] CreateArray (int size, int max, int min){
    int [] array  = new int[size];
    Random rand = new();
        for (int i = 0; i < size; i++)
        {
            array [i] = rand.Next(min,max+1);
        }
        return array;
    }
    static string PrintArray(int [] array)
    {
        return string.Join(", ",array);
    }
    static int [] ArraySwap(int [] array,int index)
    {

        if (index <= 0)
        {
            return array;
        }
        int temp = array[index];
        array[index] = array[array.Length - index-1];
        array[array.Length - index-1] = temp;
        return ArraySwap(array,index -= 2);
    }