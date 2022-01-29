using System;

namespace UnityLesson_CSharp_ClassObjectInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AA 객체 생성
            // 객체 생성에 쓰는 키워드 : new
            new AA();               //생성자 : 클래스 이름과 똑같은 함수, 객체를 생성하고 반환함.
            //인스턴스화
            AA aa = new AA();       //반환할 값을 넣어줘야함.         //객체를 생성하고 생성된 객체를 똑같은 타입의 함수에 넣어주는 것.
                                                                     // 메모리 공간에 객체를 할당 시킨다.
                                                                    // new AA()로 생성된 객체를 반환한 값(객체)이 AA타입의 변수 aa에 할당되었다.
                                                                   // 이렇게하면 aa변수를 통해서 생선된 객체에 접근 할 수 있다.
                                                                  // 여기서 새로 생성된 객체가 할당된 aa변수를 '인스턴스'라고 한다.
         }

        //AA클래스
        /*접근 제한자 근
        종류
        1. public : 다른 모든 class에서 접근 가능.
        2. private : 다른 class에서 접근 불가능
        3. protected : 상속받은 class에서만 접근 가능
        4. internal : 같은 어셈블리(같은 프로젝트)에서만 접근 가능.
        // 접근 제한자를 명시하지 않으면 private이 디폴트값(고정값)
        */

        public class AA
        {

        }
    }
}
