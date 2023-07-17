Console.WriteLine("Nhap diem so tu 0 den 100: ");
double scores = double.Parse(Console.ReadLine());

if (scores >= 0 && scores <= 100)
{
    switch (scores)
    {
        case double n when (n >= 90 && n <= 100):
            Console.WriteLine("Xuat sac!");
            break;
        case double n when (n >= 80 && n <= 89):
            Console.WriteLine("Gioi!");
            break;
        case double n when (n >= 70 && n <= 79):
            Console.WriteLine("Kha!");
            break;
        case double n when (n >= 60 && n <= 69):
            Console.WriteLine("Trung binh");
            break;
        case double n when (n >= 0 && n <= 59):
            Console.WriteLine("Yeu");
            break;
        default:
            Console.WriteLine("Diem khong hop le!");
            break;
    }
}