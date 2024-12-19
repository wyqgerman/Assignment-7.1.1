namespace Assignment_7._1._1
{
    internal class Program
    {
        static void SelectionSort(int[] scores)
        {
            int n = scores.Length;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] examScores = { 60, 70, 80, 65, 95, 90, 88 };
            SelectionSort(examScores);
            Console.WriteLine("Sorted Scores: " + string.Join(", ", examScores));
        }
    }
}
