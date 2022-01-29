using System;

namespace UnityLesson_CSharp_InstantiatinoOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Person();
            Person person1 = new Person();
            // 점(.)연산자 - 클래스 멤버에 접근하는 연산자
            person1.age = 28;
            person1.height = 176.6f;      // 실수형을 초기화 할 때에는 f를 뒤에다 붙여주어야 한다.
            person1.isResting = true;
            person1.genderChar = '남';
            person1.name = "박종범";
            // 객체의 멤버함수 호출
            person1.SayAllInfo();

            Console.WriteLine("\n\n");
            
            Person person2 = new Person();
            person2.age = 25;
            person2.height = 166.4f;
            person2.isResting = false;
            person2.genderChar = '여';
            person2.name = "박고은";
            person2.SayAllInfo();

        }
     public class Person
        {   //맴버 변수
           public int age;
            public float height;
            public bool isResting;
            public char genderChar;
            public string name;

            public void SayAllInfo()
            {
                SayName();
                SayAge();
                SayHeigh();
                SayGengerChar();
                SayisResting();            
            }
            //맴버 함수
            public void SayAge()
            {
                Console.WriteLine($"{name}의 나이 : {age}");
            }
            public void SayHeigh()
            {
                Console.WriteLine($"{name}의 키 : {height}cm");
            }
            public void SayisResting()
            {
                Console.WriteLine($"{name}는 쉬고있나요? : {isResting}");
            }
            public void SayGengerChar()
            {
                Console.WriteLine($"{name}의 성별 : {genderChar}");
            }
            public void SayName()
            {
                Console.WriteLine($"이름 : {name}");
            }
        }

    }
}
