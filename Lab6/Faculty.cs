using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL6_Observer
{
    class Faculty : IObservable
    {
        List<IObserver> observers;

        public List<Academic> academics;
        public Faculty()
        {
            academics = new List<Academic>();
            observers = new List<IObserver>();
        }
        public void AddAcademic(Academic a)
        {
            academics.Add(a);
        }
        //public void FreeAcademic(string name)
        //{
        //    Academic academic = academics.Find(item => item.name == name);
        //    academics.Remove(academic);
        //}
        public void FreeAcademic(int name)
        {
            Academic academic = academics.Find(item => item.code == name);
            academics.Remove(academic);
        }
        public void CreateRecords(DataBase dataBase)
        {
            dataBase.AddEntry();
            foreach (var a in academics)
                a.CreateRecord(dataBase);

            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var item in observers)
                item.Update(academics);
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
