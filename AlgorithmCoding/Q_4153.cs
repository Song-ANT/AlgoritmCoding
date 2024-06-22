namespace AlgorithmCoding
{
    #region 문제
    /*
     직각삼각형 다국어
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	128 MB	94306	48305	43117	50.877%
    문제
    과거 이집트인들은 각 변들의 길이가 3, 4, 5인 삼각형이 직각 삼각형인것을 알아냈다. 주어진 세변의 길이로 삼각형이 직각인지 아닌지 구분하시오.

    입력
    입력은 여러개의 테스트케이스로 주어지며 마지막줄에는 0 0 0이 입력된다. 각 테스트케이스는 모두 30,000보다 작은 양의 정수로 주어지며, 각 입력은 변의 길이를 의미한다.

    출력
    각 입력에 대해 직각 삼각형이 맞다면 "right", 아니라면 "wrong"을 출력한다.

    예제 입력 1 
    6 8 10
    25 52 60
    5 12 13
    0 0 0
    예제 출력 1 
    right
    wrong
    right
     */
    #endregion

    public class Q_4153 : KataBase
    {
        public override void Example()
        {
            bool isEnd = false;

            while (!isEnd)
            {
                isEnd = Solution();
            }
        }

        private bool Solution()
        {
            (int a, int b, int c) = Array.ConvertAll(Console.ReadLine().Split(), int.Parse)
                switch { var arr => (arr[0], arr[1], arr[2]) };
            if (a == 0 && b == 0 && c == 0) return true;

            Max_C(ref a, ref b, ref c);
            if (Pitagoras(a, b, c)) Console.WriteLine("right");
            else Console.WriteLine("wrong");
            return false;
        }

        private void Max_C(ref int a, ref int b, ref int c)
        {
            if (a > c) (a, c) = (c, a);
            if (b > c) (b, c) = (c, b);
        }

        private bool Pitagoras(int a, int b, int c)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ? true : false;
        }
    }

    #region ShortCoding
    public class Q_4153_ShortCoding
    {
        public void ShortCoding() 
        {
            while (true)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (l[0] == 0) return;
                int c = l.Max(); l = l.Where(a => a != c).ToArray();
                Console.WriteLine(l[0] * l[0] + l[1] * l[1] == c * c ? "right" : "wrong");
            }
        }
    }
    #endregion

    #region CPP
    public class Q_4153_CPP
    {
        /*
         #include<iostream>
         int main(){
            int a,b,c;
            
            while(1)
            {
                std::cin>>a>>b>>c;
                if(!a)break;
                a*=a;
                b*=b;
                c*=c;
                std::cout<<((a+b==c||a+c==b||b+c==a) ? "right\n" : "wrong\n");
            }
        }
         */
    }
    #endregion
}