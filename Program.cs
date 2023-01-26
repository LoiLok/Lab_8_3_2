using System;
class Program
{
    private static void Main()
    {
        string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
        List<string> list = new List<string>(array);
        string[] res = NewArray(list);
        WriteNewArray(res);
    }

    private static void WriteNewArray(string[] res)
    {
        Array.Sort(res);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
    }

    private static string[] NewArray(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                bool check = Check(list[i], list[j]);
                if (check == true)
                {
                    list.RemoveAt(j);
                    j--;
                }
            }
        }
        return list.ToArray();
    }

   private static bool Check(string first, string second)
   {
       List<char> firstSymbols = first.ToList();
       List<char> secondSymbols = second.ToList();
       int firstCount = firstSymbols.Count;
       int secondCount = secondSymbols.Count;
       int k = 0;
       if (firstCount != secondCount) return false;
       bool check = CheckIfCountsNotEqual(firstSymbols, secondSymbols, firstCount, secondCount,k);
       return check;
   }

     private static bool CheckIfCountsNotEqual(List<char> firstSymbols, List<char> secondSymbols, int firstCount, int secondCount,int k)
     {
         for (int i = 0; i < firstCount; i++)
         {
             char findSymbol = firstSymbols[i];
             if (secondSymbols.Contains(findSymbol))
             {
                 secondSymbols.Remove(findSymbol);
                 k++;
             }
         }

         if (firstCount == k && secondCount == k) return true;
         else return false;
     }
}
