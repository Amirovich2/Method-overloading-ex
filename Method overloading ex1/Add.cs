namespace Method_overloading_ex1
{
    internal class Add
    {
        public static int Adds (int x, int y)
        {
            return x + y;
        }

        public static decimal Adds (decimal x, decimal y)
        {
            var sum = x + y;
            return sum;
        }

        public static string Adds(int x, int y, bool z)
        {
            var sum = x + y;

            if (z == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (z == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (z == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }


            //while (z == true)
            //{
            //    if (x + y == 1)
            //    {
            //        return $"{sum} dollar";
            //    }
            //    else
            //    {
            //        return $"{sum} dollar";
            //    }
            //    break;
            //}

        }


    }
}

