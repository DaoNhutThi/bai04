Console.WriteLine("Nhap so nguyen a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap so nguyen b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap so nguyen c:");
int c = int.Parse(Console.ReadLine());

if ((a > b && a > c) || (a > b && a < c))
{
    Console.WriteLine("A is Largest!");
}
else if ((b > a && b > c) || (b > a && b < c))
{
    Console.WriteLine("B is Largers!");
}
else
{
    Console.WriteLine("C is Largest!");
}