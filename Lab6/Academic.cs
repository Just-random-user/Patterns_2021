using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL6_Observer
{
    class Academic
    {
        public readonly int code;
        public string name;
        private static int counter = 0;
        private static Random Random = new Random();
        public Academic()
        {
            code = counter;
            counter++;
            name = code.ToString();
        }
        public PerformanceRecord CreateRecord(DataBase db)
        {
            int probability = Random.Next(0, 100);
            //Console.WriteLine(probability);
            PerformanceRecord record = null;
            if (probability > 40)
            {
                record = new PerformanceRecord(code);
                db.AddRecord(record);
            }
            return record;
        }
    }
}
