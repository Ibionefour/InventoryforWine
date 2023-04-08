namespace FPWinery
{
    partial class HomePage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveWine = new System.Windows.Forms.Button();
            this.WineSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WineStock = new System.Windows.Forms.TextBox();
            this.WinePrice = new System.Windows.Forms.TextBox();
            this.WineName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WineDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.SupplierSource = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveSup = new System.Windows.Forms.Button();
            this.SupLocation = new System.Windows.Forms.TextBox();
            this.SupName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SupEmail = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WineDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.WineDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wine";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wine";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveWine);
            this.panel1.Controls.Add(this.WineSupplier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.WineStock);
            this.panel1.Controls.Add(this.WinePrice);
            this.panel1.Controls.Add(this.WineName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(458, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 274);
            this.panel1.TabIndex = 1;
            // 
            // SaveWine
            // 
            this.SaveWine.Location = new System.Drawing.Point(108, 224);
            this.SaveWine.Name = "SaveWine";
            this.SaveWine.Size = new System.Drawing.Size(153, 30);
            this.SaveWine.TabIndex = 9;
            this.SaveWine.Text = "Save";
            this.SaveWine.UseVisualStyleBackColor = true;
            this.SaveWine.Click += new System.EventHandler(this.SaveWine_Click);
            // 
            // WineSupplier
            // 
            this.WineSupplier.FormattingEnabled = true;
            this.WineSupplier.Location = new System.Drawing.Point(108, 179);
            this.WineSupplier.Name = "WineSupplier";
            this.WineSupplier.Size = new System.Drawing.Size(147, 23);
            this.WineSupplier.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Supplier";
            // 
            // WineStock
            // 
            this.WineStock.Location = new System.Drawing.Point(108, 139);
            this.WineStock.Name = "WineStock";
            this.WineStock.Size = new System.Drawing.Size(147, 23);
            this.WineStock.TabIndex = 6;
            // 
            // WinePrice
            // 
            this.WinePrice.Location = new System.Drawing.Point(108, 101);
            this.WinePrice.Name = "WinePrice";
            this.WinePrice.Size = new System.Drawing.Size(147, 23);
            this.WinePrice.TabIndex = 5;
            // 
            // WineName
            // 
            this.WineName.Location = new System.Drawing.Point(108, 67);
            this.WineName.Name = "WineName";
            this.WineName.Size = new System.Drawing.Size(147, 23);
            this.WineName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(108, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Wine";
            // 
            // WineDataGrid
            // 
            this.WineDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WineDataGrid.Location = new System.Drawing.Point(8, 98);
            this.WineDataGrid.Name = "WineDataGrid";
            this.WineDataGrid.RowTemplate.Height = 25;
            this.WineDataGrid.Size = new System.Drawing.Size(420, 274);
            this.WineDataGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.SupplierSource);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Supplier";
            // 
            // SupplierSource
            // 
            this.SupplierSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierSource.Location = new System.Drawing.Point(9, 94);
            this.SupplierSource.Name = "SupplierSource";
            this.SupplierSource.RowTemplate.Height = 25;
            this.SupplierSource.Size = new System.Drawing.Size(420, 274);
            this.SupplierSource.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SupEmail);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.SaveSup);
            this.panel2.Controls.Add(this.SupLocation);
            this.panel2.Controls.Add(this.SupName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(459, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 274);
            this.panel2.TabIndex = 4;
            // 
            // SaveSup
            // 
            this.SaveSup.Location = new System.Drawing.Point(90, 224);
            this.SaveSup.Name = "SaveSup";
            this.SaveSup.Size = new System.Drawing.Size(153, 30);
            this.SaveSup.TabIndex = 9;
            this.SaveSup.Text = "Save";
            this.SaveSup.UseVisualStyleBackColor = true;
            this.SaveSup.Click += new System.EventHandler(this.SaveSup_Click);
            // 
            // SupLocation
            // 
            this.SupLocation.Location = new System.Drawing.Point(48, 132);
            this.SupLocation.Name = "SupLocation";
            this.SupLocation.Size = new System.Drawing.Size(244, 23);
            this.SupLocation.TabIndex = 5;
            // 
            // SupName
            // 
            this.SupName.Location = new System.Drawing.Point(48, 88);
            this.SupName.Name = "SupName";
            this.SupName.Size = new System.Drawing.Size(244, 23);
            this.SupName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Location";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Supplier Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(90, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add Supplier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email Address";
            // 
            // SupEmail
            // 
            this.SupEmail.Location = new System.Drawing.Point(48, 176);
            this.SupEmail.Name = "SupEmail";
            this.SupEmail.Size = new System.Drawing.Size(244, 23);
            this.SupEmail.TabIndex = 11;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomePage";
            this.Text = "Winery - Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WineDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView WineDataGrid;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox WinePrice;
        private TextBox WineName;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox WineSupplier;
        private Label label6;
        private TextBox WineStock;
        private Button SaveWine;
        private Label label7;
        private DataGridView SupplierSource;
        private Panel panel2;
        private Button SaveSup;
        private TextBox SupLocation;
        private TextBox SupName;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label8;
        private TextBox SupEmail;
    }
}