using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL6_Observer
{
    class DataBase
    {
        public List<List<PerformanceRecord>> Records;
        public DataBase()
        {
            Records = new List<List<PerformanceRecord>>();
        }
        public void AddEntry()
        {
            Records.Add(new List<PerformanceRecord>());
        }
        public void AddRecord(PerformanceRecord record)
        {
            Records.Last().Add(record);
        }
    }
}
