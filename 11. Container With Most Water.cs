internal class Program
{
    private static void Main(string[] args)
    {
        var solution = new Solution();

        var testArray = new[] {1,2,4,3};

        var outputResult = solution.MaxArea(testArray);
        Console.WriteLine(outputResult);
    }
}
/*****************/
///Данное решение верно вычисляет  максимальную площадь контейнера, но не проходит по времени в LeetCode. 
///Есть альтернативное решение, но оно одинаковое во всех обзорах и способах решения. 
///Оно будет после моего решения, которое я не смог оптимизировать в скорости выполнения
public class Solution
{
    public int MaxArea(int[] height)
    {
        if (height.Length > 100000)
        {
            return 0;
        }

        var maxArea = 0;
        for (var i = 0; i < height.Length - 1; i++)
        {
            for (var j = i + 1; j < height.Length; j++)
            {
                var min = Math.Min(height[i], height[j]);
                var result = min * (j - i);
                if (result > maxArea)
                {
                    maxArea = result;
                }
            }
        }
        return maxArea;
    }
}
/******** РЕШЕНИЕ КОТОРОЕ ПРОХОДИТ НА LeetCode ***********/
public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while(left < right)
        {
            int currentHeight = Math.Min(height[left],height[right]);
            int currentArea = currentHeight * (right - left);

            maxArea = Math.Max(maxArea,currentArea);
            if(height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
