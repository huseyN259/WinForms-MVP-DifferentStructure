namespace WinF_MVP.Views
{
    partial class MainView
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lBoxStudents = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(14, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.Size = new System.Drawing.Size(767, 25);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_search.ForeColor = System.Drawing.Color.MintCream;
            this.btn_search.Location = new System.Drawing.Point(803, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 33);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lBoxStudents
            // 
            this.lBoxStudents.FormattingEnabled = true;
            this.lBoxStudents.ItemHeight = 17;
            this.lBoxStudents.Location = new System.Drawing.Point(14, 63);
            this.lBoxStudents.Name = "lBoxStudents";
            this.lBoxStudents.Size = new System.Drawing.Size(875, 378);
            this.lBoxStudents.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_add.ForeColor = System.Drawing.Color.MintCream;
            this.btn_add.Location = new System.Drawing.Point(619, 447);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 33);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Blue;
            this.btn_update.ForeColor = System.Drawing.Color.MintCream;
            this.btn_update.Location = new System.Drawing.Point(711, 447);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 33);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Red;
            this.btn_del.ForeColor = System.Drawing.Color.MintCream;
            this.btn_del.Location = new System.Drawing.Point(803, 447);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(86, 33);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 510);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lBoxStudents);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_search;
        private Button btn_search;
        private ListBox lBoxStudents;
        private Button btn_add;
        private Button btn_update;
        private Button btn_del;
    }
}