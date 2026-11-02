using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace arca_desk.Components
{
    public partial class Navigation : UserControl
    {
        public event EventHandler<string>? NavigationItemClicked; // NEW

        public Navigation()
        {
            InitializeComponent();

            dashboard.Click += (s, e) => NavigationItemClicked?.Invoke(this, "Dashboard");
            inventory.Click += (s, e) => NavigationItemClicked?.Invoke(this, "Inventory");
            counter.Click += (s, e) => NavigationItemClicked?.Invoke(this, "Counter");
            supply.Click += (s, e) => NavigationItemClicked?.Invoke(this, "Supply");
            sales.Click += (s, e) => NavigationItemClicked?.Invoke(this, "Sales");
            receipts.Click += (s, e) => NavigationItemClicked?.Invoke(this, "Receipts");
        }

        private void Navigation_Load(object sender, EventArgs e)
        {
        }
    }
}