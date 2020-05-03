using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texi
{
    public class Taxi
    {
        public int Cost(int mile,int minute)
        {
            if (minute!=0)
                return CostDetailWithMinute(mile, minute);
            else
                return CostDetailWithoutMinute(mile);
        }
        private int CostDetailWithMinute(int mile, int minute)
        {
            return Convert.ToInt16(CostDetailWithoutMinute(mile) + minute * 0.25);
        }
        private int CostDetailWithoutMinute(int mile)
        {
            if (mile > 2)
            {
                if (mile > 2 && mile <= 8)
                    return Convert.ToInt16(Math.Round(6 + 0.8 * (mile - 2)));
                else
                    return Convert.ToInt16(Math.Round(6 + 0.8 * (mile - 2) + (mile - 8) * 0.5));
            }
            else
                return 6;
        }
    }
}
