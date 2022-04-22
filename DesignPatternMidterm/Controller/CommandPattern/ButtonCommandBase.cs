using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMidterm.Controller.CommandPattern
{
    abstract class ButtonCommandBase
    {
        protected Button[] items;

        protected ButtonCommandBase(params Button[] items)
        {
            this.items = items;
        }

        public abstract void execute();
    }

    class EnableCmd : ButtonCommandBase
    {
        public EnableCmd(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.Enabled = true;
            }
        }
    }

    class DisableCmd : ButtonCommandBase
    {
        public DisableCmd(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.Enabled = false;
            }
        }
    }
    class DefColor : ButtonCommandBase
    {
        public DefColor(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.BackColor = Color.Transparent;
            }
        }
    }

    class ButtonHide : ButtonCommandBase
    {
        public ButtonHide(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.Hide();
            }
        }
    }
    class ButtonShow : ButtonCommandBase
    {
        public ButtonShow(params Button[] items) : base(items) { }
        public override void execute()
        {
            foreach (var button in items)
            {
                button.Show();

                
            }
        }
    }
}
