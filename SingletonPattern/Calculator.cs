using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Calculator
    {
        public int Divide(int a,int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Logger.Instance.Log(e.Message);
            }

            return 0;
        }
    }
}
