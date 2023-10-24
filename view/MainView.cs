using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnProvider.Click += delegate { ShowProviderView?.Invoke(this, EventArgs.Empty); };
            

            BtnExit.Click += delegate { this.Close(); };


        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowProviderView;
        public event EventHandler ShowCategorieView;
        public event EventHandler ShowSellView;
    }
}
