namespace AlgorithmCoding
{
    #region 문제
    /*
     A+B - 5
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	299216	157533	134085	52.409%
    문제
    두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

    입력
    입력은 여러 개의 테스트 케이스로 이루어져 있다.

    각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)

    입력의 마지막에는 0 두 개가 들어온다.

    출력
    각 테스트 케이스마다 A+B를 출력한다.

    예제 입력 1 
    1 1
    2 3
    3 4
    9 8
    5 2
    0 0
    예제 출력 1 
    2
    5
    7
    17
    7
     */
    #endregion

    public class Q_10952 : KataBase
    {
        public override void Example()
        {
            bool end = false;
            do
            {
                (int a, int b) = Array.ConvertAll(Console.ReadLine().Split(), int.Parse)
                    switch{ var arr => (arr[0], arr[1]) };
                if (a == 0 && b == 0) { end = true; break; }

                Solution(a, b);
            } while (!end);
        }

        private void Solution(int a, int b) => Console.WriteLine(a+b);
    }

    #region ShortCoding
    public class Q_10952_ShortCoding
    {
        public void ShortCoding()
        {
            string t;
            while ((t = Console.ReadLine()) != null && t != "0 0")
            {
                Console.WriteLine(t.Split(" ").Select(int.Parse).Sum());
            }
        }
    }
    #endregion

    #region CPP
    public class Q_10952_CPP
    {
        /*
         #import<ios>
        main(){for(int a,b;scanf("%d%d",&a,&b)*a;printf("%d ",a+b));}
         */
    }
    #endregion
}