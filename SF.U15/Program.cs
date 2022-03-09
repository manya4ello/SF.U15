// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = { 1, 2, 3, 4, 5, 107};
    
Console.WriteLine(Average(nums));

static double Average(int[] numbers)
{
     return (double) numbers.Average(x => x);

}