using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL6_Observer
{
    class DeanOffice : IObservable, IObserver
    {
        DataBase Base;
        List<IObserver> observers;
        List<int> missedAcademics;
        public DeanOffice(ref DataBase dataBase)
        {
            observers = new List<IObserver>();
            missedAcademics = new List<int>();
            Base = dataBase;
        }
        public void NotifyObservers()
        {
            foreach (var item in observers)
                item.Update(missedAcademics);
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void Update(object obj)
        {
            List<Academic> academics = obj as List<Academic>;
            foreach (var item in academics)
            {
                if (!Base.Records.Last().Exists(rec => rec.AcademicCode == item.code))
                {
                    missedAcademics.Add(item.code);
                }
            }
            NotifyObservers();
            missedAcademics.Clear();
        }
    }
}
