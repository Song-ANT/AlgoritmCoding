namespace AlgorithmCoding
{
    #region 문제
    /*
     A×B
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	319293	243007	213697	76.934%
    문제
    두 정수 A와 B를 입력받은 다음, A×B를 출력하는 프로그램을 작성하시오.

    입력
    첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)

    출력
    첫째 줄에 A×B를 출력한다.

    예제 입력 1 
    1 2
    예제 출력 1 
    2
    예제 입력 2 
    3 4
    예제 출력 2 
    12
     */
    #endregion

    public class Q_10998 : KataBase
    {
        public override void Example()
        {
            (int a, int b) = Array.ConvertAll(Console.ReadLine().Split(), int.Parse)
                    switch{ var i => (i[0], i[1]) };

            Solution(a, b);
        }

        private void Solution(int a, int b) => Console.WriteLine(a * b);
    }

    #region ShortCoding
    public class Q_10998_ShrotCoding
    {
        public void ShortCoding()
        {
            var _ = Console.ReadLine(); Console.Write((_[0] - 48) * (_[2] - 48));
        }
    }
    #endregion

    #region CPP
    public class Q_10998_CPP
    {
        /*
         #import<iostream>
        main(){int a,b;std::cin>>a>>b;std::cout<<a*b;}
         */
    }
    #endregion
}