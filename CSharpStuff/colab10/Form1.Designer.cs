namespace colab10
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.labelAluno = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aluno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Média";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(19, 104);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(216, 23);
            this.button.TabIndex = 6;
            this.button.Text = "Calcular média";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(57, 29);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(178, 20);
            this.textNome.TabIndex = 7;
            // 
            // textNota1
            // 
            this.textNota1.Location = new System.Drawing.Point(19, 78);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(36, 20);
            this.textNota1.TabIndex = 8;
            // 
            // textNota2
            // 
            this.textNota2.Location = new System.Drawing.Point(105, 79);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(36, 20);
            this.textNota2.TabIndex = 13;
            // 
            // textNota3
            // 
            this.textNota3.Location = new System.Drawing.Point(199, 79);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(36, 20);
            this.textNota3.TabIndex = 14;
            // 
            // labelAluno
            // 
            this.labelAluno.BackColor = System.Drawing.Color.Red;
            this.labelAluno.Location = new System.Drawing.Point(76, 130);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(159, 13);
            this.labelAluno.TabIndex = 15;
            this.labelAluno.Text = "     ";
            // 
            // labelMedia
            // 
            this.labelMedia.BackColor = System.Drawing.Color.Red;
            this.labelMedia.ForeColor = System.Drawing.Color.Black;
            this.labelMedia.Location = new System.Drawing.Point(76, 155);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(159, 13);
            this.labelMedia.TabIndex = 16;
            this.labelMedia.Text = "     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 178);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.labelAluno);
            this.Controls.Add(this.textNota3);
            this.Controls.Add(this.textNota2);
            this.Controls.Add(this.textNota1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Forum Ag 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.Label labelMedia;
    }
}

