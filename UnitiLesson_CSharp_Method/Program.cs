using System;

namespace UnitiLesson_CSharp_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();           //함수 호출
            PrintHelloWorld();           // 인자 x, 반환 x
            PrintHelloWorld();
            PrintSomething("아무노래나 일단 틀어");    // 인자o. 반환  x
                                              //  함수 호출에서 소괄호 안 내용은 매개변수(parameter)
            bool tmoIsFinished = false;
            PrintSomethingAndReturnFinished("아무거나 먹고싶다.");
            tmoIsFinished = PrintSomethingAndReturnFinished("아무거나 먹고싶다.");
            Console.WriteLine(tmoIsFinished);

            int a = 0;
            add(3, 99);
            a = add;
            Console.WriteLine("%d", a);

        }
        
        




        static void PrintHelloWorld()         // 함수를 정의한 것      // 함수 정의에서 소괄호 안의 내용은 인자(Argument)
        {
            Console.WriteLine("배고파\n"); 
        }

        static void PrintSomething(string something)    
        {
            Console.WriteLine(something); 
        }
        
        //인자 o 반환 o
        static bool PrintSomethingAndReturnFinished(string something)
        {   
            bool isFinished = false;               // 변수가 함수 안에서 정의 되었다면 "지역함수"라고 한다.     (이 변수는 함수 안에서만 연산을 위해 사용)
            Console.WriteLine(something);
            isFinished = true;
            return isFinished;
        }

        

        static int add(int a, int b)
        {
            return a + b;   
        }




    }

    //함수의 형태
    
    /*               반환형 함수이름(인자자료형 인자이름)
                    {
                      함수 연산 내용
   
                     return 반환할 내용
                     


}*/
}