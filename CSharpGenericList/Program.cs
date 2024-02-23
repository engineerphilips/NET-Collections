// See https://aka.ms/new-console-template for more information

/*
 The code below instantiate a List<T> we need to provide a type between the angle brackets:
 */
List<int> numberList = new List<int>();
List<Student> students = new List<Student>();

/*
 The below code has two more constructors that can be used to initialize a List object. With the first one, we can set initial capacity:
 */
List<int> numbers = new List<int>(2);

/*
 In the code below, we can populate our list with the IEnumerable collection:
 */
int[] nums = new int[5] { 1, 2, 3, 4, 5 };
List<int> numbers = new List<int>(nums);

/*
 To access any element we can specify its index position
 */
int number = numbers[1];

//Methods and Properties
/*
 The Add method adds the element inside a list:
 */

List<int> numbers = new List<int>();
numbers.Add(34);
numbers.Add(58);
numbers.Add(69);
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

/*
 AddRange adds the elements of the specified collection to the end of a list
 */

List<int> numbers = new List<int>();
numbers.Add(34);
numbers.Add(58);
numbers.Add(69);
int[] nums = new int[] { 1, 22, 44 };
numbers.AddRange(nums);
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

/*
 Contains determines whether an element exists in the list
 */
if (numbers.Contains(34))
{
    Console.WriteLine("The number 34 exists in a list");
}

//Console.WriteLine("Hello, World!");