namespace HomeWork_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            PrintArr(a);
            SortTwiceArr(a);
            Console.WriteLine();
            PrintArr(a);
            Console.ReadLine();
        }

        /// <summary>
        /// Сортировка двумерного массива
        /// </summary>
        /// <param name="nums">двумерный массив чисел</param>
        private static void SortTwiceArr(int[,] nums)
        {
            var res = new List<int>();
            int count = 0;

            foreach (var x in nums)
            {
                res.Add(x);
            }
            res.Sort();

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = res[count++];
                }
            }

        }

        /// <summary>
        /// Вывод массива в консоль
        /// </summary>
        /// <param name="nums">входящий массив</param>
        private static void PrintArr(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
