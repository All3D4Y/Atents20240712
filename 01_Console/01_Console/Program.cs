using System.Net;
using System.Xml.Linq;

namespace _01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 주석
            ///*
            // * 여러줄
            // */

            /////엔터치면 아래줄 주석
            /////

            //// F9 브레이크포인트
            //// F10 다음줄
            //// F5 디버그, 디버깅 중엔 다음 브레이크포인트까지 진행

            //// ctrl + d 현재 코드 복붙
            //// shift + del 현재 줄 지움

            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("slsllddfk");

            //// 변수 : 데이터를 저장한 곳 (메모리에서의 위치)
            //// 함수 : 특정기능수행 코드덩어리
            //// 클래스 : 특정한 동작을 하는 물체를 표현하기 위해 변수와 함수를 모아 놓은 것

            //// 데이터 타입 변수의 종류
            //// int 32bit 42억 사이즈 넘어가면 실행안됨
            //// float 에 정수 값 가능 소수점 7자리 넘어가면 깨짐
            //// bool
            //// string 문자열의 비교는 작업량이 많아서 피하는게 좋음, 문자열 더하기 금지(메모리 잡아먹음)
            //// $"~~~~~{변수}~~~"
            //int a = 10;
            //Console.WriteLine($"hello{a} world!");
            //// double 소수점 14자리 넘어가면 깨짐

            ////값타입 (Value Type) 스택 메모리에 저장, int, float, bool
            ////참조타입 (Reference Type) 힙 메모리에 저장, string, 기타 클래스

            ////null 참조타입만 가능
            ////nullable type 값타입에 붙여 null 가능
            //int? a; // a 는 null
            //a = 10; // a 는 10
            //string? text = Console.ReadLine();

            ////실습
            ////1. 이름 입력받기 ("이름을 입력하세요 : " 라고 출력하고 입력받기)
            ////2. 나이 입력
            ////3. 주소 입력
            ////4. 이름, 나이, 주소 출력

            /*Console.Write("이름을 입력하세요 : ");
            string? name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            string? age = Console.ReadLine();
            //int intAge = int.Parse(age);
            Console.Write("주소를 입력하세요 : ");
            string? address = Console.ReadLine();
            //Console.WriteLine($"이름 : {name}\n나이 : {age} \n주소 : {address}");
            PrintMyData(name, age, address);*/

            //제어문 (Control Statement)

            //실습
            //1. 나이 입력받기
            //2. 8살 미만 - 미취학 아동입니다
            //3. 13살 미만 - 초등학생입니다
            //4. 16살 미만 - 중학생
            //5. 19살 미만 고등학생


            //Console.Write("나이를 입력하세요 : ");
            //string? age = Console.ReadLine();
            //int? intAge = int.Parse(age);
            //int? ageRange;
            //if (intAge < 8)
            //{
            //    Console.WriteLine("미취학 아동입니다.");
            //    ageRange = 0;
            //}
            //else if (intAge < 13)
            //{
            //    Console.WriteLine("초등학생입니다.");
            //    ageRange = 1;
            //}
            //else if (intAge < 16)
            //{
            //    Console.WriteLine("중학생입니다.");
            //    ageRange = 2;
            //}
            //else if (intAge < 19)
            //{
            //    Console.WriteLine("고등학생입니다.");
            //    ageRange = 3;
            //}
            //else
            //{
            //    Console.WriteLine("성인입니다.");
            //    ageRange = 4;
            //}

            //switch (ageRange)
            //{
            //    case 0:
            //        Console.WriteLine("입장료: 무료");
            //        break;
            //    case 1:
            //        Console.WriteLine("입장료: 3000원");
            //        break;
            //    case 2:
            //        Console.WriteLine("입장료: 4000원");
            //        break;
            //    case 3:
            //        Console.WriteLine("입장료: 5000원");
            //        break;
            //    case 4:
            //        Console.WriteLine("입장료: 10000원");
            //        break;
            //}

            //string -> int
            //int a;
            //int a = int.Parse();
            //int point;
            //if(int.TryParse(Console.ReadLine(), out point))
            //{
            //    Console.WriteLine("정상변환");
            //}
            //else
            //{
            //    Console.WriteLine("변환실패");
            //}

            //실습
            //성적용 enum A, B, C, D, F
            //점수 입력받아 90이상 A, 80이상 B, 70이상 C, 60이상 D
            Console.Write("점수를 입력하세요: ");
            string? score = Console.ReadLine();
            int intScore;
            Grade grade = Grade.F;
            if(int.TryParse(score, out intScore))
            {
                if (intScore > 89)
                {
                    grade = Grade.A;
                }
                else if (intScore > 79)
                {
                    grade = Grade.B;
                }
                else if (intScore > 69)
                {
                    grade = Grade.C;
                }
                else if (intScore > 59)
                {
                    grade = Grade.D;
                }

                Console.WriteLine($"성적은 {grade}입니다.");
            }
            else
            {
                Console.WriteLine("점수가 잘못입력되었습니다.");
            }

            //비트연산자 a = 0b_0111_1011; 이진수로 쓴 123
            //int b1 = 0b_1010;
            //int b2 = 0b_1100;
            //int c1 = b1 & b2; //0b_1000
            //int c2 = b1 | b2; //0b_1110

        }

        enum Grade
        {
            A, B, C, D, F
        }

        //enum AgeCategory
        //{
        //    Child,
        //    Elementy,
        //    Middle,
        //    High,
        //    Adult
        //}
        //리턴타입(없으면 void) 함수이름(파라미터(0개 이상)) {함수 바디: 함수 실행의 실제 코드}
        static void PrintMyData(string? name, string? age, string? address)
        {
            Console.WriteLine($"이름 : {name}\n나이 : {age} \n주소 : {address}");
        }
    }
}
