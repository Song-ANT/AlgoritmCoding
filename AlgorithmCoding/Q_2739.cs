namespace AlgorithmCoding
{
    #region 문제
    /*
     구구단
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	128 MB	436833	219004	182374	50.660%
    문제
    N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오. 출력 형식에 맞춰서 출력하면 된다.

    입력
    첫째 줄에 N이 주어진다. N은 1보다 크거나 같고, 9보다 작거나 같다.

    출력
    출력형식과 같게 N*1부터 N*9까지 출력한다.

    예제 입력 1 
    2
    예제 출력 1 
    2 * 1 = 2
    2 * 2 = 4
    2 * 3 = 6
    2 * 4 = 8
    2 * 5 = 10
    2 * 6 = 12
    2 * 7 = 14
    2 * 8 = 16
    2 * 9 = 18
     */

    #endregion

    public class Q_2739 : KataBase
    {
        public override void Example()
        {
            int ex = int.Parse(Console.ReadLine());

            Solution(ex);
        }

        public void Solution(int ex)
        {
            for(int i = 1; i <= 9; i++) 
            {
                Console.WriteLine($"{ex} * {i} = {ex * i}");
            }
        }
    }

    #region ShotCoding
    public class Q_2739_ShortCoding
    {
        public void ShortCoding()
        {
            int N = Console.Read() - 48;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{N} * {i} = {N * i}");
            }
        }
    }
    #endregion

    #region CPP
    public class Q_2739_CPP
    {
        public void CPP()
        {
            /*
             #include <iostream>

            using namespace std;

            void Solution(int ex) {
                for (int i = 1; i <= 9; i++) {
                    cout << ex << " * " << i << " = " << ex * i << endl;
                }
            }

            int main() {
                int ex;
                cin >> ex;

                Solution(ex);

                return 0;
            }
             */
        }
    }
    #endregion
}


