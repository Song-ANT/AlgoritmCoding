
namespace AlgorithmCoding
{
    public class Q_1330 : KataBase
    {
        /*
        두 수 비교하기
        시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
        1 초	512 MB	465368	225161	184635	49.640%
        
        문제
        두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.

        입력
        첫째 줄에 A와 B가 주어진다. A와 B는 공백 한 칸으로 구분되어져 있다.

        출력
        첫째 줄에 다음 세 가지 중 하나를 출력한다.

        A가 B보다 큰 경우에는 '>'를 출력한다.
        A가 B보다 작은 경우에는 '<'를 출력한다.
        A와 B가 같은 경우에는 '=='를 출력한다.
        제한
        -10,000 ≤ A, B ≤ 10,000
        
        예제 입력 1 
        1 2
        예제 출력 1 
        <
        
        예제 입력 2 
        10 2
        예제 출력 2 
        >
        
        예제 입력 3 
        5 5
        예제 출력 3 
        ==
        
        */


        public override void Example()
        {
            //int x = 1;
            //int y = 2;

            string input = Console.ReadLine();
            string[] ex = input.Split(" ");
            int x = int.Parse(ex[0]);
            int y = int.Parse(ex[1]);

            var result = solution(x, y);
            Console.WriteLine($"\n예 : {x}, {y}");
            Console.WriteLine($"결괏값 : {result}");
        }

        private string solution(int x, int y)
        {
            if (x > y) return ">";
            else if (x < y) return "<";
            else return "==";
        }
    }
}
