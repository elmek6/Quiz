namespace quiz1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAnt = new System.Windows.Forms.Label();
            this.chkAnt = new System.Windows.Forms.CheckBox();
            this.cboXMLFile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.scrBarH = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFrage = new System.Windows.Forms.TextBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAnt
            // 
            this.lblAnt.AutoEllipsis = true;
            this.lblAnt.Location = new System.Drawing.Point(111, 15);
            this.lblAnt.Name = "lblAnt";
            this.lblAnt.Size = new System.Drawing.Size(553, 49);
            this.lblAnt.TabIndex = 10;
            this.lblAnt.Text = "antworten";
            this.lblAnt.Visible = false;
            // 
            // chkAnt
            // 
            this.chkAnt.AutoSize = true;
            this.chkAnt.Location = new System.Drawing.Point(13, 15);
            this.chkAnt.Name = "chkAnt";
            this.chkAnt.Size = new System.Drawing.Size(59, 17);
            this.chkAnt.TabIndex = 17;
            this.chkAnt.Text = "Always";
            this.chkAnt.UseVisualStyleBackColor = true;
            this.chkAnt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cboXMLFile
            // 
            this.cboXMLFile.FormattingEnabled = true;
            this.cboXMLFile.Items.AddRange(new object[] {
            "quiz1en.xml",
            "quiz2en.xml",
            "quiz3en.xml",
            "quiz4en.xml",
            "quiz5en.xml",
            "quiz6en.xml"});
            this.cboXMLFile.Location = new System.Drawing.Point(6, 43);
            this.cboXMLFile.Name = "cboXMLFile";
            this.cboXMLFile.Size = new System.Drawing.Size(128, 21);
            this.cboXMLFile.TabIndex = 23;
            this.cboXMLFile.SelectedIndexChanged += new System.EventHandler(this.cboXMLFile_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Choose the question book";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Answer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // scrBarH
            // 
            this.scrBarH.Location = new System.Drawing.Point(11, 19);
            this.scrBarH.Name = "scrBarH";
            this.scrBarH.Size = new System.Drawing.Size(247, 18);
            this.scrBarH.TabIndex = 28;
            this.scrBarH.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrBarH_Scroll);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.scrBarH);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(162, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 73);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cboXMLFile);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 73);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.chkAnt);
            this.panel3.Controls.Add(this.lblAnt);
            this.panel3.Location = new System.Drawing.Point(452, 565);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 73);
            this.panel3.TabIndex = 31;
            // 
            // txtFrage
            // 
            this.txtFrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrage.Location = new System.Drawing.Point(2, 12);
            this.txtFrage.Multiline = true;
            this.txtFrage.Name = "txtFrage";
            this.txtFrage.Size = new System.Drawing.Size(1124, 514);
            this.txtFrage.TabIndex = 32;
            this.txtFrage.Text = "a\r\nb\r\nc";
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(452, 532);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(33, 17);
            this.checkBox0.TabIndex = 33;
            this.checkBox0.Text = "A";
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(526, 532);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(33, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "B";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(602, 532);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(33, 17);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "C";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(680, 532);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(34, 17);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "D";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(755, 532);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(33, 17);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.Text = "E";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(832, 532);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 38;
            this.checkBox5.Text = "F";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 644);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox0);
            this.Controls.Add(this.txtFrage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Programmer Övünc Mete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAnt;
        private System.Windows.Forms.CheckBox chkAnt;
        private System.Windows.Forms.ComboBox cboXMLFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HScrollBar scrBarH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFrage;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

