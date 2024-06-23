namespace AlgorithmCoding
{
    #region 문제
    /*
     소수 찾기
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    2 초	128 MB	212649	100752	80666	47.237%
    문제
    주어진 수 N개 중에서 소수가 몇 개인지 찾아서 출력하는 프로그램을 작성하시오.

    입력
    첫 줄에 수의 개수 N이 주어진다. N은 100이하이다. 다음으로 N개의 수가 주어지는데 수는 1,000 이하의 자연수이다.

    출력
    주어진 수들 중 소수의 개수를 출력한다.

    예제 입력 1 
    4
    1 3 5 7
    예제 출력 1 
    3
     */
    #endregion

    public class Q_1978 : KataBase
    {
        int N;
        int[] ex;
        int Prime = 0;

        public override void Example()
        {
            N = int.Parse(Console.ReadLine());
            ex = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Solution();
        }

        private void Solution()
        {
            foreach (int item in ex) 
            {
                if (IsPrime(item)) Prime++;
            }

            Console.WriteLine(Prime);
        }

        private bool IsPrime(int item)
        {
            if (item < 2) return false;

            for(int i = 2; i<= Math.Sqrt(item); i++)
            {
                if(item % i == 0) return false;
            }

            return true;
        }
    }

    #region ShortCoding
    public class Q_1978_ShortCoding
    {
        public void ShortCoding()
        {
            Console.ReadLine();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int o = 0;
            bool b;
            foreach (int i in n)
            {
                b = true;
                for (int j = i / 2; j > 1; j--) { if (i % j == 0) b = false; }
                if (b & i != 1) o++;
            }
            Console.Write(o);
        }
    }
    #endregion

    #region CPP
    public class Q_1978_CPP
    {
        /*
         #include<iostream>
        int main()
            {
                int T,N,C=0,p,i;
                std::cin>>T;
                while(T--)
                {
                    std::cin>>N;
                    p=1;
                    for(i=2;i<N;i++) 
                        if(N%i==0)p=0;
                        if(N==1)p=0;
                        if(p)C++;
                }
                std::cout<<C;}
         */
    }
    #endregion
}