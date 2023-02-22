void interdection (double b1, double b2, double k1, double k2)
{
   
    double x = (b2 - b1)/(k1-k2);
    double y = (k1 * (b2 - b1)) / (k1-k2) + b1;
    Console.Write("{0,6:F2}", x);
    Console.Write("{0,6:F2}", y);
}
Console.WriteLine("input first point b1: ");
int UserB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second point b2: ");
int UserB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input first point k1: ");
int UserK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second point k2: ");
int UserK2 = Convert.ToInt32(Console.ReadLine());

interdection(UserB1, UserB2, UserK1, UserK2);
