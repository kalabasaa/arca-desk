
namespace arca_desk
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Panel navPanel;
        private Panel contentPanel;

        private PictureBox logo;
        private Label brandTitle;
        private Label brandSubtitle;
        private Label headerStatus;
        private Label menuLabel;

        private Button dashboard;
        private Button inventory;
        private Button counter;
        private Button supply;
        private Button sales;
        private Button receipts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            headerPanel = new Panel();
            logo = new PictureBox();
            brandTitle = new Label();
            brandSubtitle = new Label();
            headerStatus = new Label();

            navPanel = new Panel();
            sales = new Button();
            menuLabel = new Label();
            dashboard = new Button();
            inventory = new Button();
            counter = new Button();
            supply = new Button();
            receipts = new Button();

            contentPanel = new Panel();

            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            navPanel.SuspendLayout();
            SuspendLayout();

            // headerPanel
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(logo);
            headerPanel.Controls.Add(brandTitle);
            headerPanel.Controls.Add(brandSubtitle);
            headerPanel.Controls.Add(headerStatus);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1463, 101);
            headerPanel.TabIndex = 2;

            // logo
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 13);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(80, 80);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;

            // brandTitle
            brandTitle.AutoSize = true;
            brandTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            brandTitle.ForeColor = Color.FromArgb(35, 42, 52);
            brandTitle.Location = new Point(94, 19);
            brandTitle.Name = "brandTitle";
            brandTitle.Size = new Size(151, 35);
            brandTitle.TabIndex = 1;
            brandTitle.Text = "ARCA DESK";

            // brandSubtitle
            brandSubtitle.AutoSize = true;
            brandSubtitle.Font = new Font("Segoe UI", 8.5F);
            brandSubtitle.ForeColor = Color.FromArgb(120, 128, 140);
            brandSubtitle.Location = new Point(96, 57);
            brandSubtitle.Name = "brandSubtitle";
            brandSubtitle.Size = new Size(229, 20);
            brandSubtitle.TabIndex = 2;
            brandSubtitle.Text = "Inventory and Sales Management";

            // headerStatus
            headerStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            headerStatus.AutoSize = true;
            headerStatus.Font = new Font("Segoe UI", 9F);
            headerStatus.ForeColor = Color.FromArgb(90, 100, 110);
            headerStatus.Location = new Point(2468, 39);
            headerStatus.Name = "headerStatus";
            headerStatus.Size = new Size(101, 20);
            headerStatus.TabIndex = 3;
            headerStatus.Text = "System Ready";

            // navPanel
            navPanel.BackColor = Color.FromArgb(35, 44, 58);
            navPanel.Controls.Add(sales);
            navPanel.Controls.Add(menuLabel);
            navPanel.Controls.Add(dashboard);
            navPanel.Controls.Add(inventory);
            navPanel.Controls.Add(counter);
            navPanel.Controls.Add(supply);
            navPanel.Controls.Add(receipts);
            navPanel.Dock = DockStyle.Left;
            navPanel.Location = new Point(0, 101);
            navPanel.Margin = new Padding(3, 4, 3, 4);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(286, 703);
            navPanel.TabIndex = 1;

            // sales
            sales.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            sales.ForeColor = SystemColors.ControlLightLight;
            sales.Location = new Point(12, 468);
            sales.Margin = new Padding(3, 4, 8, 90);
            sales.Name = "sales";
            sales.Size = new Size(263, 64);
            sales.TabIndex = 5;
            sales.Text = "Sales";

            // menuLabel
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            menuLabel.ForeColor = Color.FromArgb(155, 165, 180);
            menuLabel.Location = new Point(12, 27);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(92, 19);
            menuLabel.TabIndex = 0;
            menuLabel.Text = "MAIN MENU";

            // dashboard
            dashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard.ForeColor = SystemColors.ControlLightLight;
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.Location = new Point(12, 72);
            dashboard.Margin = new Padding(3, 4, 8, 90);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(263, 64);
            dashboard.TabIndex = 1;
            dashboard.Text = "Dashboard";

            // inventory
            inventory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            inventory.ForeColor = SystemColors.ControlLightLight;
            inventory.Location = new Point(12, 152);
            inventory.Margin = new Padding(3, 4, 8, 90);
            inventory.Name = "inventory";
            inventory.Size = new Size(263, 64);
            inventory.TabIndex = 2;
            inventory.Text = "Inventory";

            // counter
            counter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            counter.ForeColor = SystemColors.ControlLightLight;
            counter.Location = new Point(12, 230);
            counter.Margin = new Padding(3, 4, 8, 90);
            counter.Name = "counter";
            counter.Size = new Size(263, 64);
            counter.TabIndex = 3;
            counter.Text = "Counter";

            // supply
            supply.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            supply.ForeColor = SystemColors.ControlLightLight;
            supply.Location = new Point(15, 310);
            supply.Margin = new Padding(3, 4, 8, 90);
            supply.Name = "supply";
            supply.Size = new Size(263, 64);
            supply.TabIndex = 4;
            supply.Text = "Supply";

            // receipts
            receipts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            receipts.ForeColor = SystemColors.ControlLightLight;
            receipts.Location = new Point(12, 388);
            receipts.Margin = new Padding(3, 4, 8, 90);
            receipts.Name = "receipts";
            receipts.Size = new Size(263, 64);
            receipts.TabIndex = 6;
            receipts.Text = "Receipts";

            // contentPanel
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(286, 101);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(29, 33, 29, 33);
            contentPanel.Size = new Size(1177, 703);
            contentPanel.TabIndex = 0;

            // MainForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1463, 804);
            Controls.Add(contentPanel);
            Controls.Add(navPanel);
            Controls.Add(headerPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 851);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arca Desk";

            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
