using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("text.txt");
            Corrector corrector = new Corrector();
            string fixText = corrector.Interpret(text);
            File.WriteAllText("fixedText.txt", fixText);
        }
    }
}
