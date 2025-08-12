namespace SortingAndSearchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 64, 25, 12, 22, 11 };
            int[] sortedData = { 11, 12, 22, 25, 64 };

            Console.WriteLine("=== Searching Algorithms ===");

            Console.WriteLine("Linear Search:");
            int indexLinear = LinearSearch(data, 22);
            Console.WriteLine(indexLinear != -1
                ? $"Found 22 at index {indexLinear}"
                : "Not found");

            Console.WriteLine("\nBinary Search:");
            int indexBinary = BinarySearch(sortedData, 22);
            Console.WriteLine(indexBinary != -1
                ? $"Found 22 at index {indexBinary}"
                : "Not found");
        }
        // Linear Search: Duyệt từ đầu đến cuối, so sánh từng phần tử
        // Binary Search: Chia đôi mảng đã được sắp xếp và loại bỏ nửa không chứa giá trị cần tìm 

        // Linear Search
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Check index {i}, value {arr[i]}");
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // Binary Search
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                Console.WriteLine($"Check mid {mid}, value {arr[mid]}");

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}