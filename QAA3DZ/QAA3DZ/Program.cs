using QAA3DZ;
#region Циклы_1
/*Пользователь вводит 2 числа (A и B). Возвести число A в степень B.*/

/*Console.WriteLine("введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int temp = num1;
if (num2==0)
{
    Console.WriteLine(1);
}
else if(num2<0)
{
    while ((num2 + 1) != 0)
    {
        num1 *= temp;
        num2++;
    }
    
    Console.WriteLine($"1/{num1}");
}
else
{
    while ((num2 - 1) != 0)
        {
            num1 *= temp;
            num2--;
        }
        Console.WriteLine(num1);
}*/

// с помощью методов

/*Console.WriteLine("введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double result = CiklMetodi.VozvestStepen(num1, num2);
Console.WriteLine(result);
*/
#endregion

#region Циклы_2
/*Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые
делятся на A.*/

/*int numb = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < 1000; i++)
{
    if (i % numb == 0)
        Console.WriteLine(i);
}
Console.WriteLine("konec programmi");*/

// с помощью методов

/*int numb = Convert.ToInt32(Console.ReadLine());
CiklMetodi.DiviadedIntoA(numb);*/

#endregion

#region Циклы_3
/*Пользователь вводит 1 число (A). Найдите количество положительных целых
чисел, квадрат которых меньше A.*/

/*int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 1;
while (i * i < n)
{
    count++;
    i++;
}
Console.WriteLine(count);*/

//с помощью методов

/*int n = Convert.ToInt32(Console.ReadLine());
int result = CiklMetodi.CountPolojCisel(n);*/

#endregion

#region Цмклы_4
/*Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме
самого A) числа A.*/

/*int num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine(num / i);
        break;
    }
}*/

//с помощью методов

/*int num = Convert.ToInt32(Console.ReadLine());
int result = CiklMetodi.NOD(num);
Console.WriteLine(result);*/
#endregion

#region Цикл_5
/*Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона
от A до B, которые делятся без остатка на 7 (Учтите, что при вводе B может
оказаться меньше A).*/

/*int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    for (int i = num2; i < num1; i++)
    {
        if (i % 7 == 0)
            Console.WriteLine(i);
    }
}
else if(num1 < num2)
{
    for (int i = num1; i < num2; i++)
    {
        if (i % 7 == 0)
            Console.WriteLine(i);
    }
}
else
{

    if(num1%7==0)
        Console.WriteLine(num1);
    else
        Console.WriteLine("nullable");

}
*/

//с помощью методов

/*int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int result = CiklMetodi.SUMotAdoB(num1, num2);
Console.WriteLine(result);*/
#endregion

#region Цикл_6
/*Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда
фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух
предыдущих. Первое и второе считаются равными 1*/

/*int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(1);
Console.WriteLine(1);
int i1 = 1;
int i2 = 2;
for (int i = 2; i < num;)
{
    i = i1 + i2;
    i1 = i2;
    i2 = i;
    Console.WriteLine(i);
}
*/

//с  помощью  методов

/*int num = Convert.ToInt32(Console.ReadLine());
CiklMetodi.Fibonacci(num);*/
#endregion


#region Циклы_7
/*Пользователь вводит 2 числа. Найти их наибольший общий делитель
используя алгоритм Евклида.*/

/*int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{ 
    while (num1 % num2 != 0)
    {
        int temp = num2;
        num2 = num1 % num2;
        num1 = temp;

    }
    Console.WriteLine(num2);
}
else if (num1 < num2)
{
    while (num2 % num1 != 0)
    {
        int temp = num1;
        num1 = num2 % num1;
        num2 = temp;

    }
    Console.WriteLine(num1);

}
else
    Console.WriteLine(num1);
*/

//с помощью методов

/*int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int result = CiklMetodi.EvklidNOD(num1, num2);*/
#endregion

#region Циклы_8
/**Пользователь вводит целое положительное число, которое является кубом
целого числа N. Найдите число N методом половинного деления.*/

/*int kubNumb = Convert.ToInt32(Console.ReadLine());

int numb;   
for (int i = 1; i < kubNumb; i++)
{
    int seredina = (i + kubNumb) / 2;
    if (Math.Pow(1/3,kubNumb) < seredina)
    {
        kubNumb = seredina;
    }
}*/

#endregion

#region Циклы_9
/*Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.*/

/*int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number > 0)
{
    if((number%10)%2 == 1)
    {
        count++;
    }
    number /= 10;
}
Console.WriteLine(count);*/

//с помощью циклов

/*int number = Convert.ToInt32(Console.ReadLine());
int result = CiklMetodi.CounOddDigit(number);
Console.WriteLine(result);*/


#endregion

#region Циклы_10
/*10 Пользователь вводит 1 число. Найти число, которое является зеркальным
отображением последовательности цифр заданного числа, например, задано
число 123, вывести 321*/

/*int number = Convert.ToInt32(Console.ReadLine());
int numberTwo = 0; ;
while(number > 0)
{
    numberTwo = numberTwo * 10 + number % 10;
    number/=10;
}
Console.WriteLine(numberTwo);*/

//с помощью методов

/*int number = Convert.ToInt32(Console.ReadLine());
int result = CiklMetodi.MirroringNumber(number);
Console.WriteLine(result);
*/
#endregion

#region Циклы_11
/**Пользователь вводит целые положительные числа (A,B). Выведите числа в
диапазоне от A до B, сумма четных цифр которых больше суммы нечетных.*/

/*int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if(A > B)
{
    for (int i = B; i < A; i++)
    {
        int sumCet = 0;
        int sumNecet = 0;
        int j = i;
        while (j > 0)
        {
            int ost = j % 10;
            if (ost % 2 == 0)
            {
                sumCet = sumCet + ost;
            }
            else
            {
                sumNecet = sumNecet + ost;
            }
            j /= 10;
        }
        if (sumCet > sumNecet)
        {
            Console.WriteLine(i);
        }
    }

}
else if (A == B)
{
    for (int i = B; ;)
    {
        int sumCet = 0;
        int sumNecet = 0;
        int j = i;
        while (j > 0)
        {
            int ost = j % 10;
            if (ost % 2 == 0)
            {
                sumCet = sumCet + ost;
            }
            else
            {
                sumNecet = sumNecet + ost;
            }
            j /= 10;
        }
        if (sumCet > sumNecet)
        {
            Console.WriteLine(i);
        }
    }

}


else
{
    for (int i = A; i < B; i++)
    {
        int sumCet = 0;
        int sumNecet = 0;
        int j = i;
        while (j > 0)
        {
            int ost = j % 10;
            if (ost % 2 == 0)
            {
                sumCet = sumCet + ost;
            }
            else
            {
                sumNecet = sumNecet + ost;
            }
            j /= 10;
        }
        if (sumCet > sumNecet)
        {
            Console.WriteLine(i);
        }
    }

}
*/

//с помощью методов

/*int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
CiklMetodi.SumEvenOdd(A, B);*/

#endregion

#region Циклы_12
/*12 * Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел
одинаковые цифры. Например, для пары 123 и 3456789, ответом будет
являться “ДА”, а, для пары 500 и 99 - “НЕТ”.*/

/*int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool stop = false;

while (num1!=0)
{
    int x = num1 % 10;
    int temp = num2;
    while(temp!=0)
    {
        int y = temp % 10;
        if(x == y)
        {
            Console.WriteLine("da");
            stop = true;
            break;
        }
        temp /= 10;
    }
    if(stop==true)
    {
        break;
    }
    num1 /= 10;
}
if(stop==false)
{
    Console.WriteLine("net");
}
*/
#endregion

