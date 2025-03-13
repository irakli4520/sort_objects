namespace G12_20250227
{
    public interface IComparable
    {
        // Returns 1 if this object is greater than the specified object.
        // Returns -1 if this object is less than the specified object.
        // Returns 0 if this object is equal to the specified object.
        int CompareTo(object obj, int compareBy);
    }

    static class ArrayHelper
    {
        public static void Sort(object[] array, int compareBy = 0)
        {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] is not IComparable)
                        {
                            throw new ArgumentException("Object does not implement Comparable class.");
                        }
                        if ((array[i] as IComparable)!.CompareTo(array[j], compareBy) > 0)
                        {
                            object temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
        }
    }
}