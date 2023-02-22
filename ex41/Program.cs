void Main()
{
    Console.Write("M = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    int sum = 0;
    for(int i = 0; i < n; i++)
    {
        Console.Write($"A[{i + 1}] = ");
        a[i] = Convert.ToInt32(Console.ReadLine());
        if(a[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine(sum);

}
Main();