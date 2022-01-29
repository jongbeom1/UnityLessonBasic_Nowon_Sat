using System;

namespace UnityLesson_CSharp_ClassIncludingVariableFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  
        }
        class Person
        {   //맴버 변수
            int age;
            float height;
            bool isResting;
            char genderChar;
            string name;

            void SayAllInfo()
            {
                SayAge();
                SayHeigh();
                SayGengerChar();    
                SayisResting();
                SayName();      
            }
            //맴버 함수
            void SayAge()
            {
                Console.WriteLine(age);
            }
                void SayHeigh()
            {
                Console.WriteLine(height);
            }
            void SayisResting()
            {
                Console.WriteLine(isResting);
            }
            void SayGengerChar()
            { 
                Console.WriteLine(genderChar); 
            }
            void SayName()
            { 
                Console.WriteLine(name);            
            }   
        }
    }
}


/* class정의 형태
 class 클래스이름
 {
  멤버 변수 : class의 특성(키,몸무게,...)
  멤버 함수 : class의 기능(jump,attck...)
 }
 *





/*Camel case
1. 단어가 바뀔 때 첫 문자는 대문자
2. 변수 이름은 소문자로 시작한다.
3. class,method,namespace등은 대문자로 시작한다.

그 외 코드작성 시 유의사항
1. 줄임말은 되도록 사용하지 않는다.
2. 이름을 보았을 때 어떤 기능이나 목적인지 알 수 있도록 선정한다.
3. 애매하거나 복잡한 내용이 있다면 주석을 달아준다.
4. 띄워쓰기를 꼭 해야하는 경우 under bar(_)를 사용한다.
*/