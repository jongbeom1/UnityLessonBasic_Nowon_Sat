using System;

namespace UnityLesson_CSharp_staticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Orc();
            Orc A = new Orc();
            A.name = "오크부장";
            A.height = 318.01f;
            A.isResting = true;
            A.genderChar = 'M';
            A.Jump();
            A.Smash();
            Console.WriteLine($"{A.height}");
            Console.WriteLine(A.genderChar);

            Console.WriteLine("\n\n");

            //static으로 정의된 멤버변수,함수는 class name을 통해서 설정가능
            Orc.typename = "오크타입";
            Orc.SayTipeName(); ;

            Console.WriteLine("\n\n");

            new NPC();
            NPC AA = new NPC();

            AA.cliked();

            // static으로 정의된  class는 객체화시킬 수 없다.(인스턴스화 시킬 수 없다)
            //new Person();
            //Person person = new Person();
        }
    }
    static public class Person
    {
    }

    public class Orc
    {//멤버 변수
        static public string typename;
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;

        //멤버 함수
        public void Jump()
        {
            Console.WriteLine($"{name}이(가) 점프했다.");
        }
        public void Smash()
        {
            Console.WriteLine($"{name}이(가) 휘둘렀다.");
        }

        //static 함수에 들어갈 수 있는 변수는 static으로 정의된 함수이다.
        static public void SayTipeName()
        {
            Console.WriteLine(typename);
        }
    }
    public class NPC
    {
        public string name;
        public int age;
        public float height;
        public string job;

        public void cliked()
        {
            Console.WriteLine(" 왜불렀어? ");
        }
    }
}
