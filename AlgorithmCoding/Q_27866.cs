﻿namespace AlgorithmCoding
{

    #region 문제
    /*
     문자와 문자열
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    1 초	1024 MB	73854	49351	45206	67.978%
    문제
    단어 
    $S$와 정수 
    $i$가 주어졌을 때, 
    $S$의 
    $i$번째 글자를 출력하는 프로그램을 작성하시오.

    입력
    첫째 줄에 영어 소문자와 대문자로만 이루어진 단어 
    $S$가 주어진다. 단어의 길이는 최대 
    $1\,000$이다.

    둘째 줄에 정수 
    $i$가 주어진다. (
    $1 \le i \le \left|S\right|$)

    출력
 
    $S$의 
    $i$번째 글자를 출력한다.

    예제 입력 1 
    Sprout
    3
    예제 출력 1 
    r
    예제 입력 2 
    shiftpsh
    6
    예제 출력 2 
    p
    예제 입력 3 
    Baekjoon
    4
    예제 출력 3 
    k
    노트
    문자열 
    $S$에 대해 
    $\left|S\right|$는 
    $S$의 길이를 의미한다.
     */
    #endregion

    public class Q_27866 : KataBase
    {
        public override void Example()
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Solution(word, n);
        }

        private void Solution(string word, int n) => Console.WriteLine(word[n-1]);
    }
}