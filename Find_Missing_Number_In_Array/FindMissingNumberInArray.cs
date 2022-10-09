namespace Alghoritms.Find_Missing_Number_In_Array
{
    public static class FindMissingNumberInArray
    {
        //You are given an array of positive numbers from 1 to n,
        public static int FindMissingNumberInArrayFunction(int[] array)
        {
            // Accoreding to series rule, calculating sum of total numbers upto array last number
            //sum of first n natutal numbers=n*(n+1)/2

            int totalSum = (array.Length + 1) * (array.Length + 2) / 2;

            // Missing number is calculating.
            foreach (int item in array)
            {
                totalSum -= item;
            }


            int missingNumber = totalSum;

            return missingNumber;
        }
    }
}
