using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   
        public class kuriage
        {
            public static int kuriage10(int i)
            {
                int j;
                int k;
                j = i;

                if (i < 0)
                {
                    j = i * -1;
                }

                if (j % 10 != 0)
                {
                    k = j % 10;
                    j = j + 10 - k;
                    if (i < 0)
                    {
                        j = j * -1;
                    }
                    i = j;

                }
                return i;
            }
        }
    }