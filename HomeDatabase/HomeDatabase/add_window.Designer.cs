namespace HomeDatabase
{
    partial class add_window
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.name_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.location_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.category_combo = new System.Windows.Forms.ComboBox();
            this.location_combo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.add_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 88);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj przedmiot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.location_combo, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.category_combo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.category_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.location_label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.name_box, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 94);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 170);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel2_Paint);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label.Font = new System.Drawing.Font("HP Simplified", 12F);
            this.name_label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.name_label.Location = new System.Drawing.Point(3, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(314, 56);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Nazwa";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category_label.Font = new System.Drawing.Font("HP Simplified", 12F);
            this.category_label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.category_label.Location = new System.Drawing.Point(3, 56);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(314, 56);
            this.category_label.TabIndex = 2;
            this.category_label.Text = "Kategoria";
            this.category_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.location_label.Font = new System.Drawing.Font("HP Simplified", 12F);
            this.location_label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.location_label.Location = new System.Drawing.Point(3, 112);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(314, 58);
            this.location_label.TabIndex = 3;
            this.location_label.Text = "Lokacja";
            this.location_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_box
            // 
            this.name_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_box.Location = new System.Drawing.Point(330, 18);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(300, 20);
            this.name_box.TabIndex = 4;
            this.name_box.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // category_combo
            // 
            this.category_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.category_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_combo.FormattingEnabled = true;
            this.category_combo.Location = new System.Drawing.Point(330, 74);
            this.category_combo.Name = "category_combo";
            this.category_combo.Size = new System.Drawing.Size(300, 21);
            this.category_combo.TabIndex = 8;
            // 
            // location_combo
            // 
            this.location_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.location_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_combo.FormattingEnabled = true;
            this.location_combo.Location = new System.Drawing.Point(330, 131);
            this.location_combo.Name = "location_combo";
            this.location_combo.Size = new System.Drawing.Size(300, 21);
            this.location_combo.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.add_button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.status_label, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 270);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 180);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // add_button
            // 
            this.add_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_button.Font = new System.Drawing.Font("HP Simplified", 17F);
            this.add_button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.add_button.Location = new System.Drawing.Point(320, 26);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(160, 37);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // status_label
            // 
            this.status_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("HP Simplified", 15F);
            this.status_label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.status_label.Location = new System.Drawing.Point(250, 123);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(300, 24);
            this.status_label.TabIndex = 1;
            this.status_label.Text = "Udało się dodać przedmiot do bazy!";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status_label.Visible = false;
            // 
            // add_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "add_window";
            this.Load += new System.EventHandler(this.Add_window_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox category_combo;
        private System.Windows.Forms.ComboBox location_combo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label status_label;
    }
}