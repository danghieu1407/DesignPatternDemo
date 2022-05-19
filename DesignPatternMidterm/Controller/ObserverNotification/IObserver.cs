using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.ObserverNotification
{
    public interface IObserver
    {
        public void Update(string Notification);
    }
}
