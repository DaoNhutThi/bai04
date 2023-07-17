Console.WriteLine("Nhap so canh: ");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 3:
        Console.WriteLine("Hinh tam giac");
        break;
    case 4:
        Console.WriteLine("Hinh tu giac");
        break;
    case 5:
        Console.WriteLine("Hinh ngu giac");
        break;
    case 6:
        Console.WriteLine("Hinh luc giac");
        break;
    default:
        Console.WriteLine("Hinh that giac");
        break;
}