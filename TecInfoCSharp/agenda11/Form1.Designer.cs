namespace agenda11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBruto = new System.Windows.Forms.TextBox();
            this.textLiquido = new System.Windows.Forms.TextBox();
            this.butCalc = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.textDireito = new System.Windows.Forms.TextBox();
            this.comCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o nome do funcionário:";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cálculo do salário líquido do funcionário";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBruto);
            this.panel1.Controls.Add(this.textLiquido);
            this.panel1.Controls.Add(this.butCalc);
            this.panel1.Location = new System.Drawing.Point(12, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 51);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salário liquido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salário bruto:";
            // 
            // textBruto
            // 
            this.textBruto.Location = new System.Drawing.Point(103, 14);
            this.textBruto.Name = "textBruto";
            this.textBruto.Size = new System.Drawing.Size(73, 20);
            this.textBruto.TabIndex = 2;
            // 
            // textLiquido
            // 
            this.textLiquido.Enabled = false;
            this.textLiquido.Location = new System.Drawing.Point(354, 14);
            this.textLiquido.Name = "textLiquido";
            this.textLiquido.Size = new System.Drawing.Size(92, 20);
            this.textLiquido.TabIndex = 1;
            // 
            // butCalc
            // 
            this.butCalc.Location = new System.Drawing.Point(185, 12);
            this.butCalc.Name = "butCalc";
            this.butCalc.Size = new System.Drawing.Size(55, 23);
            this.butCalc.TabIndex = 0;
            this.butCalc.Text = "Calcular";
            this.butCalc.UseVisualStyleBackColor = true;
            this.butCalc.Click += new System.EventHandler(this.butCalc_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(12, 246);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 4;
            this.butClear.Text = "Limpar";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(386, 246);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 5;
            this.butExit.Text = "Sair";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // textDireito
            // 
            this.textDireito.Enabled = false;
            this.textDireito.Location = new System.Drawing.Point(15, 146);
            this.textDireito.Name = "textDireito";
            this.textDireito.Size = new System.Drawing.Size(446, 20);
            this.textDireito.TabIndex = 6;
            // 
            // comCargo
            // 
            this.comCargo.FormattingEnabled = true;
            this.comCargo.Items.AddRange(new object[] {
            "Diretoria",
            "Gerência",
            "Serviços Gerais"});
            this.comCargo.Location = new System.Drawing.Point(67, 89);
            this.comCargo.Name = "comCargo";
            this.comCargo.Size = new System.Drawing.Size(121, 21);
            this.comCargo.TabIndex = 7;
            this.comCargo.SelectedIndexChanged += new System.EventHandler(this.comCargo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direitos do funcionário:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(12, 51);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(446, 20);
            this.textNome.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 275);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comCargo);
            this.Controls.Add(this.textDireito);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Calculo salarial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butCalc;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBruto;
        private System.Windows.Forms.TextBox textLiquido;
        private System.Windows.Forms.TextBox textDireito;
        private System.Windows.Forms.ComboBox comCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNome;
    }
}

