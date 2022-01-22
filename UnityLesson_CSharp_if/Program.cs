using System;

namespace UnityLesson_CSharp_if
{
    internal class Program
    {
        static bool condition1=false;
        static bool condition2 =true;
        static bool condition3;


                
       

        static void Main(string[] args)
        {
                       

            if (condition1)
            { 
                Console.WriteLine("조건 1이 참이다.\n");
                //조건1이 참이면 실행 할 내용
            }

            else if (condition2)
            {
                Console.WriteLine("조건 2가 참이다.\n");
                //조건 1이 거짓이고, 조건2가 참 일 때 실행할 내용
            }

            else if (condition3)
            {
                Console.WriteLine("조건 3이 참이다.\n");
                //조건 1, 2 모두 거짓이고, 조건3이 참일 때 실행할 내용
            }

            else
            {
                Console.WriteLine("모든 조건이 거짓이다.\n");
                //else 위의 모든 조건이 거짓일 때 실행할 내용
            }
              
        
        
        
        }
    }
}
