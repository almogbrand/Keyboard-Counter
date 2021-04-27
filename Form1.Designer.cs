namespace keyboard
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
            this.components = new System.ComponentModel.Container();
            this.d_label = new System.Windows.Forms.Label();
            this.u_label = new System.Windows.Forms.Label();
            this.o_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.Approxnis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // d_label
            // 
            this.d_label.AutoSize = true;
            this.d_label.Location = new System.Drawing.Point(80, 32);
            this.d_label.Name = "d_label";
            this.d_label.Size = new System.Drawing.Size(13, 15);
            this.d_label.TabIndex = 0;
            this.d_label.Text = "0";
            // 
            // u_label
            // 
            this.u_label.AutoSize = true;
            this.u_label.Location = new System.Drawing.Point(192, 32);
            this.u_label.Name = "u_label";
            this.u_label.Size = new System.Drawing.Size(13, 15);
            this.u_label.TabIndex = 1;
            this.u_label.Text = "0";
            // 
            // o_label
            // 
            this.o_label.AutoSize = true;
            this.o_label.Location = new System.Drawing.Point(302, 32);
            this.o_label.Name = "o_label";
            this.o_label.Size = new System.Drawing.Size(13, 15);
            this.o_label.TabIndex = 2;
            this.o_label.Text = "0";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(104, 112);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(13, 15);
            this.total_label.TabIndex = 3;
            this.total_label.Text = "0";
            // 
            // Approxnis
            // 
            this.Approxnis.AutoSize = true;
            this.Approxnis.Location = new System.Drawing.Point(104, 153);
            this.Approxnis.Name = "Approxnis";
            this.Approxnis.Size = new System.Drawing.Size(13, 15);
            this.Approxnis.TabIndex = 4;
            this.Approxnis.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "D counter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "U counter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "O counter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total counter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Approx nis:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(149, 180);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 11;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(18, 180);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 12;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(120, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 215);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Approxnis);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.o_label);
            this.Controls.Add(this.u_label);
            this.Controls.Add(this.d_label);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Almog\'s counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label d_label;
        private System.Windows.Forms.Label u_label;
        private System.Windows.Forms.Label o_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label Approxnis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

