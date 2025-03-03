// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the first modification");

int a = 8;
int b = 10;
Console.WriteLine("This is the second modification: " + a + b);

Console.WriteLine("This is the second modification.");

int[] arr = [3,5,2,1];
Console.WriteLine("Array length: " + arr.Length + ", array sum: " + arr.Sum());

static float feature(int[] arr)
{
    int sum = 0;
        
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return arr.Sum() / arr.Length;
}

