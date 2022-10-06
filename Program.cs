/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */



Console.WriteLine("Введите первое число: ");
string numberOne=Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string numberTwo=Console.ReadLine();

int numOne = int.Parse(numberOne);
int numTwo = int.Parse(numberTwo);

if (numOne > numTwo)
{
    Console.WriteLine($"Число {numOne} большее, а число {numTwo} меньшее");
} 

if (numOne < numTwo)
{
    Console.WriteLine($"Число {numOne} меньшее, а число {numTwo} большее");
}
    
else
{
    Console.WriteLine($"Числа равны");
}