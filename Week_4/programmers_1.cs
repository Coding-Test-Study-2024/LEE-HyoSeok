using System;
using System.Collections.Generic;

public class programmers_1
{
    // 프로그래머스 기능개발 문제
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answerList = new List<int>();
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < progresses.Length; i++)
        {
            int days = (int)Math.Ceiling((float)(100 - progresses[i]) / speeds[i]);
            queue.Enqueue(days);
        }

        while (queue.Count > 0)
        {
            int count = 1;
            int a = queue.Dequeue();
            while (queue.Count > 0 && a >= queue.Peek())
            {
                queue.Dequeue();
                count++;
            }
            answerList.Add(count);
        }
        int[] answer = answerList.ToArray();
        return answer;
    }
}
