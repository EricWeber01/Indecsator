//В С # индексация начинается с нуля, но в 
//некоторых языках программирования это не так. Например, в Turbo 
//Pascal индексация массиве начинается с 1. Напишите класс
//RangeOfArray, который позволяет работать с массивом такого типа, 
//в котором индексный диапазон устанавливается пользователем. 
//Например, в диапазоне от 6 до 10, или от –9 до 15.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indecsator
{
    class RangeOfArray
    {
        private int[] temp = new int[10] { 1, 3, 5, 7, 10, 12, 7, 8, 9, 15 };
        public int Length
        {
            get 
            { 
                return temp.Length; 
            }
        }
        public int this[int index]
        {
            get
            {
                return temp[index];
            }
            set
            {
                temp[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray tempArr = new RangeOfArray();
            tempArr[3] = 8;
            tempArr[5] = 11;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Element #{0} = {1}", i, tempArr[i]);
            }
        }
    }
}
