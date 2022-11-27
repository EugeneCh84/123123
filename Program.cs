
void Zadacha ()
{
string[] arr = {"dslfkjsl", "req", "dejhf", "jdj", "dfsad"};
string[] arr_result = new string[arr.Length];
     for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
                {
                    arr_result[i] = arr[i];
                    Console.WriteLine(arr_result[i]);
                }
        }              
}
Zadacha();