public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /* PLAN
            1. Create a new array of doubles with the size of 'length'.
            2. Use a for loop to iterate from 0 to length - 1.
            3. In each iteration, calculate the multiple by multiplying 'number' with (i + 1) where i is the loop index.
            4. Assign the calculated multiple to the corresponding index in the array.
        */

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /*
            PLAN
            1. Determine the length of the list 'data'.
            2. Create a new list to hold the rotated values.
            3. Use a for loop to iterate through the original list.
            4. For each index, calculate the new index by adding 'amount' and using modulo with the length of the list.
            5. Assign the value from the original list to the new index in the new list.
            6. Clear the original list and add all elements from the new list back to it.
        */

        int length = data.Count;
        List<int> rotated = new List<int>(new int[length]);
        for (int i = 0; i < length; i++)
        {
            int newIndex = (i + amount) % length;
            rotated[newIndex] = data[i];
        }
        data.Clear();
        data.AddRange(rotated);
    }
}
