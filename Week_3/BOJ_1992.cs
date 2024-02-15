namespace Week_3
{
    //BOJ_1992번 쿼드트리
    internal class BOJ_1992
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] num = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < N; j++)
                {

                    num[i, j] = int.Parse(input[j].ToString());
                }
            }
            QuadTree(num, 0, 0, N);


        }
        static void QuadTree(int[,] num, int start1, int start2, int size)
        {
            if (QuadTreeCheck(num, start1, start2, size))
            {
               Console.Write( num[start1, start2]);
                return;
            }
            int mid = size / 2;
            Console.Write("(");
            QuadTree(num, start1, start2, mid); // 우측상단
            QuadTree(num, start1, start2 + mid, mid);// 좌측 상단
            QuadTree(num, start1 + mid, start2, mid);  //우측 하단
            QuadTree(num, start1 + mid, start2 + mid, mid); //좌측 하단
            Console.Write(")");

        }
        static bool QuadTreeCheck(int[,] num, int start1, int start2, int size)
        {
            int check = num[start1, start2];
            for (int i = start1; i < start1 + size; i++)
            {
                for (int j = start2; j < start2 + size; j++)
                {
                    if (num[i, j] != check)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
