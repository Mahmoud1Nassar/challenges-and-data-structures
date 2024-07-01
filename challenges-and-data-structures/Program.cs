using challenges_and_data_structures.Challenges.Find_Duplicates;

namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 1, 2, 3 , 4 , 6 , 6};
           int [] arrn = FindDublicates.FindDublicatess(arr);
            foreach (var item in arrn)
            {
                Console.WriteLine(item);
            }
        }
    }
}
