Console.WriteLine("Nhap so tu 1 den 5");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Xin chao!");
        break;
    case 2:
        Console.WriteLine("Chao buoi sang!");
        break;
    case 3:
        Console.WriteLine("Chao buoi trua!");
        break;
    case 4:
        Console.WriteLine("Chao buoi toi!");
        break;
    default:
        Console.WriteLine("Invalid :) ");
        break;
}