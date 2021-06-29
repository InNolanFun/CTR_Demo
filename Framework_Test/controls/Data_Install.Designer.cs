
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.works = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkmessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.Remarks_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Production_capacity_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.length_of_work_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workshop_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Work_content_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Name_comBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(295, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(664, 316);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除行ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 删除行ToolStripMenuItem
            // 
            this.删除行ToolStripMenuItem.Name = "删除行ToolStripMenuItem";
            this.删除行ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.删除行ToolStripMenuItem.Text = "删除行";
            this.删除行ToolStripMenuItem.Click += new System.EventHandler(this.删除行ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
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
            this.tableLayoutPanel1.Controls.Add(this.Remarks_textBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Production_capacity_textBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.length_of_work_textBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.workshop_textBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Work_content_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Name_comBox, 1, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 271);
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
            // Remarks_textBox
            // 
            this.Remarks_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remarks_textBox.Location = new System.Drawing.Point(83, 228);
            this.Remarks_textBox.Multiline = true;
            this.Remarks_textBox.Name = "Remarks_textBox";
            this.Remarks_textBox.Size = new System.Drawing.Size(209, 40);
            this.Remarks_textBox.TabIndex = 13;
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
            // Production_capacity_textBox
            // 
            this.Production_capacity_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Production_capacity_textBox.Location = new System.Drawing.Point(83, 183);
            this.Production_capacity_textBox.Name = "Production_capacity_textBox";
            this.Production_capacity_textBox.Size = new System.Drawing.Size(209, 21);
            this.Production_capacity_textBox.TabIndex = 11;
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
            // length_of_work_textBox
            // 
            this.length_of_work_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.length_of_work_textBox.Location = new System.Drawing.Point(83, 138);
            this.length_of_work_textBox.Name = "length_of_work_textBox";
            this.length_of_work_textBox.Size = new System.Drawing.Size(209, 21);
            this.length_of_work_textBox.TabIndex = 9;
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
            // workshop_textBox
            // 
            this.workshop_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workshop_textBox.Location = new System.Drawing.Point(83, 93);
            this.workshop_textBox.Name = "workshop_textBox";
            this.workshop_textBox.ReadOnly = true;
            this.workshop_textBox.Size = new System.Drawing.Size(209, 21);
            this.workshop_textBox.TabIndex = 7;
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
            // Work_content_textBox
            // 
            this.Work_content_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Work_content_textBox.Location = new System.Drawing.Point(83, 48);
            this.Work_content_textBox.Name = "Work_content_textBox";
            this.Work_content_textBox.Size = new System.Drawing.Size(209, 21);
            this.Work_content_textBox.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 45);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(81, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "从Excel导入";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Name_comBox
            // 
            this.Name_comBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_comBox.FormattingEnabled = true;
            this.Name_comBox.Location = new System.Drawing.Point(83, 3);
            this.Name_comBox.Name = "Name_comBox";
            this.Name_comBox.Size = new System.Drawing.Size(209, 20);
            this.Name_comBox.TabIndex = 14;
            this.Name_comBox.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            this.Name_comBox.TextChanged += new System.EventHandler(this.Name_comBox_TextChanged);
            // 
            // Data_Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Data_Install";
            this.Size = new System.Drawing.Size(959, 316);
            this.Load += new System.EventHandler(this.Data_Install_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox Remarks_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Production_capacity_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox length_of_work_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workshop_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Work_content_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除行ToolStripMenuItem;
        private System.Windows.Forms.ComboBox Name_comBox;
    }
}
