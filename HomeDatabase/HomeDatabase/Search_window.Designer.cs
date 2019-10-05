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
            this.location_radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.category_radio = new System.Windows.Forms.RadioButton();
            this.name_radio = new System.Windows.Forms.RadioButton();
            this.search_button = new System.Windows.Forms.Button();
            this.category_combo = new System.Windows.Forms.ComboBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.location_combo = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.Controls.Add(this.location_radio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.category_radio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_radio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.category_combo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.location_combo, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // location_radio
            // 
            this.location_radio.Dock = System.Windows.Forms.DockStyle.Right;
            this.location_radio.Location = new System.Drawing.Point(181, 69);
            this.location_radio.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.location_radio.Name = "location_radio";
            this.location_radio.Size = new System.Drawing.Size(70, 28);
            this.location_radio.TabIndex = 5;
            this.location_radio.TabStop = true;
            this.location_radio.Text = "Lokacja";
            this.location_radio.UseVisualStyleBackColor = true;
            this.location_radio.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(606, 70);
            this.button1.MaximumSize = new System.Drawing.Size(120, 25);
            this.button1.MinimumSize = new System.Drawing.Size(120, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Testuj połączenie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // category_radio
            // 
            this.category_radio.Dock = System.Windows.Forms.DockStyle.Right;
            this.category_radio.Location = new System.Drawing.Point(181, 36);
            this.category_radio.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.category_radio.Name = "category_radio";
            this.category_radio.Size = new System.Drawing.Size(70, 27);
            this.category_radio.TabIndex = 4;
            this.category_radio.TabStop = true;
            this.category_radio.Text = "Kategoria";
            this.category_radio.UseVisualStyleBackColor = true;
            this.category_radio.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // name_radio
            // 
            this.name_radio.Dock = System.Windows.Forms.DockStyle.Right;
            this.name_radio.Location = new System.Drawing.Point(181, 3);
            this.name_radio.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.name_radio.Name = "name_radio";
            this.name_radio.Size = new System.Drawing.Size(70, 27);
            this.name_radio.TabIndex = 3;
            this.name_radio.TabStop = true;
            this.name_radio.Text = "Nazwa";
            this.name_radio.UseVisualStyleBackColor = true;
            this.name_radio.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // search_button
            // 
            this.search_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_button.Location = new System.Drawing.Point(586, 4);
            this.search_button.MaximumSize = new System.Drawing.Size(160, 25);
            this.search_button.MinimumSize = new System.Drawing.Size(160, 25);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(160, 25);
            this.search_button.TabIndex = 10;
            this.search_button.Text = "Szukaj";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // category_combo
            // 
            this.category_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.name_box.Enabled = false;
            this.name_box.Location = new System.Drawing.Point(269, 3);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(260, 20);
            this.name_box.TabIndex = 8;
            this.name_box.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // location_combo
            // 
            this.location_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.location_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_combo.Enabled = false;
            this.location_combo.FormattingEnabled = true;
            this.location_combo.Location = new System.Drawing.Point(269, 69);
            this.location_combo.Name = "location_combo";
            this.location_combo.Size = new System.Drawing.Size(260, 21);
            this.location_combo.TabIndex = 9;
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
            this.label1.Click += new System.EventHandler(this.Label1_Click);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox category_combo;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox location_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton name_radio;
        private System.Windows.Forms.RadioButton category_radio;
        private System.Windows.Forms.RadioButton location_radio;
    }
}