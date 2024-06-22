﻿namespace AlgorithmCoding
{
    #region 문제
    /*
     새싹 언어 제한
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	1024 MB	133710	68924	63855	52.826%
    문제
    아래 예제와 같이 새싹을 출력하시오.

    입력
    입력은 없다.

    출력
    새싹을 출력한다.

    예제 입력 1 
    예제 출력 1 
             ,r'"7
    r`-_   ,'  ,/
     \. ". L_r'
       `~\/
          |
          |
     */
    #endregion

    public class Q_25083 : KataBase
    {
        public override void Example()
        {
            Solution();   
        }

        private void Solution()
        {
            Console.WriteLine("         ,r'\"7");
            Console.WriteLine("r`-_   ,'  ,/");
            Console.WriteLine(" \\. \". L_r'");
            Console.WriteLine("   `~\\/");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
        }
    }
}