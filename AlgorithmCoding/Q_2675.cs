namespace AlgorithmCoding
{
    #region 문제
    /*
     문자열 반복 다국어
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	128 MB	234239	117766	99853	50.055%
    문제
    문자열 S를 입력받은 후에, 각 문자를 R번 반복해 새 문자열 P를 만든 후 출력하는 프로그램을 작성하시오. 즉, 첫 번째 문자를 R번 반복하고, 두 번째 문자를 R번 반복하는 식으로 P를 만들면 된다. S에는 QR Code "alphanumeric" 문자만 들어있다.

    QR Code "alphanumeric" 문자는 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ\$%*+-./: 이다.

    입력
    첫째 줄에 테스트 케이스의 개수 T(1 ≤ T ≤ 1,000)가 주어진다. 각 테스트 케이스는 반복 횟수 R(1 ≤ R ≤ 8), 문자열 S가 공백으로 구분되어 주어진다. S의 길이는 적어도 1이며, 20글자를 넘지 않는다. 

    출력
    각 테스트 케이스에 대해 P를 출력한다.

    예제 입력 1 
    2
    3 ABC
    5 /HTP
    예제 출력 1 
    AAABBBCCC
    /////HHHHHTTTTTPPPPP
     */
    #endregion


    public struct Example
    {
        public int repet;
        public string sample;

        public Example(int repet, string sample)
        {
            this.repet = repet;
            this.sample = sample;
        }
    }

    public class Q_2675 : KataBase
    {
        public override void Example()
        {
            int test = int.Parse(Console.ReadLine());
            Example[] ex = Enumerable.Range(1, test)
                .Select(i => { 
                    var input = Console.ReadLine().Split(); 
                    return new Example(int.Parse(input[0]), input[1]); }
                ).ToArray();

            Solution(ref ex);
        }

        private void Solution(ref Example[] ex)
        {
            foreach (var example in ex)
            {
                string res = string.Concat(example.sample.Select(c => new string(c, example.repet)));
                Console.WriteLine(res);
            }
        }
    }
}
