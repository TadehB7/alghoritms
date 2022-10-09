namespace Alghoritms.Determine_if_the_sum_of_two_integers_is_equal_to_the_given_value
{
    public static class SumOfTwoIntegersIsEqualToTheGivenValue
    {
        public static bool SumOfTwoIntegersIsEqualToTheGivenValueFunction(int[] array, int value)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (var item in array)
            {
                if (set.Contains(value - item))
                {
                    return true;
                }
                set.Add(item);
            }

            return false;
        }
    }
}
