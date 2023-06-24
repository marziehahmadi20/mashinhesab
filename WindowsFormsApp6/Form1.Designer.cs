namespace WindowsFormsApp6
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
            this.txtop = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtop
            // 
            this.txtop.BackColor = System.Drawing.SystemColors.Info;
            this.txtop.Location = new System.Drawing.Point(104, 57);
            this.txtop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtop.Name = "txtop";
            this.txtop.Size = new System.Drawing.Size(43, 26);
            this.txtop.TabIndex = 0;
            this.txtop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtop.TextChanged += new System.EventHandler(this.txtop_TextChanged);
            // 
            // txtnum1
            // 
            this.txtnum1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtnum1.Location = new System.Drawing.Point(14, 57);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(69, 26);
            this.txtnum1.TabIndex = 1;
            this.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum2
            // 
            this.txtnum2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtnum2.Location = new System.Drawing.Point(176, 57);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(70, 26);
            this.txtnum2.TabIndex = 2;
            this.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(283, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblresult
            // 
            this.lblresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblresult.Location = new System.Drawing.Point(358, 60);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(85, 26);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "Result";
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            this.lblresult.MouseLeave += new System.EventHandler(this.lblresult_MouseLeave);
            this.lblresult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblresult_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(26, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(26, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(26, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Culculate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(529, 257);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txtop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "mashin hesab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtop;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

