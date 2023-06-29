/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество
чётных чисел в массиве.*/

//создаем первый метод для ввода данных 

Console.WriteLine("Программа покажет  массив заполненный случайными положительными трёхзначными числами ");
int userInput = UsInPt("Введите желаемый размер массива","Ошибка");
Console.WriteLine(userInput);

int[] random = randomFun(userInput, 100 , 999);
Console.WriteLine(String.Join(", ", random));

int[] schet = Schet(random , userInput);






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
    
    /*for(int i = 0 ; size > i ; i++)
    {
        schet += res[i] % 2 ;
    }
    return schet; */
}

int Schet(int res, int[] res)
{
for(int i = 0 ; size > i ; i++)
    {
        schet += res % 2 ;
    }
    return schet;
}