namespace nagad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.ComboBox();
            this.calc_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter resistor\'s colors in order:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::nagad.Properties.Resources.resistor;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // t1
            // 
            this.t1.FormattingEnabled = true;
            this.t1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.t1.Items.AddRange(new object[] {
            "BLACK",
            "BROWN",
            "RED",
            "ORANGE",
            "YELLOW",
            "GREEN",
            "BLUE",
            "VIOLET",
            "GREY",
            "WHITE"});
            this.t1.Location = new System.Drawing.Point(41, 149);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(121, 23);
            this.t1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "2:";
            // 
            // t2
            // 
            this.t2.FormattingEnabled = true;
            this.t2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.t2.Items.AddRange(new object[] {
            "BLACK",
            "BROWN",
            "RED",
            "ORANGE",
            "YELLOW",
            "GREEN",
            "BLUE",
            "VIOLET",
            "GREY",
            "WHITE"});
            this.t2.Location = new System.Drawing.Point(41, 178);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(121, 23);
            this.t2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "3:";
            // 
            // t3
            // 
            this.t3.FormattingEnabled = true;
            this.t3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.t3.Items.AddRange(new object[] {
            "BLACK",
            "BROWN",
            "RED",
            "ORANGE",
            "YELLOW",
            "GREEN",
            "BLUE",
            "VIOLET",
            "GREY",
            "WHITE",
            "GOLD",
            "SILVER"});
            this.t3.Location = new System.Drawing.Point(41, 207);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(121, 23);
            this.t3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "4:";
            // 
            // t4
            // 
            this.t4.FormattingEnabled = true;
            this.t4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.t4.Items.AddRange(new object[] {
            "BROWN",
            "RED",
            "ORANGE",
            "YELLOW",
            "GREEN",
            "BLUE",
            "VIOLET",
            "GREY",
            "GOLD",
            "SILVER"});
            this.t4.Location = new System.Drawing.Point(41, 236);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(121, 23);
            this.t4.TabIndex = 8;
            // 
            // calc_btn
            // 
            this.calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc_btn.Location = new System.Drawing.Point(26, 276);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(75, 23);
            this.calc_btn.TabIndex = 10;
            this.calc_btn.Text = "Calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 318);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Resistor color calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox t1;
        private Label label2;
        private Label label3;
        private ComboBox t2;
        private Label label4;
        private ComboBox t3;
        private Label label5;
        private ComboBox t4;
        private Button calc_btn;
    }
}