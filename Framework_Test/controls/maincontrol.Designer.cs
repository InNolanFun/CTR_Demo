namespace Framework_Test.controls
{
    partial class maincontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.show_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(523, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "关闭页签";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_tableLayoutPanel
            // 
            this.show_tableLayoutPanel.ColumnCount = 1;
            this.show_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.show_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.show_tableLayoutPanel.Name = "show_tableLayoutPanel";
            this.show_tableLayoutPanel.RowCount = 1;
            this.show_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.show_tableLayoutPanel.Size = new System.Drawing.Size(587, 396);
            this.show_tableLayoutPanel.TabIndex = 2;
            // 
            // maincontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_tableLayoutPanel);
            this.Name = "maincontrol";
            this.Size = new System.Drawing.Size(587, 396);
            this.Load += new System.EventHandler(this.maincontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel show_tableLayoutPanel;
    }
}

