namespace HomeDatabase
{
    partial class Search_window
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.location_checkbox = new System.Windows.Forms.CheckBox();
            this.category_chekbox = new System.Windows.Forms.CheckBox();
            this.name_checkbox = new System.Windows.Forms.CheckBox();
            this.category_combo = new System.Windows.Forms.ComboBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.location_combo = new System.Windows.Forms.ComboBox();
            this.test_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.location_checkbox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.category_chekbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_checkbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.category_combo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.location_combo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.test_button, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // location_checkbox
            // 
            this.location_checkbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.location_checkbox.Location = new System.Drawing.Point(140, 69);
            this.location_checkbox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.location_checkbox.MaximumSize = new System.Drawing.Size(111, 55);
            this.location_checkbox.Name = "location_checkbox";
            this.location_checkbox.Size = new System.Drawing.Size(111, 28);
            this.location_checkbox.TabIndex = 6;
            this.location_checkbox.Text = "Lokalizacja";
            this.location_checkbox.UseVisualStyleBackColor = true;
            this.location_checkbox.CheckedChanged += new System.EventHandler(this.Location_checkbox_CheckedChanged);
            // 
            // category_chekbox
            // 
            this.category_chekbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.category_chekbox.Location = new System.Drawing.Point(140, 36);
            this.category_chekbox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.category_chekbox.MaximumSize = new System.Drawing.Size(111, 55);
            this.category_chekbox.Name = "category_chekbox";
            this.category_chekbox.Size = new System.Drawing.Size(111, 27);
            this.category_chekbox.TabIndex = 3;
            this.category_chekbox.Text = "Kategoria";
            this.category_chekbox.UseVisualStyleBackColor = true;
            this.category_chekbox.CheckedChanged += new System.EventHandler(this.Category_chekbox_CheckedChanged);
            // 
            // name_checkbox
            // 
            this.name_checkbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.name_checkbox.Location = new System.Drawing.Point(140, 3);
            this.name_checkbox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.name_checkbox.MaximumSize = new System.Drawing.Size(111, 55);
            this.name_checkbox.Name = "name_checkbox";
            this.name_checkbox.Size = new System.Drawing.Size(111, 27);
            this.name_checkbox.TabIndex = 0;
            this.name_checkbox.Text = "Nazwa";
            this.name_checkbox.UseVisualStyleBackColor = true;
            this.name_checkbox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // category_combo
            // 
            this.category_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category_combo.Enabled = false;
            this.category_combo.FormattingEnabled = true;
            this.category_combo.Location = new System.Drawing.Point(269, 36);
            this.category_combo.Name = "category_combo";
            this.category_combo.Size = new System.Drawing.Size(260, 21);
            this.category_combo.TabIndex = 7;
            // 
            // name_box
            // 
            this.name_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_box.Location = new System.Drawing.Point(269, 3);
            this.name_box.Name = "name_box";
            this.name_box.ReadOnly = true;
            this.name_box.Size = new System.Drawing.Size(260, 20);
            this.name_box.TabIndex = 8;
            this.name_box.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // location_combo
            // 
            this.location_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.location_combo.Enabled = false;
            this.location_combo.FormattingEnabled = true;
            this.location_combo.Location = new System.Drawing.Point(269, 69);
            this.location_combo.Name = "location_combo";
            this.location_combo.Size = new System.Drawing.Size(260, 21);
            this.location_combo.TabIndex = 9;
            // 
            // test_button
            // 
            this.test_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.test_button.Location = new System.Drawing.Point(586, 37);
            this.test_button.MaximumSize = new System.Drawing.Size(160, 25);
            this.test_button.MinimumSize = new System.Drawing.Size(160, 25);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(160, 25);
            this.test_button.TabIndex = 10;
            this.test_button.Text = "Testuj połączenie";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.Test_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jak chcesz wyszukać przedmiot?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 258);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Search_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Search_window";
            this.Text = "Search_window";
            this.Load += new System.EventHandler(this.Search_window_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox name_checkbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox location_checkbox;
        private System.Windows.Forms.CheckBox category_chekbox;
        private System.Windows.Forms.ComboBox category_combo;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox location_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button test_button;
    }
}