using System.ComponentModel.Design;

namespace AlgorithmCoding
{
    #region 문제
    /*
     숫자의 개수
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	128 MB	196014	118434	96793	60.055%
    문제
    세 개의 자연수 A, B, C가 주어질 때 A × B × C를 계산한 결과에 0부터 9까지 각각의 숫자가 몇 번씩 쓰였는지를 구하는 프로그램을 작성하시오.

    예를 들어 A = 150, B = 266, C = 427 이라면 A × B × C = 150 × 266 × 427 = 17037300 이 되고, 계산한 결과 17037300 에는 0이 3번, 1이 1번, 3이 2번, 7이 2번 쓰였다.

    입력
    첫째 줄에 A, 둘째 줄에 B, 셋째 줄에 C가 주어진다. A, B, C는 모두 100보다 크거나 같고, 1,000보다 작은 자연수이다.

    출력
    첫째 줄에는 A × B × C의 결과에 0 이 몇 번 쓰였는지 출력한다. 마찬가지로 둘째 줄부터 열 번째 줄까지 A × B × C의 결과에 1부터 9까지의 숫자가 각각 몇 번 쓰였는지 차례로 한 줄에 하나씩 출력한다.

    예제 입력 1 
    150
    266
    427
    예제 출력 1 
    3
    1
    0
    2
    0
    0
    0
    2
    0
    0
     */
    #endregion

    public class Q_2577 : KataBase
    {
        public override void Example()
        {
            int[] ex = Enumerable.Range(1, 3).Select(i => int.Parse(Console.ReadLine())).ToArray();

            Solution(ref ex);
        }

        private void Solution(ref int[] ex)
        {
            long answer = ex.Aggregate((a, b) => a * b);

            int[] digitCounts = new int[10];

            foreach (char digit in answer.ToString())
            {
                digitCounts[digit - '0']++;
            }

            foreach (int count in digitCounts)
            {
                Console.WriteLine(count);
            }
        }
    }

    #region ShotCoding
    public class Q_2577_ShotCoding
    {
        private void ShotCoding()
        {
            int ABC = 1;
            int[] count = new int[10];
            for (int i = 0; i < 3; i++) ABC *= int.Parse(Console.ReadLine());
            string N = Convert.ToString(ABC);
            foreach (char i in N) count[(int)char.GetNumericValue(i)]++;
            foreach (int i in count) Console.WriteLine(i);
        }
    }
    #endregion

    #region CPP
    public class Q_2577_CPP
    {
        private void CPP()
        {
            //# include<stdio.h>
            //int a, b, c, x[10], i;
            //main(){
            //    scanf("%d%d%d", &a, &b, &c);
            //    a *= b * c;
            //    while (a)
            //    {
            //        x[a % 10]++;
            //        a /= 10;
            //    }
            //    for (i = 0; i < 10; i++) printf("%d\n", x[i]);
            //}
        }
    }

    #endregion
}
