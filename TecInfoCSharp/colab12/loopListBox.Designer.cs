namespace Agenda12_forum_loopListBox_plus_trap
{
    partial class loopListBox
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lstConv = new System.Windows.Forms.ListBox();
            this.lstConf = new System.Windows.Forms.ListBox();
            this.btnP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(40, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 52);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lstConv
            // 
            this.lstConv.FormattingEnabled = true;
            this.lstConv.Location = new System.Drawing.Point(40, 92);
            this.lstConv.Name = "lstConv";
            this.lstConv.Size = new System.Drawing.Size(140, 121);
            this.lstConv.TabIndex = 3;
            // 
            // lstConf
            // 
            this.lstConf.FormattingEnabled = true;
            this.lstConf.Location = new System.Drawing.Point(273, 92);
            this.lstConf.Name = "lstConf";
            this.lstConf.Size = new System.Drawing.Size(140, 121);
            this.lstConf.TabIndex = 4;
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(197, 143);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(60, 23);
            this.btnP.TabIndex = 5;
            this.btnP.Text = ">>";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // loopListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 251);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.lstConf);
            this.Controls.Add(this.lstConv);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "loopListBox";
            this.Text = "why";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loopListBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox lstConv;
        private System.Windows.Forms.ListBox lstConf;
        private System.Windows.Forms.Button btnP;
    }
}