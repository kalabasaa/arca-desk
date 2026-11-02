namespace arca_desk.Components
{
    partial class Navigation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            receipts = new Button();
            supply = new Button();
            sales = new Button();
            inventory = new Button();
            dashboard = new Button();
            menuLabel = new Label();
            counter = new Button();
            SuspendLayout();
            // 
            // receipts
            // 
            receipts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            receipts.ForeColor = SystemColors.ControlLightLight;
            receipts.Location = new Point(15, 495);
            receipts.Margin = new Padding(3, 4, 8, 90);
            receipts.Name = "receipts";
            receipts.Size = new Size(263, 64);
            receipts.TabIndex = 13;
            receipts.Text = "Receipts";
            // 
            // supply
            // 
            supply.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            supply.ForeColor = SystemColors.ControlLightLight;
            supply.Location = new Point(18, 417);
            supply.Margin = new Padding(3, 4, 8, 90);
            supply.Name = "supply";
            supply.Size = new Size(263, 64);
            supply.TabIndex = 11;
            supply.Text = "Supply";
            // 
            // sales
            // 
            sales.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            sales.ForeColor = SystemColors.ControlLightLight;
            sales.Location = new Point(15, 575);
            sales.Margin = new Padding(3, 4, 8, 90);
            sales.Name = "sales";
            sales.Size = new Size(263, 64);
            sales.TabIndex = 12;
            sales.Text = "Sales";
            // 
            // inventory
            // 
            inventory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            inventory.ForeColor = SystemColors.ControlLightLight;
            inventory.Location = new Point(15, 259);
            inventory.Margin = new Padding(3, 4, 8, 90);
            inventory.Name = "inventory";
            inventory.Size = new Size(263, 64);
            inventory.TabIndex = 9;
            inventory.Text = "Inventory";
            // 
            // dashboard
            // 
            dashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard.ForeColor = SystemColors.ControlLightLight;
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.Location = new Point(15, 179);
            dashboard.Margin = new Padding(3, 4, 8, 90);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(263, 64);
            dashboard.TabIndex = 8;
            dashboard.Text = "Dashboard";
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            menuLabel.ForeColor = Color.FromArgb(155, 165, 180);
            menuLabel.Location = new Point(15, 134);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(92, 19);
            menuLabel.TabIndex = 7;
            menuLabel.Text = "MAIN MENU";
            // 
            // counter
            // 
            counter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            counter.ForeColor = SystemColors.ControlLightLight;
            counter.Location = new Point(15, 337);
            counter.Margin = new Padding(3, 4, 8, 90);
            counter.Name = "counter";
            counter.Size = new Size(263, 64);
            counter.TabIndex = 10;
            counter.Text = "Counter";
            // 
            // Navigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(sales);
            Controls.Add(menuLabel);
            Controls.Add(dashboard);
            Controls.Add(inventory);
            Controls.Add(counter);
            Controls.Add(supply);
            Controls.Add(receipts);
            Name = "Navigation";
            Size = new Size(286, 703);
            Load += Navigation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button receipts;
        private Button supply;
        private Button sales;
        private Button inventory;
        private Button dashboard;
        private Label menuLabel;
        private Button counter;
    }
}
