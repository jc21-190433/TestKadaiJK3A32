using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

  
        public class JetCoaster
        {
            public static int ride
                (int k, int[] g, int r)
            {
                int[] cap = g;
                int[] newcap = new int[g.Length];
                int boa = 0;
                int ret = 0;

                for (int a = 0; a < r; a++)
                {
                    int count = 0;
                    for (int b = 0; b < cap.Length; b++)
                    {
                        int boac = boa;
                        boa += cap[b];
                        count++;
                        if (boa > k)
                        {
                            boa = boac;
                            count--;
                            break;
                        }
                    }
                    for (int c = 0; c < count; c++)
                    {
                        int bff = cap[0];
                        Array.Copy(cap, 1, newcap, 0, cap.Length - 1);
                        newcap[newcap.Length - 1] = bff;

                        cap = newcap;
                    }
                    ret += boa;
                    boa = 0;
                }

                return ret;
            }
        }
    }
