using System;

namespace UnityLession_CSharp_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c = 0;

            /*산술연산
              종류 : 더하기, 빼기, 곱하기, 나누기-몫을 반환 , 나머지 - 몫 제외 나머지 반환
                             
            --------------------------------------------------------------------------------------
            */
            //더하기
            c = OperatorMethod.Sum(a, b);
             Console.WriteLine(c);
             //뺴기
             c = a - b;
             Console.WriteLine(c);
             //나누기
             c = a / b;
             Console.WriteLine(c);
             //곱하기
             c = a * b;
             Console.WriteLine(c);
             //나머지
             c = a % b;
             Console.WriteLine(c);

            /*증강 연산
             종류 : 증가 연산자, 감소 연산자
          --------------------------------------------------------------------------------------------------
            */
            // 증가 연산자
              c++; // C= C+1
              Console.WriteLine(c);
              // 감소 연산자
              c--;// C=C-1
              Console.WriteLine(c);

            Console.WriteLine("\n\n");
            /*관계 연산
             종류 : 등호, 부등호               --- 같음,다름, 크기비교
            관계 연산자가 참이면  true,  거짓이면 false를 반환
             --------------------------------------------------------------------------------------------------
            */
            bool result;
            // 같음 비교
              result = OperatorMethod.big(a,b);
              Console.WriteLine(result);
              //다름 비교
              result = a != b;
              Console.WriteLine(result);
              // 크다
              result = a > b;
              Console.WriteLine(result);
              //크거나 같다
              result = a >= b;
              Console.WriteLine(result);
              //작다
              result = a < b;
              Console.WriteLine(result);
              //직가니 깉다
              result = a <= b;
              Console.WriteLine(a <= b);
  
            Console.WriteLine("\n\n");
            /*논리 연산 ( 논리 자료형 연산 = bool형 끼리의 연산)
             양측의 피연산자들을 비교해서 연산 수행
            종류 : or, and, xor, not
            --------------------------------------------------------------------------------------------------
            */
            bool A = true;
            bool B = false;

            // or연산    : a와 b 둘 중 하나라도 참이라면 true반환, 두 개 다 거짓이면 false반환

             result = OperatorMethod.oor(A,B);
             Console.WriteLine(result);           // A가 참이기에  true 반환

             //and 연산 : a와 b 둘 다 참이여야 true 반환
             result = A & B;
             Console.WriteLine(result);          //B가 거짓이라 false반환

             // Xor (^) : a와 b 둘 중 하나만 참일 때 true 반환, 나머지 false
             result = A ^ B;
             Console.WriteLine(result);         //둘 다 참 or 둘 다 거짓 이면 false반환

             //not (!) : 반대 부호 반환                = true면 false/       false면 true 반환
             result = OperatorMethod.not(A);
             Console.WriteLine(result);

             Console.WriteLine("\n\n");
            /*--------------------------------------------------------------------------------------------------
               조건부 논리연산 : 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지말지 평가 후에 연산
               종류 : cnoditional or,     conditional and 
             */
            

             //conditional or (||)
             result = A || B;                  //A가 true이면 굳이 B를 비교 안 하고 true 반환.    연산의 최적화가 목적

             //conditional and (&&)
             result = B && A;                 // B가 false이면 A를 보지 않고 false를 반환.
 


            Console.WriteLine("\n\n");
            /*--------------------------------------------------------------------------------------------------
              비트연산 : 
              목적 : 데이터를 효율적으로 관리하기 위함
              종류 : or, and, xor, not, shift-left, shift-right      /정수형에서 사용해야 먹음.
              원리 : 10진수를 2진수로 변환하여 비교해서 비트끼리 논리연산
            */
            int howManyBitYouShift=3;

            c = a | b;
            Console.WriteLine(c);
            c = a & b;
            Console.WriteLine(c);
            c = a ^ b;
            Console.WriteLine(c);
            
            // not 비트연산
            c= ~a;
            Console.WriteLine(c);

            //shift-left : 비트 전체를 왼쪽으로 옮겨줌. 마지막에 있던 비트는 없어짐
            c = a << howManyBitYouShift;
            Console.WriteLine(c);
            //shift-right 
            c= a >> 3;             //  숫자 넣어도 되네
            Console.WriteLine(c);

            c= OperatorMethod.shift_left(a);
            Console.WriteLine(c);

            c = OperatorMethod.shift_right(a);
            Console.WriteLine(c);





        }
        //FSM (Finite State Machine) 유한상태머신
        //  클래스의 상태에 따라 동작을 제한 or 허용하기 위해 사용
        //  플레이어가 IDLE 일 때만 귀환 허용,  다른 상태일 때는 비허용
        //  아래의 함수를 활용하여 사용.
        //  또는 연속 공격을 연결할 때 사용.

        [Flags]
        public enum e_FSM
        {
            IDLE = 0,
            피격당한상태 = 1 << 0,
            공격당한상태 = 1 << 1,
            스킬쓰는상태 = 1 << 2,
            죽은상태 = 1 << 3
        }
    }

}