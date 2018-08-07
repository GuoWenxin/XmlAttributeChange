namespace XmlAttributeChange
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbXmlPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXmlAttribute = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbyu = new System.Windows.Forms.RadioButton();
            this.rbchu = new System.Windows.Forms.RadioButton();
            this.rbcheng = new System.Windows.Forms.RadioButton();
            this.rbjian = new System.Windows.Forms.RadioButton();
            this.rbjia = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbparams = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRootName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择文件位置：";
            // 
            // tbXmlPath
            // 
            this.tbXmlPath.Location = new System.Drawing.Point(257, 26);
            this.tbXmlPath.Name = "tbXmlPath";
            this.tbXmlPath.Size = new System.Drawing.Size(381, 21);
            this.tbXmlPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输入需要修改的属性（分号隔开）：";
            // 
            // tbXmlAttribute
            // 
            this.tbXmlAttribute.Location = new System.Drawing.Point(257, 66);
            this.tbXmlAttribute.Name = "tbXmlAttribute";
            this.tbXmlAttribute.Size = new System.Drawing.Size(381, 21);
            this.tbXmlAttribute.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbyu);
            this.groupBox1.Controls.Add(this.rbchu);
            this.groupBox1.Controls.Add(this.rbcheng);
            this.groupBox1.Controls.Add(this.rbjian);
            this.groupBox1.Controls.Add(this.rbjia);
            this.groupBox1.Location = new System.Drawing.Point(67, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择需要的操作";
            // 
            // rbyu
            // 
            this.rbyu.AutoSize = true;
            this.rbyu.Location = new System.Drawing.Point(526, 31);
            this.rbyu.Name = "rbyu";
            this.rbyu.Size = new System.Drawing.Size(29, 16);
            this.rbyu.TabIndex = 4;
            this.rbyu.TabStop = true;
            this.rbyu.Text = "%";
            this.rbyu.UseVisualStyleBackColor = true;
            // 
            // rbchu
            // 
            this.rbchu.AutoSize = true;
            this.rbchu.Location = new System.Drawing.Point(378, 31);
            this.rbchu.Name = "rbchu";
            this.rbchu.Size = new System.Drawing.Size(29, 16);
            this.rbchu.TabIndex = 3;
            this.rbchu.TabStop = true;
            this.rbchu.Text = "/";
            this.rbchu.UseVisualStyleBackColor = true;
            // 
            // rbcheng
            // 
            this.rbcheng.AutoSize = true;
            this.rbcheng.Location = new System.Drawing.Point(236, 31);
            this.rbcheng.Name = "rbcheng";
            this.rbcheng.Size = new System.Drawing.Size(29, 16);
            this.rbcheng.TabIndex = 2;
            this.rbcheng.TabStop = true;
            this.rbcheng.Text = "*";
            this.rbcheng.UseVisualStyleBackColor = true;
            // 
            // rbjian
            // 
            this.rbjian.AutoSize = true;
            this.rbjian.Location = new System.Drawing.Point(129, 31);
            this.rbjian.Name = "rbjian";
            this.rbjian.Size = new System.Drawing.Size(29, 16);
            this.rbjian.TabIndex = 1;
            this.rbjian.TabStop = true;
            this.rbjian.Text = "-";
            this.rbjian.UseVisualStyleBackColor = true;
            // 
            // rbjia
            // 
            this.rbjia.AutoSize = true;
            this.rbjia.Location = new System.Drawing.Point(17, 31);
            this.rbjia.Name = "rbjia";
            this.rbjia.Size = new System.Drawing.Size(29, 16);
            this.rbjia.TabIndex = 0;
            this.rbjia.TabStop = true;
            this.rbjia.Text = "+";
            this.rbjia.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "输入参数：";
            // 
            // tbparams
            // 
            this.tbparams.Location = new System.Drawing.Point(257, 216);
            this.tbparams.Name = "tbparams";
            this.tbparams.Size = new System.Drawing.Size(381, 21);
            this.tbparams.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "取整方式：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "不取整",
            "向上取整",
            "向下取整",
            "四舍五入"});
            this.comboBox1.Location = new System.Drawing.Point(257, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "不取整";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "根节点名：";
            // 
            // tbRootName
            // 
            this.tbRootName.Location = new System.Drawing.Point(257, 100);
            this.tbRootName.Name = "tbRootName";
            this.tbRootName.Size = new System.Drawing.Size(381, 21);
            this.tbRootName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 344);
            this.Controls.Add(this.tbRootName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbparams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbXmlAttribute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbXmlPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbXmlPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbXmlAttribute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbyu;
        private System.Windows.Forms.RadioButton rbchu;
        private System.Windows.Forms.RadioButton rbcheng;
        private System.Windows.Forms.RadioButton rbjian;
        private System.Windows.Forms.RadioButton rbjia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbparams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRootName;
    }
}

