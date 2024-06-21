namespace AlgorithmCoding
{
    #region 문제
    /*
     A+B - 3
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	316779	184713	154255	58.413%
    문제
    두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

    입력
    첫째 줄에 테스트 케이스의 개수 T가 주어진다.

    각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)

    출력
    각 테스트 케이스마다 A+B를 출력한다.

    예제 입력 1 
    5
    1 1
    2 3
    3 4
    9 8
    5 2
    예제 출력 1 
    2
    5
    7
    17
    7
    */
#endregion

    public class Q_10950 : KataBase
    {
        public override void Example()
        {
            int t = int.Parse(Console.ReadLine());

            Enumerable.Range(0, t).ToList().ForEach(_ => Solution());
        }

        private void Solution()
        {
            (int a, int b) = Array.ConvertAll(Console.ReadLine().Split(), int.Parse)
                switch { var arr => (arr[0], arr[1]) };

            Console.WriteLine(a + b);
        }
    }

    #region ShortCoding
    public class Q_10950_ShortCoding
    {
        public void ShortCoding()
        {
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--) 
            { 
                var a = Console.ReadLine(); Console.WriteLine($"{a[0] + a[2] - 96}"); 
            }
        }
    }
    #endregion

    #region CPP
    public class Q_10950_CPP
    {
        /*
         #import<cstdio>
        int a,b,t;main()
        {
            scanf("%d",&t);
            while(t--)scanf("%d%d",&a,&b),printf("%d\n",a+b);
        }
         */
    }
    #endregion
}