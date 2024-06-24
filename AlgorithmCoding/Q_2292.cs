﻿using System;

namespace AlgorithmCoding
{
    #region 문제
    /*
     벌집
    시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
    2 초	128 MB	183979	83456	71055	44.850%
    문제


    위의 그림과 같이 육각형으로 이루어진 벌집이 있다. 그림에서 보는 바와 같이 중앙의 방 1부터 시작해서 이웃하는 방에 돌아가면서 1씩 증가하는 번호를 주소로 매길 수 있다. 숫자 N이 주어졌을 때, 벌집의 중앙 1에서 N번 방까지 최소 개수의 방을 지나서 갈 때 몇 개의 방을 지나가는지(시작과 끝을 포함하여)를 계산하는 프로그램을 작성하시오. 예를 들면, 13까지는 3개, 58까지는 5개를 지난다.

    입력
    첫째 줄에 N(1 ≤ N ≤ 1,000,000,000)이 주어진다.

    출력
    입력으로 주어진 방까지 최소 개수의 방을 지나서 갈 때 몇 개의 방을 지나는지 출력한다.

    예제 입력 1 
    13
    예제 출력 1 
    3
     */
    #endregion

    public class Q_2292 : KataBase
    {
        public override void Example()
        {
            int ex = int.Parse(Console.ReadLine());

            Solution(ex);
        }

        private void Solution(int ex)
        {
            // 1 -> 6 -> 12 -> 18 -> 24 -> 30
            // 1 -> 7 -> 19 -> 37 -> 61 -> 91

            if (ex == 1)
            {
                Console.WriteLine(1);
                return;
            }

            //1,2,3,4,5,6
            //1,3,6,10,15,21

            int bundle = (ex-1) / 6;
            bundle += (ex-1) % 6 == 0 ? 0 : 1;

            int index = 0;
            int plus = 1;
            while (true)
            {
                if (bundle > index) index += plus++;
                else break;
            }

            Console.WriteLine(plus);
        }

    }

    #region ShortCoding
    public class Q_2292_ShortCoding
    {
        public void ShortCoding()
        {
            int i = int.Parse(Console.ReadLine()), c = 1;
            while (i > 1) i -= 6 * c++;
            Console.Write(c);
        }
    }
    #endregion

    #region CPP
    public class Q_2292_CPP
    {
        /*
         #include <stdio.h>
        int n, i, s;
        int main() {
	        scanf("%d", &n);
	        for(i=1, s=1; s<n; i++) s+=6*i;
	        printf("%d", i);
        }
         */
    }
    #endregion
}