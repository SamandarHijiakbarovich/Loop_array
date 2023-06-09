namespace masala_Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int[] arrr = new int[n];

            Random rand = new Random();
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    arr[i, j] = rand.Next(0, 9);
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();

            }


            int sum = 0;
            for(int j=0;j<n;j++)
            {
                for(int i=0;i<n;i++)
                {
                    sum += arr[j, i];
                }
                arrr[j] = sum;
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.WriteLine("\n" +
                "arrayning satrlari yig'indisi");

            for(int j=0;j<n;j++)
            {
                Console.Write(arrr[j]);
            }

            Console.WriteLine("eng kattasi");
            int max = arrr[0];
            for(int i=0;i<n;i++)
            {
                if (max <= arrr[i])
                {
                    max = arrr[i];
                }
            }

            Console.Write(max);

*/

            char[] arr = new char[] { 'h', 'e', 'l', 'l', 'o' };

            Array.Reverse(arr);
            for (int i = 0;i<arr.Length;i++)
            {
                
                Console.Write($"{arr[i]},");
                

            }


        }
    }
}