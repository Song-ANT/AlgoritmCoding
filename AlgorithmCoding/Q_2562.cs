using System.ComponentModel.Design;

namespace AlgorithmCoding
{
    #region 문제
    /*
    최댓값
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	128 MB	328469	151199	124934	45.435%
    문제
    9개의 서로 다른 자연수가 주어질 때, 이들 중 최댓값을 찾고 그 최댓값이 몇 번째 수인지를 구하는 프로그램을 작성하시오.

    예를 들어, 서로 다른 9개의 자연수

    3, 29, 38, 12, 57, 74, 40, 85, 61

    이 주어지면, 이들 중 최댓값은 85이고, 이 값은 8번째 수이다.

    입력
    첫째 줄부터 아홉 번째 줄까지 한 줄에 하나의 자연수가 주어진다. 주어지는 자연수는 100 보다 작다.

    출력
    첫째 줄에 최댓값을 출력하고, 둘째 줄에 최댓값이 몇 번째 수인지를 출력한다.

    예제 입력 1 
    3
    29
    38
    12
    57
    74
    40
    85
    61
    예제 출력 1 
    85
    8
     */
    #endregion



    public class Q_2562 : KataBase
    {
        public override void Example()
        {
            int maxNum;
            int index;
            string[] ex = new string[9];


            for (int i = 0; i < 9; i++)
            {
                ex[i] = Console.ReadLine();
            }


            (maxNum, index)= Solution(ref ex);
            Console.WriteLine(maxNum + "\n" + index);
        }

        private (int, int) Solution(ref string[] ex)
        {
            int max = -1;
            int index = -1;

            for(int i = 0; i < ex.Length; i++)
            {
                int temp = int.Parse(ex[i]);
                if(temp > max)
                {
                    max = temp;
                    index = i+1;
                }
            }

            return (max, index);
        }

    }

    #region StortCoding
    public class Q_2562_ShortCoding
    {
        private void Solution()
        {
            int[] n = new int[9];
            for (int i = 0; i < 9; i++)
                n[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n.Max()}\n{Array.IndexOf(n, n.Max()) + 1}");
        }
    }
    #endregion

    #region C++
    public class Q_2562_CPP
    {
        //# include<stdio.h>
        //int main()
        //{
        //    int m = 0, a, r;
        //    for (int i = 1; i <= 9; i++)
        //    {
        //        scanf("%d", &a);
        //        if (a > m) m = a,r = i;
        //    }
        //    printf("%d\n%d", m, r);
        //}
    }

    #endregion

}