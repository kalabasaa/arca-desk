using arca_desk.Components;
using arca_desk.Pages;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace arca_desk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            navigation1.NavigationItemClicked += Navigation1_NavigationItemClicked;

            LoadPage(new Dashboard());
        }

        private void LoadPage(UserControl page)
        {
            contentPanel.Controls.Clear();

            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        private void Navigation1_NavigationItemClicked(object? sender, string pageName)
        {
            UserControl page = pageName switch
            {
                "Dashboard" => new Dashboard(),
                "Inventory" => new Inventory(),
                "Counter" => new Counter(),
                "Supply" => new Supply(),
                "Sales" => new Sales(),
                "Receipts" => new Receipts(),
                _ => new Dashboard()
            };

            LoadPage(page);
        }
    }
}