Console.WriteLine("Nhap so nguyen a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap so nguyen b: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("a Greater than b");
}
else if (a < b)
{
    Console.WriteLine("a Less than b");
}
else
{
    Console.WriteLine("a Equal b");
}
