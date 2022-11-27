## Find words less than 3 letters in array and put them in a new array. Then write the result by raws.


1. Create string array name arr[] with several words different length. 

**string[] arr = {"dslfkjsl", "req", "dejhf", "jdj", "dfsad"};**

2. In cycle search elements of array that <= 3 letters.
   If condition is TRUE, assign element of array to another array names arr_result[].

**for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                arr_result[i] = arr[i];**

3. Results print in console

**Console.WriteLine(arr_result[i]);**
