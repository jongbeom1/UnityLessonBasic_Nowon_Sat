using System;

namespace UnityLesson_CSharp_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {            
          // 사람이라는 객체를 만들거임
          // 사람이라는 객체를 만들기위해서 설계도(클레스)를 만들것임
          //




        }
    }

    //클래스 : clss 이름 {}
    //변수 선언 형태 : 자료형(타입) 변수이름   ex) int 바보
    class Pesrson    //사람이라는 설계도를 만들었음.
    {
        //필요한 요소(변수) : 1.나이(정수형)  2.키(실수형)  3.몸무게(실수형)  4.성별(문자형)  5.이름(문자열)  6. 직업이 있는가?(true or not)
        // = Person 클래스의 멤버 변수이다. / Person클레스를 구성하고있는 변수(필드)이다.
                                        
        // 1.나이(정수형)  int = 4byte  범위 = -2^16~-+2^16-1 (대략21억)     /   long = 8byte 정수            
        int age;
        //2.키(실수형)   float = 4byte    /      double = 8byte 실수
        float height;
        // 3.몸무게(실수형)
        float weight;
        //4.성별(문자형)  char = 2byte 
        char gender;
        //5.이름(문자열)   string = 문자갯수 *2byte     
        string name;     
            //6. 직업이 있는가 (true or not)(논리형)    //논리형 (bool): 참과 거짓으로 나눌 수 있는 자료형  // bool = 1 byte  //0000 0000=거짓, 하나라도 1이 들어가 있다면 참
        bool career;



    }
}
   
// bit(비트) = 한자리 2진수, 0과1로 나타냄, 정보처리의 최소단위
// byte(바이트) = 8bit (CPU의 데이터 처리 최소단위)
// ex) 4byte = 4*8bit = 32bit = 2^32개의 수의 범위를 표현 할 수 있다.