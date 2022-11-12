using System;
namespace removingstones
{
    public class Solution
    {
        public static int MinStoneSum(int[] piles, int k)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int sum = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                pq.Enqueue(piles[i], -piles[i]);
                sum+=piles[i];
            }
            for(int i= 0; i < k; i++)
            {
                int x=pq.Dequeue();
                sum-=x/2;
                x-=x/2;
                pq.Enqueue(x, -x);
                
            }
            return sum;

        }
    }
        class program
        {
            public static void Main()
            {
                int[] arr = { 4, 3, 6, 7 };
                Console.WriteLine(Solution.MinStoneSum(arr, 3));
            }
        }
    }