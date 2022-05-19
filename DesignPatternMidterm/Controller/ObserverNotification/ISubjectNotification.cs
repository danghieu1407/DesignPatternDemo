using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.ObserverNotification
{
    public class ISubjectNotification : Subject
    {
        private List<IObserver> observers;
        private string notification;

        public ISubjectNotification()
        {
            observers = new List<IObserver>();
            this.notification = "Chưa có thông báo";
        }

        public void ReplaceNotification(string noti)
        {
            this.notification = noti;
            notifyObserver(this.notification);
        }

        public void RemoveNotification()
        {
            this.notification = "Chưa có thông báo";
            notifyObserver(this.notification);

        }
        public  void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void notifyObserver(string Notification)
        { 
            foreach(IObserver observer in observers)
            {
                observer.Update(Notification);
            }    
        }
    }
}
