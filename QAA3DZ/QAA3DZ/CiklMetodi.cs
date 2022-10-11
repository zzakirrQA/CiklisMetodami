using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA3DZ
{
    internal class CiklMetodi
    {
        public static double VozvestStepen(int num1,int num2)
        {
            int temp = num1;
            if (num2 == 0)
            {
                return 1;
            }
            else if (num2 < 0)
            {
                while ((num2 + 1) != 0)
                {
                    num1 *= temp;
                    num2++;
                }

                return 1/num1;
            }
            else
            {
                while ((num2 - 1) != 0)
                {
                    num1 *= temp;
                    num2--;
                }
                return num1;
            }
        }

        public static void DiviadedIntoA(int numb)
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % numb == 0)
                Console.WriteLine(i);
            }
        }

        public static int CountPolojCisel(int n)
        {
            int count = 0;
            int i = 1;
            while (i * i < n)
            {
                count++;
                i++;
            }
            return count;
        }

        public static int NOD(int num)
        {
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return num / i; 
                }
                
            }
            return 0;
        }

        public static int SUMotAdoB(int num1,int num2)
        {
            if (num1 > num2)
            {
                for (int i = num2; i < num1; i++)
                {
                    if (i % 7 == 0)
                       return i;
                }
            }
            else if (num1 < num2)
            {
                for (int i = num1; i < num2; i++)
                {
                    if (i % 7 == 0)
                        return i;

                }
            }
            else
            {

                if (num1 % 7 == 0)
                    return num1;
            }
            return 0;
        }

        public static void Fibonacci(int num)
        {
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
        }

        public static int EvklidNOD(int num1,int num2)
        {
            if (num1 > num2)
            {
                while (num1 % num2 != 0)
                {
                    int temp = num2;
                    num2 = num1 % num2;
                    num1 = temp;

                }
                return num2;
            }
            else if (num1 < num2)
            {
                while (num2 % num1 != 0)
                {
                    int temp = num1;
                    num1 = num2 % num1;
                    num2 = temp;

                }
                return num1;

            }
            else
                return num1;
        }

        public static int CounOddDigit(int number)
        {
            int count = 0;

            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }

        public static int MirroringNumber(int number)
        {
            int numberTwo = 0; ;
            while (number > 0)
            {
                numberTwo = numberTwo * 10 + number % 10;
                number /= 10;
            }
            return numberTwo;
        }

        public static void SumEvenOdd(int A,int B)
        {
            if (A > B)
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
        }
    }
}

