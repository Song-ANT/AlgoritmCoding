namespace AlgorithmCoding
{
    public class Q_2439 : KataBase
    {
        /*
         별 찍기 - 2
        시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
        1 초	128 MB	333033	185767	156627	55.997%
        문제
        첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

        하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.

        입력
        첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

        출력
        첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.

        예제 입력 1 
        5
        예제 출력 1 
            *
           **
          ***
         ****
        *****
         */

        public override void Example()
        {
            int ex = int.Parse(Console.ReadLine());

            solution(ex);
        }

        private void solution(int ex)
        {
            for (int i = 0; i < ex; i++)
            {
                for (int j = 1; j < ex - i; j++)
                {
                    Console.Write(" ");
                }

                for(int j = ex-i; j <= ex; j++)
                {
                    Console.Write("*");
                }

                if (i == ex - 1) break;
                Console.WriteLine();
            }

        }
    }

}