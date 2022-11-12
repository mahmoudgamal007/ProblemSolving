namespace ContainerWithMostWater
{
    public class Solution
    {
        public static int MaxArea(int[] height)
        {
            int head = 0;
            int tail=height.Length - 1;
            int maxwater = 0;
           while(head!=tail)
            {
                int max = 0;
                if (height[head]<height[tail])
                {
                    max=height[head]*(tail-head);
                    head++;
                }
                else if(height[head]>height[tail])
                {
                    max=height[tail]*(tail-head);
                    tail--;
                }
                else
                {
                    max=height[head]*(tail-head);
                    tail--;
                }
                if (max>maxwater)
                    maxwater=max;
            }
            return maxwater;
        }
    }
    public class Program
    {
        static void Main()
        {
            int[] arr = { 5,1,1,1 };
            Console.WriteLine(Solution.MaxArea(arr));
            
        }
    }
}