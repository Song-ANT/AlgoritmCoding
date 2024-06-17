﻿namespace AlgorithmCoding
{
    #region 문제
    /*
     개 다국어
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	256 MB	456572	190771	167596	42.611%
    문제
    아래 예제와 같이 개를 출력하시오.

    입력
    없음.

    출력
    개를 출력한다.

    예제 입력 1 
    예제 출력 1 
    |\_/|
    |q p|   /}
    ( 0 )"""\
    |"^"`    |
    ||_/=\\__|
     */
    #endregion
    public class Q_10172 : KataBase
    {
        public override void Example()
        {
            Solution();
        }

        private void Solution()
        {
            Console.Write(
                "|\\_/|\r\n" +
                "|q p|   /}\r\n" +
                "( 0 )\"\"\"\\\r\n" +
                "|\"^\"`    |\r\n" +
                "||_/=\\\\__|"
                );
        }
    }

}