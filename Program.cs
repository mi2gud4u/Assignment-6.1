using System.Runtime.CompilerServices;

namespace Assignment_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Linked List -----");
            LinkdList myHouse = new LinkdList();
            myHouse.Add(2456, "Street Name", "City Name", HouseType.Ranch);
            myHouse.Add(1234, "Road Name", "Another City", HouseType.Victorian);
            myHouse.Add(4567, "Lane Name", "My City", HouseType.Colonial);
            myHouse.Display();
            Console.WriteLine("\nSearch Records for address name: Road Name");
            myHouse.Search("Road Name");

            Console.WriteLine("\n----- Move Zeroes -----");
            int[] nums = [0, 1, 0, 3, 12];
            Console.Write($"Original array: [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(i < nums.Length - 1 ? $"{nums[i]}, " : $"{nums[i]}]\n");
            }
            MoveZero(nums);
            
            Console.Write("Altered array: [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(i < nums.Length -1 ? $"{nums[i]}, " : $"{nums[i]}]\n");
            }

        }

        public static int[] MoveZero(int[] nums)
        {
            for (int i = 0, j = 1; j < nums.Length;)
            {
                if (nums[i] > 0)
                    i++;

                if (nums[i] == 0)
                {
                    if (nums[j] > 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                    }
                    j++;
                }    
            }

            return nums;
        }

    }
}
