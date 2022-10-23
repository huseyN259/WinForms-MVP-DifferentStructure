namespace WinF_MVP.Views
{
    partial class UpdateView
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.num_score = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_score)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel.ForeColor = System.Drawing.Color.MintCream;
            this.btn_cancel.Location = new System.Drawing.Point(249, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(221, 33);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_save.ForeColor = System.Drawing.Color.MintCream;
            this.btn_save.Location = new System.Drawing.Point(13, 226);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(199, 33);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date Of Birth";
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(13, 100);
            this.txt_last_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.PlaceholderText = "LastName";
            this.txt_last_name.Size = new System.Drawing.Size(153, 29);
            this.txt_last_name.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(236, 39);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12);
            this.monthCalendar1.MaxDate = new System.DateTime(2022, 10, 14, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1900, 12, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(13, 39);
            this.txt_first_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.PlaceholderText = "FirstName";
            this.txt_first_name.Size = new System.Drawing.Size(153, 29);
            this.txt_first_name.TabIndex = 7;
            // 
            // num_score
            // 
            this.num_score.DecimalPlaces = 1;
            this.num_score.Location = new System.Drawing.Point(17, 172);
            this.num_score.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.num_score.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_score.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_score.Name = "num_score";
            this.num_score.Size = new System.Drawing.Size(149, 29);
            this.num_score.TabIndex = 14;
            this.num_score.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 291);
            this.Controls.Add(this.num_score);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txt_first_name);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateView";
            this.Text = "UpdateView";
            ((System.ComponentModel.ISupportInitialize)(this.num_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private Label label1;
        private TextBox txt_last_name;
        private MonthCalendar monthCalendar1;
        private TextBox txt_first_name;
        private NumericUpDown num_score;
    }
}