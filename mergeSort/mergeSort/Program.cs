namespace mergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 7, 18, 2 };
            MergeSort(arr);

            for(int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        private static void MergeSort(int[] arr)
        {
            int length = arr.Length;
            if(length < 2)
                return;
            int middle = length / 2;
            int[] left_array = new int[middle];
            int[] right_array = new int[length - middle];

            int i = 0, j = 0;
            for(; i < length; i++)
            {
                if(i < middle)
                    left_array[i] = arr[i];
                else
                {
                    right_array[j] = arr[i];
                    j++;
                }
            }

            MergeSort(left_array);
            MergeSort(right_array);
            Merge(left_array, right_array, arr);
        }


        private static void Merge(int[] leftArray, int[] rightArray, int[] arr)
        {
            int l = 0;
            int r = 0;
            int i = 0;

            while(l < leftArray.Length && r < rightArray.Length)
            {
                if(leftArray[l] < rightArray[r])
                {
                    arr[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    arr[i] = rightArray[r];
                    i++;
                    r++;
                }
            }

            while(l < leftArray.Length)
            {
                arr[i] = leftArray[l];
                i++;
                l++;
            }

            while(r < rightArray.Length)
            {
                arr[i] = rightArray[r];
                i++;
                r++;
            }
        }
    }
}
