namespace graf
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
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_rr = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(13, 43);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(56, 20);
            this.textBox_N.TabIndex = 0;
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(75, 43);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(56, 20);
            this.textBox_R.TabIndex = 1;
            // 
            // textBox_rr
            // 
            this.textBox_rr.Location = new System.Drawing.Point(137, 43);
            this.textBox_rr.Name = "textBox_rr";
            this.textBox_rr.Size = new System.Drawing.Size(56, 20);
            this.textBox_rr.TabIndex = 2;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(200, 43);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(13, 24);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(15, 13);
            this.N.TabIndex = 4;
            this.N.Text = "N";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "r";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 540);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(281, 43);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 8;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(363, 43);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_rr);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.textBox_N);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_rr;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

