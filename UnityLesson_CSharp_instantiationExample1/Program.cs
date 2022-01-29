using System;

namespace UnityLesson_CSharp_instantiationExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Orc();
            Orc A = new Orc();
            Orc B = new Orc();

            A.name = "상급오크";
            A.height = 240.2f;
            A.age = 140;
            A.weight = 200;
            A.isResting = false;
            A.sex = '남';

            if(A.isResting ==true)  // if(A.isResting) = A.isResting이 참이면 실행           f(A.isResting ==true) = A.isResting이 true와 같으면 실행(2단계)
            { 
                A.jump(); 
                A.smash(); 
            }
           else
            { 
                Console.WriteLine($"{A.name}(이)가 바쁘다");
            }

            B.name = "하급오크";
            B.height = 140.4f;
            B.age = 60;
            B.weight = 120;
            B.isResting = true;
            B.sex = '여';

            if (B.isResting)                // 이게 더 바람직한 방식
            {
                B.jump();   
                B.smash();  
            }
            else if( B.isResting == false)
            {
                Console.WriteLine($"{B.name}(이)가 바쁘다");
            }
    }
        }
    public class Orc
    {
        public string name;
        public float height;
        public int age;
        public int weight;
        public char sex;
        public bool isResting;

        public void jump()
        {
            Console.WriteLine($"{name}(이)가 점프했다.");
        }
        public void smash()
        {
            Console.WriteLine($"{name}(이)가 휘둘렀다."); 
        }
    }
}
