using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            bool isA_BetweenRange = (a >= 10 && a <= 20);
            bool isB_BetweenRange = (b >= 10 && b <= 20);
            int betweenTenAndTwenty = 0;
            if (a >= 0 && b >= 0)
            { }
                if (isA_BetweenRange && isB_BetweenRange)
                {
                     
                    if (a >= b )
                    {
                        return betweenTenAndTwenty ;
                    }
                    else if (!isB_BetweenRange && isA_BetweenRange  )
                    { betweenTenAndTwenty = a; }
                    else if (isB_BetweenRange && !isA_BetweenRange )
                    {
                        betweenTenAndTwenty = b ;
                    }


                }

                return betweenTenAndTwenty ;
            }
        }
    }

