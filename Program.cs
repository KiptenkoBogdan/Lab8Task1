using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Task1
{
    class Program
    {
        static void MethodAct(int[,] arr, Action<int> act)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    act(arr[i,j]);
        }
        static void MethodFunc(int[,] arr, Func<int, int> act)
        {
            for(int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    arr[i,j] = act(arr[i, j]);
        }
        static void Show(int num)
        {
            Console.WriteLine("Num = " + num);
        }
        static void ShowPositive(int num)
        {
            if (num >= 0)
                Console.WriteLine("Positive num = " + num);
        }
        static int Mult3(int num)
        {
            if (num >= 0)
                num *= 3;
            return num;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] array = new int[3, 3];
            Action<int> action;
            Func<int, int> func;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rnd.Next(-20, 20);
                }
            }

            action = Show;
            MethodAct(array, action);

            action = ShowPositive;
            MethodAct(array, action);

            func = Mult3;
            MethodFunc(array, func);

            action = Show;
            MethodAct(array, action);

            Console.ReadKey();
        }
    }
}
