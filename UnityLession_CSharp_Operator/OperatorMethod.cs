using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLession_CSharp_Operator
{
    static public class OperatorMethod
    {
        //산술연산
        // =======================================================
       
        static public int Sum(int a, int b)
        { return a + b; }

        static public int Minus(int a, int b)
        { return a - b; }
        
        static public int Xoab(int a, int b)
        { return a * b; }
        
        static public int share(int a, int b)
        { return a / b; }

        static public int trash(int a, int b)
        { return a % b; }

        // 종류 : 증가 연산자, 감소 연산자
        static public int add(int a)
        { return a++; }
        static public int minor(int a)
        { return a--; }

        //관계 연산
        //     종류 : 등호, 부등호               --- 같음,다름, 크기비교
         static public bool big(int a, int b)
        { return a > b; }
        static public bool small(int a, int b)
        { return a < b; }
        static public bool bigOrSame(int a, int b)
        { return a >= b; }
        static public bool smallOrSame(int a, int b)
        { return a <= b; }

        /*논리 연산 ( 논리 자료형 연산 = bool형 끼리의 연산)
             양측의 피연산자들을 비교해서 연산 수행
            종류 : or, and, xor, not 
        */
        static public bool oor(bool a, bool b)
        { return a | b; }
        static public bool aand(bool a, bool b)
        { return a & b; }
        static public bool xxor(bool a, bool b)
        { return a ^ b; }
        static public bool not(bool a)
        { return !a; }


        // 조건부 논리연산 : 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지말지 평가 후에 연산
        // 종류 : cnoditional or,     conditional and 
        static public bool conditionOr(bool a, bool b)
        { return a || b; }
        static public bool conditionAnd(bool a, bool b)
        { return a && b; }

        /*
              비트연산 : 
              목적 : 데이터를 효율적으로 관리하기 위함
              종류 : or, and, xor, not, shift-left, shift-right      /정수형에서 사용해야 먹음.
              원리 : 10진수를 2진수로 변환하여 비교해서 비트끼리 논리연산
        */
        static public int bitOr(int a, int b)
        { return a | b; }
        static public int bitAnd(int a, int b)
        { return a & b; }
        static public int bitXor(int a, int b)
        { return a ^ b; }
        static public int bitnot(int a)
        { return ~a; }
        static public int shift_left(int a)
        { return a<<1 ; }
        static public int shift_right(int a)
        { return a >> 1; }


    }

}
