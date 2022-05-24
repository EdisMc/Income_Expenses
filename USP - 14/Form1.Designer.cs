namespace USP___14
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flatButtonStatistics = new USP___14.FlatButton();
            this.flatButtonSearch = new USP___14.FlatButton();
            this.flatButtonCreareExpense = new USP___14.FlatButton();
            this.flatButtonCreateRevenue = new USP___14.FlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Mouse_Move);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Mouse_Up);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(939, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(983, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.flatButtonStatistics);
            this.panel2.Controls.Add(this.flatButtonSearch);
            this.panel2.Controls.Add(this.flatButtonCreareExpense);
            this.panel2.Controls.Add(this.flatButtonCreateRevenue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 574);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, -1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(239, 137);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // flatButtonStatistics
            // 
            this.flatButtonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.flatButtonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButtonStatistics.ForeColor = System.Drawing.Color.White;
            this.flatButtonStatistics.Location = new System.Drawing.Point(-3, 341);
            this.flatButtonStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButtonStatistics.Name = "flatButtonStatistics";
            this.flatButtonStatistics.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.flatButtonStatistics.Size = new System.Drawing.Size(256, 65);
            this.flatButtonStatistics.TabIndex = 7;
            this.flatButtonStatistics.Text = "Справки";
            this.flatButtonStatistics.UseVisualStyleBackColor = false;
            this.flatButtonStatistics.Click += new System.EventHandler(this.flatButtonStatistics_Click);
            // 
            // flatButtonSearch
            // 
            this.flatButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.flatButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButtonSearch.ForeColor = System.Drawing.Color.White;
            this.flatButtonSearch.Location = new System.Drawing.Point(0, 274);
            this.flatButtonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButtonSearch.Name = "flatButtonSearch";
            this.flatButtonSearch.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.flatButtonSearch.Size = new System.Drawing.Size(255, 65);
            this.flatButtonSearch.TabIndex = 6;
            this.flatButtonSearch.Text = "Търсене";
            this.flatButtonSearch.UseVisualStyleBackColor = false;
            this.flatButtonSearch.Click += new System.EventHandler(this.flatButtonSearch_Click);
            // 
            // flatButtonCreareExpense
            // 
            this.flatButtonCreareExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.flatButtonCreareExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButtonCreareExpense.ForeColor = System.Drawing.Color.White;
            this.flatButtonCreareExpense.Location = new System.Drawing.Point(-1, 208);
            this.flatButtonCreareExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButtonCreareExpense.Name = "flatButtonCreareExpense";
            this.flatButtonCreareExpense.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.flatButtonCreareExpense.Size = new System.Drawing.Size(256, 65);
            this.flatButtonCreareExpense.TabIndex = 5;
            this.flatButtonCreareExpense.Text = "Добавяне на разход";
            this.flatButtonCreareExpense.UseVisualStyleBackColor = false;
            this.flatButtonCreareExpense.Click += new System.EventHandler(this.flatButtonCreareExpense_Click);
            // 
            // flatButtonCreateRevenue
            // 
            this.flatButtonCreateRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.flatButtonCreateRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButtonCreateRevenue.ForeColor = System.Drawing.Color.White;
            this.flatButtonCreateRevenue.Location = new System.Drawing.Point(-1, 142);
            this.flatButtonCreateRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButtonCreateRevenue.Name = "flatButtonCreateRevenue";
            this.flatButtonCreateRevenue.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.flatButtonCreateRevenue.Size = new System.Drawing.Size(256, 65);
            this.flatButtonCreateRevenue.TabIndex = 4;
            this.flatButtonCreateRevenue.Text = "Добавяне на приход";
            this.flatButtonCreateRevenue.UseVisualStyleBackColor = false;
            this.flatButtonCreateRevenue.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1040, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FlatButton flatButtonCreateRevenue;
        private FlatButton flatButtonCreareExpense;
        private FlatButton flatButtonStatistics;
        private FlatButton flatButtonSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

