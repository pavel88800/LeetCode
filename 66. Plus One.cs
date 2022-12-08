public class Solution {
   public int[] PlusOne(int[] digits)
    {
        var newDigit = digits.ToList();

        if (newDigit.Count() < 1)
        {
            return new int[] { };
        }

        for (int i = newDigit.Count() - 1; i >= 0; i--)
        {
            var number = newDigit[i];

            if (number == 9)
            {
                newDigit[i] = 0;
                continue;
            }

            newDigit[i]++;
            break;
        }

        if (newDigit.All(x => x == 0))
        {
            newDigit = newDigit.Prepend(1).ToList();
        }

        return newDigit.ToArray();
    }
}
