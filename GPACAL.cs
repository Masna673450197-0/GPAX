using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpax
{
    internal class GPACAL
    {
        private double gpa_sum;
        private int n;

        public void setGPA(double gpa)
        {
            this.gpa_sum = gpa;
            this.n++;
        }
        public double getGPAX()
        {
            return this.gpa_sum / this.n;
        }

    }
}
    

