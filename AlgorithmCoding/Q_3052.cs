namespace AlgorithmCoding
{

    #region 문제
    /*
        나머지 다국어
        시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
        1 초	128 MB	219397	126701	105431	57.670%
        문제
        두 자연수 A와 B가 있을 때, A%B는 A를 B로 나눈 나머지 이다. 예를 들어, 7, 14, 27, 38을 3으로 나눈 나머지는 1, 2, 0, 2이다. 

        수 10개를 입력받은 뒤, 이를 42로 나눈 나머지를 구한다. 그 다음 서로 다른 값이 몇 개 있는지 출력하는 프로그램을 작성하시오.

        입력
        첫째 줄부터 열번째 줄 까지 숫자가 한 줄에 하나씩 주어진다. 이 숫자는 1,000보다 작거나 같고, 음이 아닌 정수이다.

        출력
        첫째 줄에, 42로 나누었을 때, 서로 다른 나머지가 몇 개 있는지 출력한다.

        예제 입력 1 
        1
        2
        3
        4
        5
        6
        7
        8
        9
        10
        예제 출력 1 
        10
        각 수를 42로 나눈 나머지는 1, 2, 3, 4, 5, 6, 7, 8, 9, 10이다.

        예제 입력 2 
        42
        84
        252
        420
        840
        126
        42
        84
        420
        126
        예제 출력 2 
        1
        모든 수를 42로 나눈 나머지는 0이다.

        예제 입력 3 
        39
        40
        41
        42
        43
        44
        82
        83
        84
        85
        예제 출력 3 
        6
     */
    #endregion

    public class Q_3052 : KataBase
    {
        public override void Example()
        {
            int[] ex = new int[10];

            for(int i = 0; i < 10 ; i++)
            {
                ex[i] = int.Parse(Console.ReadLine());  
            }

            Solution(ref ex);
        }

        private void Solution(ref int[] ex)
        {
            int res = 0;
            int[] arr = new int[42];

            foreach(int item in ex)
            {
                arr[item % 42]++;
            }

            foreach(int item in arr)
            {
                if (item != 0) res++;
            }

            Console.WriteLine(res);
        }
    }

    #region ShortCoding
    public class Q_3052_ShortCoding
    {
        public void ShortCoding()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; ++i)
                arr[i] = int.Parse(Console.ReadLine()) % 42;
            Console.Write(arr.Distinct().Count());
        }
    }
    #endregion

    #region CPP
    /*
     #import<cstdio>
    int a[42],n,s;
    main(){while(scanf("%d",&n)>0)a[n%42]=1;for(int n:a)s+=n;printf("%d",s);}
     */
    #endregion
}