
namespace Framework_Test.controls
{
    partial class Data_Install
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.works = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkmessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProduction_capacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxlength_of_work = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxworkshop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWork_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.workc,
            this.workl,
            this.works,
            this.productionc,
            this.remarkmessage});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(295, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(381, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // username
            // 
            this.username.Frozen = true;
            this.username.HeaderText = "姓名";
            this.username.Name = "username";
            // 
            // workc
            // 
            this.workc.HeaderText = "工作内容";
            this.workc.Name = "workc";
            // 
            // workl
            // 
            this.workl.HeaderText = "工作时间";
            this.workl.Name = "workl";
            // 
            // works
            // 
            this.works.HeaderText = "车间";
            this.works.Name = "works";
            // 
            // productionc
            // 
            this.productionc.HeaderText = "产能";
            this.productionc.Name = "productionc";
            // 
            // remarkmessage
            // 
            this.remarkmessage.HeaderText = "备注";
            this.remarkmessage.Name = "remarkmessage";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 316);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRemarks, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProduction_capacity, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxlength_of_work, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxworkshop, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWork_content, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 270);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "备注";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRemarks.Location = new System.Drawing.Point(83, 228);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(209, 39);
            this.textBoxRemarks.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "产能";
            // 
            // textBoxProduction_capacity
            // 
            this.textBoxProduction_capacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProduction_capacity.Location = new System.Drawing.Point(83, 183);
            this.textBoxProduction_capacity.Name = "textBoxProduction_capacity";
            this.textBoxProduction_capacity.Size = new System.Drawing.Size(209, 21);
            this.textBoxProduction_capacity.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "工作时间";
            // 
            // textBoxlength_of_work
            // 
            this.textBoxlength_of_work.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxlength_of_work.Location = new System.Drawing.Point(83, 138);
            this.textBoxlength_of_work.Name = "textBoxlength_of_work";
            this.textBoxlength_of_work.Size = new System.Drawing.Size(209, 21);
            this.textBoxlength_of_work.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "车间";
            // 
            // textBoxworkshop
            // 
            this.textBoxworkshop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxworkshop.Location = new System.Drawing.Point(83, 93);
            this.textBoxworkshop.Name = "textBoxworkshop";
            this.textBoxworkshop.Size = new System.Drawing.Size(209, 21);
            this.textBoxworkshop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "工作内容";
            // 
            // textBoxWork_content
            // 
            this.textBoxWork_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWork_content.Location = new System.Drawing.Point(83, 48);
            this.textBoxWork_content.Name = "textBoxWork_content";
            this.textBoxWork_content.Size = new System.Drawing.Size(209, 21);
            this.textBoxWork_content.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(83, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(209, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data_Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Data_Install";
            this.Size = new System.Drawing.Size(676, 316);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn workc;
        private System.Windows.Forms.DataGridViewTextBoxColumn workl;
        private System.Windows.Forms.DataGridViewTextBoxColumn works;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionc;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkmessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProduction_capacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxlength_of_work;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxworkshop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWork_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button1;
    }
}
