
namespace Framework_Test
{
    partial class LogInForm
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
            if (disposing && (components != null)) {
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
            this.AcceptBut = new System.Windows.Forms.Button();
            this.ResetBut = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptBut
            // 
            this.AcceptBut.Location = new System.Drawing.Point(178, 220);
            this.AcceptBut.Name = "AcceptBut";
            this.AcceptBut.Size = new System.Drawing.Size(75, 23);
            this.AcceptBut.TabIndex = 3;
            this.AcceptBut.Text = "登录";
            this.AcceptBut.UseVisualStyleBackColor = true;
            this.AcceptBut.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResetBut
            // 
            this.ResetBut.Location = new System.Drawing.Point(30, 220);
            this.ResetBut.Name = "ResetBut";
            this.ResetBut.Size = new System.Drawing.Size(75, 23);
            this.ResetBut.TabIndex = 4;
            this.ResetBut.Text = "重置";
            this.ResetBut.UseVisualStyleBackColor = true;
            this.ResetBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(174, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(69, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "登录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名";
            // 
            // LogInForm
            // 
            this.AcceptButton = this.AcceptBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 274);
            this.Controls.Add(this.AcceptBut);
            this.Controls.Add(this.ResetBut);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LogInForm";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptBut;
        private System.Windows.Forms.Button ResetBut;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}