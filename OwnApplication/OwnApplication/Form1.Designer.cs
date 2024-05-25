namespace OwnApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BTNLOGOUT = new Button();
            PANELSALES = new Panel();
            RBTOTALSALES = new RadioButton();
            RBHISTORY = new RadioButton();
            BTNSALES = new Button();
            PANELORDER = new Panel();
            RBSHIPPING = new RadioButton();
            RBDELIVERED = new RadioButton();
            RBCANCELled = new RadioButton();
            BTNORDER = new Button();
            PANELCATEGORIES = new Panel();
            RBFASHION = new RadioButton();
            RBMEN = new RadioButton();
            RBELECTRONICS = new RadioButton();
            RBWOMEN = new RadioButton();
            RBKITCCHEN = new RadioButton();
            RBKID = new RadioButton();
            BTNCATEGORIES = new Button();
            BTNDASHBOAD = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            PANELSALES.SuspendLayout();
            PANELORDER.SuspendLayout();
            PANELCATEGORIES.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(BTNLOGOUT);
            panel1.Controls.Add(PANELSALES);
            panel1.Controls.Add(BTNSALES);
            panel1.Controls.Add(PANELORDER);
            panel1.Controls.Add(BTNORDER);
            panel1.Controls.Add(PANELCATEGORIES);
            panel1.Controls.Add(BTNCATEGORIES);
            panel1.Controls.Add(BTNDASHBOAD);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 479);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BTNLOGOUT
            // 
            BTNLOGOUT.Dock = DockStyle.Top;
            BTNLOGOUT.FlatStyle = FlatStyle.Popup;
            BTNLOGOUT.Location = new Point(0, 519);
            BTNLOGOUT.Name = "BTNLOGOUT";
            BTNLOGOUT.Size = new Size(201, 40);
            BTNLOGOUT.TabIndex = 11;
            BTNLOGOUT.Text = "LOGOUT";
            BTNLOGOUT.UseVisualStyleBackColor = true;
            BTNLOGOUT.MouseEnter += BTNLOGOUT_MouseEnter;
            BTNLOGOUT.MouseLeave += BTNLOGOUT_MouseLeave;
            // 
            // PANELSALES
            // 
            PANELSALES.Controls.Add(RBTOTALSALES);
            PANELSALES.Controls.Add(RBHISTORY);
            PANELSALES.Dock = DockStyle.Top;
            PANELSALES.Location = new Point(0, 464);
            PANELSALES.Name = "PANELSALES";
            PANELSALES.Size = new Size(201, 55);
            PANELSALES.TabIndex = 10;
            // 
            // RBTOTALSALES
            // 
            RBTOTALSALES.AutoSize = true;
            RBTOTALSALES.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBTOTALSALES.Location = new Point(3, 4);
            RBTOTALSALES.Name = "RBTOTALSALES";
            RBTOTALSALES.Size = new Size(79, 19);
            RBTOTALSALES.TabIndex = 1;
            RBTOTALSALES.TabStop = true;
            RBTOTALSALES.Text = "total Sales";
            RBTOTALSALES.UseVisualStyleBackColor = true;
            // 
            // RBHISTORY
            // 
            RBHISTORY.AutoSize = true;
            RBHISTORY.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBHISTORY.Location = new Point(3, 29);
            RBHISTORY.Name = "RBHISTORY";
            RBHISTORY.Size = new Size(63, 19);
            RBHISTORY.TabIndex = 7;
            RBHISTORY.TabStop = true;
            RBHISTORY.Text = "History";
            RBHISTORY.UseVisualStyleBackColor = true;
            // 
            // BTNSALES
            // 
            BTNSALES.Dock = DockStyle.Top;
            BTNSALES.FlatStyle = FlatStyle.Popup;
            BTNSALES.Location = new Point(0, 424);
            BTNSALES.Name = "BTNSALES";
            BTNSALES.Size = new Size(201, 40);
            BTNSALES.TabIndex = 10;
            BTNSALES.Text = "SALES";
            BTNSALES.UseVisualStyleBackColor = true;
            BTNSALES.Click += BTNSALES_Click;
            BTNSALES.MouseEnter += BTNSALES_MouseEnter;
            BTNSALES.MouseLeave += BTNSALES_MouseLeave;
            // 
            // PANELORDER
            // 
            PANELORDER.Controls.Add(RBSHIPPING);
            PANELORDER.Controls.Add(RBDELIVERED);
            PANELORDER.Controls.Add(RBCANCELled);
            PANELORDER.Dock = DockStyle.Top;
            PANELORDER.Location = new Point(0, 342);
            PANELORDER.Name = "PANELORDER";
            PANELORDER.Size = new Size(201, 82);
            PANELORDER.TabIndex = 9;
            // 
            // RBSHIPPING
            // 
            RBSHIPPING.AutoSize = true;
            RBSHIPPING.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBSHIPPING.Location = new Point(3, 4);
            RBSHIPPING.Name = "RBSHIPPING";
            RBSHIPPING.Size = new Size(73, 19);
            RBSHIPPING.TabIndex = 1;
            RBSHIPPING.TabStop = true;
            RBSHIPPING.Text = "Shipping";
            RBSHIPPING.UseVisualStyleBackColor = true;
            // 
            // RBDELIVERED
            // 
            RBDELIVERED.AutoSize = true;
            RBDELIVERED.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBDELIVERED.Location = new Point(3, 29);
            RBDELIVERED.Name = "RBDELIVERED";
            RBDELIVERED.Size = new Size(75, 19);
            RBDELIVERED.TabIndex = 7;
            RBDELIVERED.TabStop = true;
            RBDELIVERED.Text = "Delivered";
            RBDELIVERED.UseVisualStyleBackColor = true;
            // 
            // RBCANCELled
            // 
            RBCANCELled.AutoSize = true;
            RBCANCELled.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBCANCELled.Location = new Point(3, 54);
            RBCANCELled.Name = "RBCANCELled";
            RBCANCELled.Size = new Size(76, 19);
            RBCANCELled.TabIndex = 6;
            RBCANCELled.TabStop = true;
            RBCANCELled.Text = "Cancelled";
            RBCANCELled.UseVisualStyleBackColor = true;
            // 
            // BTNORDER
            // 
            BTNORDER.Dock = DockStyle.Top;
            BTNORDER.FlatStyle = FlatStyle.Popup;
            BTNORDER.Location = new Point(0, 302);
            BTNORDER.Name = "BTNORDER";
            BTNORDER.Size = new Size(201, 40);
            BTNORDER.TabIndex = 9;
            BTNORDER.Text = "ORDER";
            BTNORDER.UseVisualStyleBackColor = true;
            BTNORDER.Click += BTNORDER_Click;
            BTNORDER.MouseEnter += BTNORDER_MouseEnter;
            BTNORDER.MouseLeave += BTNORDER_MouseLeave;
            // 
            // PANELCATEGORIES
            // 
            PANELCATEGORIES.Controls.Add(RBFASHION);
            PANELCATEGORIES.Controls.Add(RBMEN);
            PANELCATEGORIES.Controls.Add(RBELECTRONICS);
            PANELCATEGORIES.Controls.Add(RBWOMEN);
            PANELCATEGORIES.Controls.Add(RBKITCCHEN);
            PANELCATEGORIES.Controls.Add(RBKID);
            PANELCATEGORIES.Dock = DockStyle.Top;
            PANELCATEGORIES.Location = new Point(0, 145);
            PANELCATEGORIES.Name = "PANELCATEGORIES";
            PANELCATEGORIES.Size = new Size(201, 157);
            PANELCATEGORIES.TabIndex = 8;
            PANELCATEGORIES.Paint += PANELCATEGORIES_Paint;
            // 
            // RBFASHION
            // 
            RBFASHION.AutoSize = true;
            RBFASHION.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBFASHION.Location = new Point(5, 129);
            RBFASHION.Name = "RBFASHION";
            RBFASHION.Size = new Size(66, 19);
            RBFASHION.TabIndex = 3;
            RBFASHION.TabStop = true;
            RBFASHION.Text = "Fashion";
            RBFASHION.UseVisualStyleBackColor = true;
            // 
            // RBMEN
            // 
            RBMEN.AutoSize = true;
            RBMEN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBMEN.Location = new Point(3, 4);
            RBMEN.Name = "RBMEN";
            RBMEN.Size = new Size(52, 19);
            RBMEN.TabIndex = 1;
            RBMEN.TabStop = true;
            RBMEN.Text = "`Men";
            RBMEN.UseVisualStyleBackColor = true;
            // 
            // RBELECTRONICS
            // 
            RBELECTRONICS.AutoSize = true;
            RBELECTRONICS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBELECTRONICS.Location = new Point(3, 104);
            RBELECTRONICS.Name = "RBELECTRONICS";
            RBELECTRONICS.Size = new Size(82, 19);
            RBELECTRONICS.TabIndex = 4;
            RBELECTRONICS.TabStop = true;
            RBELECTRONICS.Text = "Electronics";
            RBELECTRONICS.UseVisualStyleBackColor = true;
            // 
            // RBWOMEN
            // 
            RBWOMEN.AutoSize = true;
            RBWOMEN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBWOMEN.Location = new Point(3, 29);
            RBWOMEN.Name = "RBWOMEN";
            RBWOMEN.Size = new Size(68, 19);
            RBWOMEN.TabIndex = 7;
            RBWOMEN.TabStop = true;
            RBWOMEN.Text = "Women";
            RBWOMEN.UseVisualStyleBackColor = true;
            // 
            // RBKITCCHEN
            // 
            RBKITCCHEN.AutoSize = true;
            RBKITCCHEN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBKITCCHEN.Location = new Point(3, 79);
            RBKITCCHEN.Name = "RBKITCCHEN";
            RBKITCCHEN.Size = new Size(65, 19);
            RBKITCCHEN.TabIndex = 5;
            RBKITCCHEN.TabStop = true;
            RBKITCCHEN.Text = "Kitchen";
            RBKITCCHEN.UseVisualStyleBackColor = true;
            // 
            // RBKID
            // 
            RBKID.AutoSize = true;
            RBKID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBKID.Location = new Point(3, 54);
            RBKID.Name = "RBKID";
            RBKID.Size = new Size(42, 19);
            RBKID.TabIndex = 6;
            RBKID.TabStop = true;
            RBKID.Text = "Kid";
            RBKID.UseVisualStyleBackColor = true;
            // 
            // BTNCATEGORIES
            // 
            BTNCATEGORIES.Dock = DockStyle.Top;
            BTNCATEGORIES.FlatStyle = FlatStyle.Popup;
            BTNCATEGORIES.Location = new Point(0, 105);
            BTNCATEGORIES.Name = "BTNCATEGORIES";
            BTNCATEGORIES.Size = new Size(201, 40);
            BTNCATEGORIES.TabIndex = 2;
            BTNCATEGORIES.Text = "CATEGORIES";
            BTNCATEGORIES.UseVisualStyleBackColor = true;
            BTNCATEGORIES.Click += BTNCATEGORIES_Click;
            BTNCATEGORIES.MouseEnter += BTNCATEGORIES_MouseEnter;
            BTNCATEGORIES.MouseLeave += BTNCATEGORIES_MouseLeave;
            // 
            // BTNDASHBOAD
            // 
            BTNDASHBOAD.Dock = DockStyle.Top;
            BTNDASHBOAD.FlatStyle = FlatStyle.Popup;
            BTNDASHBOAD.Location = new Point(0, 65);
            BTNDASHBOAD.Name = "BTNDASHBOAD";
            BTNDASHBOAD.Size = new Size(201, 40);
            BTNDASHBOAD.TabIndex = 1;
            BTNDASHBOAD.Text = "DASHBOARD";
            BTNDASHBOAD.UseVisualStyleBackColor = true;
            BTNDASHBOAD.Click += BTNDASHBOAD_Click;
            BTNDASHBOAD.MouseEnter += BTNDASHBOAD_MouseEnter;
            BTNDASHBOAD.MouseLeave += BTNDASHBOAD_MouseLeave;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 65);
            panel2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 479);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            PANELSALES.ResumeLayout(false);
            PANELSALES.PerformLayout();
            PANELORDER.ResumeLayout(false);
            PANELORDER.PerformLayout();
            PANELCATEGORIES.ResumeLayout(false);
            PANELCATEGORIES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTNDASHBOAD;
        private Panel PANELCATEGORIES;
        private RadioButton RBFASHION;
        private RadioButton RBMEN;
        private RadioButton RBELECTRONICS;
        private RadioButton RBWOMEN;
        private RadioButton RBKITCCHEN;
        private RadioButton RBKID;
        private Button BTNCATEGORIES;
        private Button BTNORDER;
        private Panel PANELORDER;
        private RadioButton RBSHIPPING;
        private RadioButton RBDELIVERED;
        private RadioButton RBCANCELled;
        private Panel PANELSALES;
        private RadioButton RBTOTALSALES;
        private RadioButton RBHISTORY;
        private Button BTNSALES;
        private Button BTNLOGOUT;
        private Panel panel2;
    }
}
