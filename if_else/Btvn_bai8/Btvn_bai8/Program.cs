Console.WriteLine("Nhap a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap c: ");
int c = int.Parse(Console.ReadLine());

int sumOfSquare = a * a + b * b;
int squareOfC = c * c;
if (sumOfSquare == squareOfC)
{
    Console.WriteLine("Day la tam giac vuong!");
}
else
{
    Console.WriteLine("Day khong phai la tam giac vuong");
}