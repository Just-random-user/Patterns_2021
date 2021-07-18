using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL6_Observer
{
    class PerformanceRecord
    {
        public int AcademicCode;
        public string Data;
        public PerformanceRecord(int academicCode)
        {
            AcademicCode = academicCode;
            Data = "";
        }
    }
}
