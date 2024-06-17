namespace AlgorithmCoding
{
    #region 문제
    //시험 성적
    //시간 제한   메모리 제한  제출 정답  맞힌 사람   정답 비율
    //1 초	128 MB	415701	226668	190388	54.783%
    //문제
    //시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오.

    //입력
    //첫째 줄에 시험 점수가 주어진다.시험 점수는 0보다 크거나 같고, 100보다 작거나 같은 정수이다.

    //출력
    //시험 성적을 출력한다.

    //예제 입력 1 
    //100
    //예제 출력 1 
    //A
    #endregion

    public class Q_9489 : KataBase
    {
        public override void Example()
        {
            int ex = int.Parse(Console.ReadLine());

            Solution(ex);
        }

        private void Solution(int ex)
        {
            switch (ex / 10) 
            {
                case 10:
                case 9: Console.WriteLine("A"); break;
                case 8: Console.WriteLine("B"); break;
                case 7: Console.WriteLine("C"); break;
                case 6: Console.WriteLine("D"); break;
                default: Console.WriteLine("F"); break;
            }
        }
    }

    #region ShortCoding
    public class Q_9489_ShortCoding
    {
        public void ShortCoding()
        {
            int score = int.Parse(Console.ReadLine()) / 10;
            Console.WriteLine("FFFFFFDCBAA"[score]);
        }
    }
    #endregion

    #region CPP
    public class Q_9489_CPP
    {
        //# include <cstdio>
        //main() { int a; scanf("%d", &a); printf("%c", "FFFFFFDCBAA"[a / 10]); }
    }
    #endregion
}