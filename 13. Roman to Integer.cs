public class Solution
{
    public int RomanToInt(string s)
    {
        var arr = s.ToCharArray();
        var currentValue = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (GetIntFromRomanNatural(arr[i]) == -1)
            {
                throw new Exception("Incorrect character");
            }

            int arrValue = i + 1 < arr.Length ? i + 1 : arr.Length - 1;
            int a = GetIntFromRomanNatural(arr[i]);
            int b = GetInt(arr[i], arr[arrValue]);

            if (a > b)
            {
                currentValue += a;
            }
            else
            {
                currentValue += b;
                i += 1;
            }
        }


        return currentValue;
    }

    private int GetIntFromRomanNatural(char romanChar) => romanChar switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => -1
    };


    private int GetInt(char firstChar, char nextChar) =>
         (firstChar, nextChar) switch
         {
             ('I', 'V') => 4,
             ('I', 'X') => 9,
             ('X', 'L') => 40,
             ('X', 'C') => 90,
             ('C', 'D') => 400,
             ('C', 'M') => 900,
             _ => -1
         };
}
