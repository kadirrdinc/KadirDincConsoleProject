using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfMultiple
{
    public class ExampleSOM
    {
        public string Example(int totalNumber)
        {
            try
            {
                int threeDivision = 0;
                int fiveDivision = 0;

                for (int i = 1; i <= totalNumber; i++)
                {
                    if (i % 3 == 0)
                    {
                        threeDivision++;
                    }
                    else if (i % 5 == 0)
                    {
                        fiveDivision++;
                    }
                }
                var result = string.Format("The number {0} was divided by 3 {1} times and the number {0} was divided by 5 {2} times.", totalNumber, threeDivision, fiveDivision);

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
