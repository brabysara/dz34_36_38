/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество
чётных чисел в массиве.*/

//создаем первый метод для ввода данных 

Console.WriteLine("Программа покажет  массив заполненный случайными положительными трёхзначными числами. которая покажет количествочётных чисел в массиве");
int userInput = UsInPt("Введите желаемый размер массива","Ошибка");
Console.WriteLine(userInput);

int schet = 0;

int[] random = randomFun(userInput, 100 , 999);

Console.Write("[");
Console.Write(String.Join(", ", random ));

// подсчет 
for(int i = 0; userInput > i ; i++)
{
    if(random[i] % 2 == 0)
    {   
        schet++;
    }
}
Console.Write($"] ->  {schet}");

//функциии 
int UsInPt(string infForUser , string error )
{
    while(true)
    {
        Console.WriteLine(infForUser);
        if(int.TryParse(Console.ReadLine(), out int userInPt))
        {
            return userInPt;
        }
        else
        {
            Console.WriteLine(error);
        }
    }
}

int[] randomFun(int size, int minValue, int maxValue )
{
    int schet = 0 ;
    int[] res = new int [size];
    for(int i = 0; size > i ; i++)
    {
        res[i] = new Random().Next (minValue, maxValue + 1) ;
    }
    return res;

}


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine(" ");
Console.WriteLine(" Программа заполняется случайными числами и Находит сумму элементов, стоящих на нечётных позициях.");

int sizeUser = UsInPut("Введите желаемый размер массива ","Ошибка");
int minValue = UsInPut("Введите желаемое минимальное значение ","Ошибка");
int manValue = UsInPut("Введите желаемый максимальное значение ","Ошибка");

int[] randome = randomF(sizeUser, minValue  , manValue);
Console.Write("[ ");
Console.Write(String.Join(", ", randome ));

int addition = Addit(randome, sizeUser);

Console.Write(" ] -> "+addition);

//функции

int UsInPut(string infForUser, string error )
{
    while(true)
    {
        Console.WriteLine(infForUser);
      
        if((int.TryParse(Console.ReadLine(), out int userInPt)))
        {
            return userInPt;
            
        }
        else
        {
            Console.WriteLine(error);
        }
    }
}

int[] randomF(int size, int minValue, int maxValue )
{
    int schet = 0 ;
    int[] res = new int [size];
    for(int i = 0; size > i ; i++)
    {
        res[i] = new Random().Next (minValue, maxValue ) ;
    }
    return res;

}

int Addit(int[] random, int size)
{   
    int z = 0 ;
    for(int i = 0; size>i;i++ )
    {
         if(i%2 ==0)
        {
            i++ ;
            
        }
         if(i==size)
        {
            return z;
        }
        z += random[i] ;
       
       
        
    }
    return z;
}


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine(" ");
Console.WriteLine(" Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
///функции
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}