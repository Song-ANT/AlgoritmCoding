﻿namespace AlgorithmCoding
{
    #region 문제
    /*
     고양이 다국어
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	587460	200967	171236	35.322%
    문제
    아래 예제와 같이 고양이를 출력하시오.

    입력
    없음.

    출력
    고양이를 출력한다.

    예제 입력 1 
    예제 출력 1 
    \    /\
     )  ( ')
    (  /  )
     \(__)|
     */
    #endregion

    public class Q_10171 : KataBase
    {
        public override void Example()
        {
            Solution();
        }

        private void Solution()
        {
            Console.WriteLine("\\    /\\");
            Console.WriteLine(" )  ( ')");
            Console.WriteLine("(  /  )");
            Console.WriteLine(" \\(__)|");
        }
    }
}