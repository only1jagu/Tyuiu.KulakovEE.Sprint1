using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KulakovEE.Sprint1.Task2.V3.Lib
{
    public class DataService : ISprint1Task2V3

    {
        public int ConvertHourToMin(int value)
        {
            return 60 * value;
        }
       
        

    }
}
