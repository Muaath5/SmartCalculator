using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCalculator
{
    public class SuperWebBrowser : WebBrowser
    {
        public event EventHandler Click;

        protected override void OnClick(EventArgs e)
        {
            EventHandler handler = Click;
            handler?.Invoke(this, EventArgs.Empty);
            base.OnClick(e);
        }
    }
}
