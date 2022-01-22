using System;
// 파랑이 = 키워드,예약어 : visual studio가 먼저 정의해 놓은 함수

//using ='사용하겠다.' c언어의 include 같음.
//1. '미리 짜여진 코드 덩어리'를 사용하고자 할 때.
//2. 우선수위, 차순위인 함수를 일반적으로 호출 할 때.     ------------???



// namespace = 클래스간의 이름 충돌을 방지하면서
//             코드를 한 공간으로 묶는 기능.

namespace UnityLesson_Csharp_ProgramClass_Dothnet5
{
    // main 함수가 program 클래스 안에 들어있는 이유 : 객체지향 프로그래밍 컨셉을 지키기 위해서임.
    internal class Program
    {
        // main 함수 : .exe(실행파일)을 실행하면 제일 처음 호출되는 함수.
            


        //stacic(정적) <-> dynamic(동적)
        // 소프트웨어에서 
        // 정적 : 메모리에 할당이 불가능하다. - 객체화 불가능
        // 동적 : 메모리에 할당이 가능하다. - 객체화 가능 

        //static 이라고 정의되면 유일무의한 개념이 된다.

        //void : '아무것도 없음'을 뜻함 & 함수에서는 반환형이 없다.
                 

        //console : 콘솔창에서 실행해라.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
