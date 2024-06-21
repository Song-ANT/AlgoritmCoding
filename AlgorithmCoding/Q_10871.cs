namespace AlgorithmCoding
{
    #region 문제
    /*
     X보다 작은 수
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	324344	177132	142953	54.249%
    문제
    정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 이때, A에서 X보다 작은 수를 모두 출력하는 프로그램을 작성하시오.

    입력
    첫째 줄에 N과 X가 주어진다. (1 ≤ N, X ≤ 10,000)

    둘째 줄에 수열 A를 이루는 정수 N개가 주어진다. 주어지는 정수는 모두 1보다 크거나 같고, 10,000보다 작거나 같은 정수이다.

    출력
    X보다 작은 수를 입력받은 순서대로 공백으로 구분해 출력한다. X보다 작은 수는 적어도 하나 존재한다.

    예제 입력 1 
    10 5
    1 10 4 9 2 3 8 5 7 6
    예제 출력 1 
    1 4 2 3
     */
    #endregion

    public class Q_10871 : KataBase
    {
        public override void Example()
        {
            (int n, int x) = Array.ConvertAll(Console.ReadLine().Split(), int.Parse)
                switch { var arr => (arr[0], arr[1]) };

            Solution(x);
        }

        private void Solution(int x)
        {
            int[] ex = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            foreach (int i in ex)
            {
                if (i < x) Console.Write($"{i} ");
            }
        }
    }

    #region ShortCoding
    public class Q_10871_ShortCoding
    {
        public void ShortCoding()
        {
            var i = int.Parse(Console.ReadLine().Split()[1]); 
            Console.Write(string.Join(" ", Console.ReadLine().Split().Where(x => int.Parse(x) < i)));
        }
    }
    #endregion

    #region CPP
    public class Q_10871_CPP
    {
        /*
         #include <stdio.h>
        #include <string.h>
        #include <stdlib.h>
        int main(void) {
	        int n, x, num;
	        char * arr = NULL;
	        char inp[100000];
	        char sp[] = " ";
	        scanf("%d %d", &n, &x);
	        getchar();
	        gets(inp);
	        arr = strtok(inp, sp);
	        while (arr != NULL) {
		        num = atoi(arr);
		        if (num < x) {
			        printf("%s ", arr);
		        }
		        arr = strtok(NULL, sp);
	        }
	        return 0;
        }
         */
    }
    #endregion
}