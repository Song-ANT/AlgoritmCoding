namespace AlgorithmCoding
{
    #region 문제
    /*
     사칙연산
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	554645	249742	210359	45.110%
    문제
    두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 

    입력
    두 자연수 A와 B가 주어진다. (1 ≤ A, B ≤ 10,000)

    출력
    첫째 줄에 A+B, 둘째 줄에 A-B, 셋째 줄에 A*B, 넷째 줄에 A/B, 다섯째 줄에 A%B를 출력한다.

    예제 입력 1 
    7 3
    예제 출력 1 
    10
    4
    21
    2
    1
     */
    #endregion


    public class Q_10869 : KataBase
    {
        public override void Example()
        {
            int[] ex = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Solution(ref ex);
        }

        private void Solution(ref int[] ex)
        {
            Console.WriteLine($"{Calculator(((x, y) => x + y), ex[0], ex[1])}");
            Console.WriteLine($"{Calculator(((x, y) => x - y), ex[0], ex[1])}");
            Console.WriteLine($"{Calculator(((x, y) => x * y), ex[0], ex[1])}");
            Console.WriteLine($"{Calculator(((x, y) => x / y), ex[0], ex[1])}");
            Console.WriteLine($"{Calculator(((x, y) => x % y), ex[0], ex[1])}");
        }

        private int Calculator(Func<int, int, int> operation, int a, int b)
        {
            return operation(a, b);
        }
    }

    #region ShortCoding
    public class Q_10869_ShortCoding
    {
        public void ShortCoding()
        {
            var x = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            var (a, b) = (x[0], x[1]);
            Console.Write($"{a + b}\n{a - b}\n{a * b}\n{a / b}\n{a % b}");
        }
    }
    #endregion

    #region CPP
    public class Q_10869_CPP
    {
        public void CPP()
        {
            /*
             #import<iostream>
            main()
            {
                int a,b;std::cin>>a>>b;
                printf("%d %d %d %d %d",a+b,a-b,a*b,a/b,a%b);
            }
             */
        }
    }
    #endregion
}