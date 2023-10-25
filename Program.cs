using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public struct Student
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Id는{Id}입니다.";
        }
    }
    internal class Program
    {
        unsafe static void Main(string[] args)
        {

            //Console.WriteLine("Hello world");
            //Console.WriteLine();

            // var youngsu= new Student();
            //    youngsu.Id = 100;

            ////Console.WriteLine(youngsu.ToString());
            //FunC(youngsu);
            //Console.WriteLine(youngsu);

            int a = 10, b = 20;
            int* ptrA;
            int* ptrB;
            ptrA = &a;
            ptrB = &b;
            //int tmp;

            //tmp = a;
            //a= b;
            //b= tmp;
            //Console.WriteLine(a + " " + b);
            
            //SwapByRef(ref a ,ref b);
            //Console.WriteLine(a + " " + b);
            *ptrA = 30;
            int tmp;

            Console.WriteLine(*ptrA);
            Console.WriteLine(*ptrB);
           
            
            //tmp = *ptrA;
            //*ptrA = *ptrB;
            //*ptrB = tmp;
            Console.WriteLine(" mmm");
            Console.WriteLine(*ptrA+","+a);
            Console.WriteLine(*ptrB+","+b);
            Console.WriteLine(new IntPtr(ptrA));
            Console.WriteLine(new IntPtr(ptrB));
            SwapByPtr(ptrA, ptrB);


            Console.WriteLine(a + " " + b);
        }

        static void FunC(Student student)
        {
            student.Id = 200;
            Console.WriteLine(student.ToString());
        }

         static void SwapByRef(ref int a,ref int b)
        {
            int tmp;

            tmp =  a;
            a = b;
            b = tmp;
        }
        unsafe static void SwapByPtr(int* a, int* b)
        {
            int tmp;

            tmp = *a;
            *a = *b;
            *b = tmp;
        }


    }
}
