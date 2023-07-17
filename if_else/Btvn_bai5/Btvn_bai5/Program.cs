Console.WriteLine("Nhap so nguyen la: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0 && num % 3 == 0)
{
    Console.WriteLine("So nguyen num chia het cho 2 va 3");
}
else
{
    Console.WriteLine("So nguyen num khong chua het cho 2 va 3");
}