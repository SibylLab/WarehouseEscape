using System.Collections.Generic;

namespace WarehouseGameplay.Helpers
{
    public  class MergeSortHelper
    {
        public static int numberOfCompare = 0;

        public MergeSortHelper()
        {
           
        }
        public static int NumberOfCompereInUnsortedData()
        {
            return numberOfCompare;
        }
        public List<int> MergeSort(List<int> m)
        {
            List<int> result = new List<int>();
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            if (m.Count <= 1)
                return m;

            int middle = m.Count / 2;
            for (int i = 0; i < middle; i++)
                left.Add(m[i]);
            for (int i = middle; i < m.Count; i++)
                right.Add(m[i]);

            left = MergeSort(left);
            right = MergeSort(right);

            if (left[left.Count - 1] <= right[0])
                return Append(left, right);

            result = Merge(left, right);
            return result;

        }
        public  List<int> Append(List<int> a, List<int> b)
        {
            List<int> result = new List<int>(a);

            foreach (int x in b)
                result.Add(x);
            return result;
        }
        public  List<int> Merge(List<int> a, List<int> b)
        {
            List<int> s = new List<int>();
            while (a.Count > 0 && b.Count > 0)
            {
                if (a[0] < b[0])
                {

                    s.Add(a[0]);
                    a.RemoveAt(0);
                    numberOfCompare++;
                }
                else
                {

                    s.Add(b[0]);
                    b.RemoveAt(0);
                    numberOfCompare++;
                }
            }
            while (a.Count > 0)
            {
                s.Add(a[0]);
                a.RemoveAt(0);
                numberOfCompare++;
            }

            while (b.Count > 0)
            {
                s.Add(b[0]);
                b.RemoveAt(0);
                numberOfCompare++;
            }
            return s;
        }
    }
}
