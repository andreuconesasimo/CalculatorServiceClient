namespace WindowsFormsCalcUsingService
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTcp = new System.Windows.Forms.RadioButton();
            this.rbHttp = new System.Windows.Forms.RadioButton();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btSuma = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btMultipl = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHttp);
            this.groupBox1.Controls.Add(this.rbTcp);
            this.groupBox1.Location = new System.Drawing.Point(107, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocol";
            // 
            // rbTcp
            // 
            this.rbTcp.AutoSize = true;
            this.rbTcp.Location = new System.Drawing.Point(17, 29);
            this.rbTcp.Name = "rbTcp";
            this.rbTcp.Size = new System.Drawing.Size(56, 21);
            this.rbTcp.TabIndex = 0;
            this.rbTcp.TabStop = true;
            this.rbTcp.Text = "TCP";
            this.rbTcp.UseVisualStyleBackColor = true;
            // 
            // rbHttp
            // 
            this.rbHttp.AutoSize = true;
            this.rbHttp.Location = new System.Drawing.Point(17, 65);
            this.rbHttp.Name = "rbHttp";
            this.rbHttp.Size = new System.Drawing.Size(66, 21);
            this.rbHttp.TabIndex = 1;
            this.rbHttp.TabStop = true;
            this.rbHttp.Text = "HTTP";
            this.rbHttp.UseVisualStyleBackColor = true;
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(111, 32);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 22);
            this.tbNum1.TabIndex = 1;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(111, 60);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 22);
            this.tbNum2.TabIndex = 2;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(111, 108);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 22);
            this.tbTotal.TabIndex = 3;
            // 
            // btSuma
            // 
            this.btSuma.Location = new System.Drawing.Point(251, 132);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(30, 30);
            this.btSuma.TabIndex = 4;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btResta
            // 
            this.btResta.Location = new System.Drawing.Point(251, 96);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(30, 30);
            this.btResta.TabIndex = 5;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // btMultipl
            // 
            this.btMultipl.Location = new System.Drawing.Point(251, 60);
            this.btMultipl.Name = "btMultipl";
            this.btMultipl.Size = new System.Drawing.Size(30, 30);
            this.btMultipl.TabIndex = 6;
            this.btMultipl.Text = "x";
            this.btMultipl.UseVisualStyleBackColor = true;
            this.btMultipl.Click += new System.EventHandler(this.btMultipl_Click);
            // 
            // btDivision
            // 
            this.btDivision.Location = new System.Drawing.Point(251, 24);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(30, 30);
            this.btDivision.TabIndex = 7;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 275);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btMultipl);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHttp;
        private System.Windows.Forms.RadioButton rbTcp;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btMultipl;
        private System.Windows.Forms.Button btDivision;
    }
}

