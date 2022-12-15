//Task 25
double vozvst(double num, int st)
{
    double rezult=0.0;
        for (int i=0; i<st; i++)
        {
           rezult=num*num;
        }

 return rezult;   
}
Console.WriteLine("Введите число, которое нужно ввести в степень: ");
double num=double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int st=int.Parse(Console.ReadLine());
Console.WriteLine($"{vozvst(num, st)}");

