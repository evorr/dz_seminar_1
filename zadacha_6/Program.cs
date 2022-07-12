// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rem = num%2;
if(rem == 0)
{
    Console.WriteLine($"Число {num} является чётным.");
}
else
{
    Console.WriteLine($"Число {num} не является чётным.");
}
