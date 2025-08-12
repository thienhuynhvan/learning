
namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("=== Bubble Sort ===");
            RunSort(array, BubbleSort);

            Console.WriteLine("\n=== Insertion Sort ===");
            RunSort(array, InsertionSort);

            Console.WriteLine("\n=== Selection Sort ===");
            RunSort(array, SelectionSort);

            Console.WriteLine("\n=== Merge Sort ===");
            RunSort(array, MergeSortWrapper);

            Console.WriteLine("\n=== Quick Sort ===");
            RunSort(array, QuickSortWrapper);
        }

        static void RunSort(int[] original, Action<int[]> sortMethod)
        {
            int[] arr = (int[])original.Clone();
            sortMethod(arr);
            Console.WriteLine("Kết quả cuối: " + string.Join(", ", arr));
        }

        // Bubble Sort
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        PrintStep(arr);
                    }
                }
            }
        }

        // Insertion Sort
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                    PrintStep(arr);
                }
                arr[j + 1] = key;
                PrintStep(arr);
            }
        }

        // Selection Sort
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                if (minIndex != i)
                {
                    Swap(arr, i, minIndex);
                    PrintStep(arr);
                }
            }
        }

        // Merge Sort Wrapper
        static void MergeSortWrapper(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
                PrintStep(arr);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] leftArr = new int[mid - left + 1];
            int[] rightArr = new int[right - mid];

            Array.Copy(arr, left, leftArr, 0, leftArr.Length);
            Array.Copy(arr, mid + 1, rightArr, 0, rightArr.Length);

            int i = 0, j = 0, k = left;
            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] <= rightArr[j])
                    arr[k++] = leftArr[i++];
                else
                    arr[k++] = rightArr[j++];
            }

            while (i < leftArr.Length) arr[k++] = leftArr[i++];
            while (j < rightArr.Length) arr[k++] = rightArr[j++];
        }

        // Quick Sort Wrapper
        static void QuickSortWrapper(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                PrintStep(arr);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        // Utility
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void PrintStep(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
