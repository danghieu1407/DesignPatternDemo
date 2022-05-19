using DesignPatternMidterm.Controller.ObserverNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.View
{
    public partial class DeviceObserver : Form, IObserver
    {
        ISubjectNotification notification;
        public DeviceObserver(ISubjectNotification notification)
        {
            InitializeComponent();
            this.notification = notification;
            this.FormClosing += DeviceFormClosing;
        }

        private void DeviceFormClosing(object? sender, FormClosingEventArgs e)
        {
            notification.UnregisterObserver(this);
        }

        public void Update(string noti)
        {
            MesseageText.Text = noti;
        }
    }
}
