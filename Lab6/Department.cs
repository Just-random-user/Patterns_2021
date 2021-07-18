using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL6_Observer
{
    class Department : IObserver
    {
        public void Update(object obj)
        {
            List<int> missedAcademics = obj as List<int>;
            Console.Write("Academics with numbers: ");
            foreach (var item in missedAcademics)
                Console.Write(item.ToString() + ", ");
            Console.WriteLine("Hasn't has their reports sent");
            Console.WriteLine();
        }
    }
}
