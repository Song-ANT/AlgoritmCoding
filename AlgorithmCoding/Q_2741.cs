using System.Text;

namespace AlgorithmCoding
{

    #region 문제
    /*
     N 찍기
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	128 MB	275505	154239	131401	57.182%
    문제
    자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.

    입력
    첫째 줄에 100,000보다 작거나 같은 자연수 N이 주어진다.

    출력
    첫째 줄부터 N번째 줄 까지 차례대로 출력한다.

    예제 입력 1 
    5
    예제 출력 1 
    1
    2
    3
    4
    5
     */
    #endregion

    public class Q_2741 : KataBase
    {
        public override void Example()
        {
            int ex = int.Parse(Console.ReadLine());

            Solution(ex);
        }

        public void Solution(int ex)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= ex; i++)
            {
                sb.AppendLine(i.ToString());
            }

            Console.Write(sb.ToString());
        }
    }

    #region ShortCoding
    public class Q_2741_ShortCoding
    {
        public void ShortCoding()
        {
            Console.Write(string.Join("\n", Enumerable.Range(1, int.Parse(Console.ReadLine()))));
        }
    }
    #endregion

    #region CPP
    public class Q_2741_CPP
    {
        /*
        #include <iostream>
        #include <sstream>

        void Solution(int ex) {
            std::ostringstream oss;

            for (int i = 1; i <= ex; i++) {
                oss << i << "\n";
            }

            std::cout << oss.str();
        }

        int main() {
            int ex;
            std::cin >> ex;

            Solution(ex);

            return 0;
        }
         */
    }
    #endregion

}