using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL6_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            Department mainDepartment = new Department();
            Faculty faculty = new Faculty();
            DeanOffice deanOffice = new DeanOffice(ref dataBase);
            faculty.RegisterObserver(deanOffice);
            deanOffice.RegisterObserver(mainDepartment);

            faculty.AddAcademic(new Academic()); // 0
            faculty.AddAcademic(new Academic()); // 1
            faculty.AddAcademic(new Academic()); // 2
            faculty.AddAcademic(new Academic()); // 3

            bool continu = true;
            while(continu)
            {
                Console.Clear();
                foreach (var item in faculty.academics)
                {
                    Console.Write(item.code.ToString() + " ");
                }
                Console.WriteLine();
                faculty.CreateRecords(dataBase);
                Console.WriteLine("If you want to stop program, enter '0', to add, enter '1', to remove -- '2' or anything else to continue");
                int ans = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ans)
                {
                    case 0:
                        {
                            continu = false;
                            break;
                        }
                    case 1:
                        {
                            faculty.AddAcademic(new Academic());
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the name: ");
                            int name = int.Parse(Console.ReadLine());
                            faculty.FreeAcademic(name);
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
            }
        }
    }
}
