using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.ObserverNotification
{
    public interface Subject
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void notifyObserver(string Notification);
    }
}
