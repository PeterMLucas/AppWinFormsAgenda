namespace AppWinFormsAgenda
{
    partial class MsgBox
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
            this.MsgTxt1 = new System.Windows.Forms.Label();
            this.MsgQuestion = new System.Windows.Forms.PictureBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MsgQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgTxt1
            // 
            this.MsgTxt1.AutoSize = true;
            this.MsgTxt1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgTxt1.Location = new System.Drawing.Point(85, 23);
            this.MsgTxt1.Name = "MsgTxt1";
            this.MsgTxt1.Size = new System.Drawing.Size(227, 27);
            this.MsgTxt1.TabIndex = 2;
            this.MsgTxt1.Text = "¿Estás seguro de salir?";
            // 
            // MsgQuestion
            // 
            this.MsgQuestion.Image = global::AppWinFormsAgenda.Properties.Resources.informacion;
            this.MsgQuestion.Location = new System.Drawing.Point(15, 13);
            this.MsgQuestion.Name = "MsgQuestion";
            this.MsgQuestion.Size = new System.Drawing.Size(64, 43);
            this.MsgQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MsgQuestion.TabIndex = 4;
            this.MsgQuestion.TabStop = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAceptar.Location = new System.Drawing.Point(90, 110);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(86, 34);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            this.BtnAceptar.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.BtnAceptar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(188, 110);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(93, 34);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.BtnCancelar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 156);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.MsgQuestion);
            this.Controls.Add(this.MsgTxt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            ((System.ComponentModel.ISupportInitialize)(this.MsgQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MsgTxt1;
        private System.Windows.Forms.PictureBox MsgQuestion;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}