namespace BinarySearch
{
    class SearchUsingBinarySearch
    {
        internal int BinarySearch(int[] arr, int low, int high, int key)
        {
            if (high < low)
                return -1;

            int mid = (low + high) / 2;

            if (key == arr[mid])
            {
                return mid;
            }

            if (key > arr[mid])
            {
                return BinarySearch(arr, (mid + 1), high, key);
            }

            return BinarySearch(arr, low, (mid - 1), key);
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            SearchUsingBinarySearch searchUsingBinarySearch = new SearchUsingBinarySearch();

            int i = searchUsingBinarySearch.BinarySearch(arr, 0, arr.Length - 1, 8);
        }
    }
}
