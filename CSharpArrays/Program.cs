//array is a reference type so every action in this method will affect original array

//1 1 - Dimensional Array
void PopulateArray(int[] numbers)
{
    Random r = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = r.Next(1, 101);
        Console.WriteLine($"The {i + 1}. element is {numbers[i]}");
    }
}
static void CalculateSum(int[] numbers)
{
    int sum = 0;
    foreach (int i in numbers)
    {
        sum += i;
    }
    Console.WriteLine($"The sum of all the elements is {sum}");
}

Console.WriteLine("Enter an array capacity: ");
int capacity = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[capacity];
PopulateArray(numbers);
Console.WriteLine();
CalculateSum(numbers);
Console.ReadKey();


//2. Parameter Arrays
//static void TestMethod(params int[] numbers)
//{
//    //method body    
//}

//TestMethod(1, 2, 3);

//static void PrintMin(params int[] numbers)
//{
//    var min = numbers[0];
//    for (var i = 1; i < numbers.Length; i++)
//    {
//        if (min > numbers[i])
//        {
//            min = numbers[i];
//        }
//    }
//    Console.WriteLine(min);
//}

//PrintMin(49, 58, 12, 98, 47, 13);
//Console.ReadKey();

//3 Multi - Dimensional Array
//int[,] numbersMultiDim = new int[3, 2] { { 1, 5 }, { 3, 8 }, { 6, 1 } };
//int number = numbersMultiDim[2, 1]; // value 1    => third row on index 2 and second column on index 1

//for (int i = 0; i < numbersMultiDim.GetLength(0); i++)
//{
//    for (int j = 0; j < numbersMultiDim.GetLength(1); j++)
//    {
//        Console.WriteLine(numbersMultiDim[i, j]);
//    }
//}