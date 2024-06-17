namespace AlgorithmCoding
{
    #region 문제
    /*
     최소, 최대
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	389946	175544	132328	43.927%
    문제
    N개의 정수가 주어진다. 이때, 최솟값과 최댓값을 구하는 프로그램을 작성하시오.

    입력
    첫째 줄에 정수의 개수 N (1 ≤ N ≤ 1,000,000)이 주어진다. 둘째 줄에는 N개의 정수를 공백으로 구분해서 주어진다. 모든 정수는 -1,000,000보다 크거나 같고, 1,000,000보다 작거나 같은 정수이다.

    출력
    첫째 줄에 주어진 정수 N개의 최솟값과 최댓값을 공백으로 구분해 출력한다.

    예제 입력 1 
    5
    20 10 35 30 7
    예제 출력 1 
    7 35
     */
    #endregion


    public class Q_10818 : KataBase
    {
        public override void Example()
        {
            int n = int.Parse(Console.ReadLine());
            int[] ex = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Solution(n, ref ex);
        }

        private void Solution(int n, ref int[] ex)
        {
            int max = -1;
            int min = -1;

            for(int i = 0; i < n; i++)
            {
                if (i == 0 || ex[i] > max) max = ex[i];
                if (i == 0 || ex[i] < min) min = ex[i];
            }

            Console.WriteLine($"{min} {max}");
        } 
    }

    #region ShortCoding
    public class Q_10818_ShortCoding
    {
        public void ShortCoding()
        {
            Console.ReadLine();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.Write($"{n.Min()} {n.Max()}");
        }
    }
    #endregion

    #region CPP
    public class Q_10818_CPP
    {
        /*
         #include <cstdio>
        #define min(a, b) a < b ? a : b
        #define max(a, b) a > b ? a : b
        const int bsz = 1 << 21;
        char buff[bsz];
        int lidx = 0, ridx = 0;

        inline char read() {
            if(lidx == ridx) {
                ridx = fread(buff, 1, bsz, stdin);
                lidx = 0;
            }
    
            return buff[lidx++];
        }

        inline int readInt() {
            int ret = 0, tmp = read();
            bool sign = true;
            if(tmp == '-') { sign = false; tmp = read(); }
            while(tmp >= 48) { ret = ret * 10 + tmp - 48; tmp = read(); }
            return sign ? ret : -ret;
        }

        int main() {
            int minn = 1000001, maxx = -1000001;
            int n = readInt();
            for(int i = 0; i < n; i++) {
                int val = readInt();
                minn = min(minn, val);
                maxx = max(maxx, val);
            }
    
            printf("%d %d", minn, maxx);
            return 0;
        }
         */
    }
    #endregion
}