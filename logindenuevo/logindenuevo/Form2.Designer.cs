namespace logindenuevo
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCS = new System.Windows.Forms.CheckBox();
            this.cBB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rBTC = new System.Windows.Forms.RadioButton();
            this.PayPal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos en Venta";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(311, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de Pago";
            // 
            // cBCS
            // 
            this.cBCS.AutoSize = true;
            this.cBCS.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCS.Location = new System.Drawing.Point(57, 131);
            this.cBCS.Name = "cBCS";
            this.cBCS.Size = new System.Drawing.Size(107, 22);
            this.cBCS.TabIndex = 2;
            this.cBCS.Text = "VisualC#";
            this.cBCS.UseVisualStyleBackColor = true;
            // 
            // cBB
            // 
            this.cBB.AutoSize = true;
            this.cBB.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBB.Location = new System.Drawing.Point(57, 203);
            this.cBB.Name = "cBB";
            this.cBB.Size = new System.Drawing.Size(147, 22);
            this.cBB.TabIndex = 3;
            this.cBB.Text = "Visual Basic";
            this.cBB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(316, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // rBTC
            // 
            this.rBTC.AutoSize = true;
            this.rBTC.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBTC.Location = new System.Drawing.Point(314, 133);
            this.rBTC.Name = "rBTC";
            this.rBTC.Size = new System.Drawing.Size(187, 34);
            this.rBTC.TabIndex = 8;
            this.rBTC.TabStop = true;
            this.rBTC.Text = "Tarjeta de Crédito";
            this.rBTC.UseVisualStyleBackColor = true;
            // 
            // PayPal
            // 
            this.PayPal.AutoSize = true;
            this.PayPal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayPal.Location = new System.Drawing.Point(316, 208);
            this.PayPal.Name = "PayPal";
            this.PayPal.Size = new System.Drawing.Size(187, 34);
            this.PayPal.TabIndex = 9;
            this.PayPal.TabStop = true;
            this.PayPal.Text = "Tarjeta de Crédito";
            this.PayPal.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(591, 566);
            this.Controls.Add(this.PayPal);
            this.Controls.Add(this.rBTC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBB);
            this.Controls.Add(this.cBCS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBCS;
        private System.Windows.Forms.CheckBox cBB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rBTC;
        private System.Windows.Forms.RadioButton PayPal;
    }
}