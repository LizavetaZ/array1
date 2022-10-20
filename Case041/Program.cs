Console.WriteLine("Введите элементы массива через запятую");
int[] Numbers = ArrayFromString(Console.ReadLine());
int count = InputCount(Numbers, 0);
Console.WriteLine("Количество элементов больше 0 - " + count);


int[] ArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int InputCount(int[] array, int countDigit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countDigit = countDigit + 1;
        }
    }
    return countDigit;
}

