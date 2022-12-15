// //Task 25
// double vozvst(double num, int st)
// {
//     double rezult=num;
//         for (int i=1; i<st; i++)
//         {
//            rezult=rezult*num;
//         }
//     return rezult;   
// }
// Console.WriteLine("Введите число, которое нужно ввести в степень: ");
// double num=double.Parse(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int st=int.Parse(Console.ReadLine());
// Console.WriteLine($"{vozvst(num, st)}");

// // Task 27
// int sumNum(int a)
// {
//     string local=a.ToString();
//     int sum=0;
//     for (int i=0; i<local.Length; i++)
//         {
//             sum=sum+int.Parse($"{local[i]}");
//         }
//     return sum;
// }
// Console.WriteLine("Введите число: ");
// Console.WriteLine(sumNum(int.Parse(Console.ReadLine())));

//Task 29
void mas ()
{
    int [] massiv=new int [8];
    Random rnd=new Random();
    for (int i=0; i<8; i++)
    {

        massiv[i]=rnd.Next(1, 100);

        Console.WriteLine( massiv[i]);
    }
}

