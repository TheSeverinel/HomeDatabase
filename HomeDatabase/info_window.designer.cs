namespace HomeDatabase
{
    partial class info_window
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
            this.info_window_label = new System.Windows.Forms.Label();
            this.info_window_text = new System.Windows.Forms.Label();
            this.info_window_end_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.info_window_text, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.info_window_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.info_window_end_button, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // info_window_label
            // 
            this.info_window_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_window_label.AutoSize = true;
            this.info_window_label.Font = new System.Drawing.Font("HP Simplified", 20F);
            this.info_window_label.Location = new System.Drawing.Point(206, 10);
            this.info_window_label.Name = "info_window_label";
            this.info_window_label.Size = new System.Drawing.Size(130, 30);
            this.info_window_label.TabIndex = 0;
            this.info_window_label.Text = "Informacje";
            // 
            // info_window_text
            // 
            this.info_window_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_window_text.Font = new System.Drawing.Font("HP Simplified", 12F);
            this.info_window_text.Location = new System.Drawing.Point(79, 75);
            this.info_window_text.Name = "info_window_text";
            this.info_window_text.Size = new System.Drawing.Size(384, 75);
            this.info_window_text.TabIndex = 1;
            this.info_window_text.Text = "Jest to program, który pozwala stworzyć bazę ekwipunku.";
            this.info_window_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_window_end_button
            // 
            this.info_window_end_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_window_end_button.Location = new System.Drawing.Point(202, 197);
            this.info_window_end_button.Name = "info_window_end_button";
            this.info_window_end_button.Size = new System.Drawing.Size(138, 32);
            this.info_window_end_button.TabIndex = 2;
            this.info_window_end_button.Text = "Zamknij";
            this.info_window_end_button.UseVisualStyleBackColor = true;
            this.info_window_end_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Info_window_end_button_MouseClick);
            // 
            // info_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(816, 488);
            this.MinimumSize = new System.Drawing.Size(558, 289);
            this.Name = "info_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacje";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label info_window_label;
        private System.Windows.Forms.Label info_window_text;
        private System.Windows.Forms.Button info_window_end_button;
    }
}