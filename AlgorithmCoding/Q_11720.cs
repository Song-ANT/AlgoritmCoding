﻿namespace AlgorithmCoding
{
    #region 문제
    /*
     숫자의 합
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	262263	145165	119432	55.877%
    문제
    N개의 숫자가 공백 없이 쓰여있다. 이 숫자를 모두 합해서 출력하는 프로그램을 작성하시오.

    입력
    첫째 줄에 숫자의 개수 N (1 ≤ N ≤ 100)이 주어진다. 둘째 줄에 숫자 N개가 공백없이 주어진다.

    출력
    입력으로 주어진 숫자 N개의 합을 출력한다.

    예제 입력 1 
    1
    1
    예제 출력 1 
    1
    예제 입력 2 
    5
    54321
    예제 출력 2 
    15
    예제 입력 3 
    25
    7000000000000000000000000
    예제 출력 3 
    7
    예제 입력 4 
    11
    10987654321
    예제 출력 4 
    46
     */
    #endregion

    public class Q_11720 : KataBase
    {
        public override void Example()
        {
            int t = int.Parse(Console.ReadLine());

            Solution(t);
        }

        private void Solution(int t)
        {
            string ex = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < t; i++)
            {
                sum += ((int)ex[i]) - '0';
            }

            Console.WriteLine(sum);
        }
    }

    #region ShortCoding
    public class Q_11720_ShortCoding
    {
        public void ShortCoding()
        {
            Console.ReadLine();
            Console.WriteLine(Console.ReadLine().Sum(x => x - '0'));
        }
    }
    #endregion

    #region CPP
    public class Q_11720_CPP
    {
        /*
         #import<ios>
        int a,b;
        main()
        {
            for(scanf("%*d"); ~scanf("%1d",&a); )
                b+=a;
            printf("%d",b);
        }
         */
    }
    #endregion
}