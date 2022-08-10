
namespace Laboratorio
{
    partial class MenuL
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
            this.btnRegistroExam = new System.Windows.Forms.Button();
            this.btnAtencionNacio = new System.Windows.Forms.Button();
            this.btnRegistroPaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "LABORATORIO MÉDICO HERMANOS CAMPUZANO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistroExam
            // 
            this.btnRegistroExam.Location = new System.Drawing.Point(348, 228);
            this.btnRegistroExam.Name = "btnRegistroExam";
            this.btnRegistroExam.Size = new System.Drawing.Size(106, 60);
            this.btnRegistroExam.TabIndex = 6;
            this.btnRegistroExam.Text = "Registro del examen";
            this.btnRegistroExam.UseVisualStyleBackColor = true;
            this.btnRegistroExam.Click += new System.EventHandler(this.btnRegistroExam_Click);
            // 
            // btnAtencionNacio
            // 
            this.btnAtencionNacio.Location = new System.Drawing.Point(484, 117);
            this.btnAtencionNacio.Name = "btnAtencionNacio";
            this.btnAtencionNacio.Size = new System.Drawing.Size(104, 53);
            this.btnAtencionNacio.TabIndex = 5;
            this.btnAtencionNacio.Text = "Atención Nacional";
            this.btnAtencionNacio.UseVisualStyleBackColor = true;
            this.btnAtencionNacio.Click += new System.EventHandler(this.btnAtencionNacio_Click);
            // 
            // btnRegistroPaci
            // 
            this.btnRegistroPaci.Location = new System.Drawing.Point(206, 117);
            this.btnRegistroPaci.Name = "btnRegistroPaci";
            this.btnRegistroPaci.Size = new System.Drawing.Size(102, 53);
            this.btnRegistroPaci.TabIndex = 4;
            this.btnRegistroPaci.Text = "Registro de pacientes";
            this.btnRegistroPaci.UseVisualStyleBackColor = true;
            this.btnRegistroPaci.Click += new System.EventHandler(this.btnRegistroPaci_Click);
            // 
            // MenuL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistroExam);
            this.Controls.Add(this.btnAtencionNacio);
            this.Controls.Add(this.btnRegistroPaci);
            this.Name = "MenuL";
            this.Text = "MenuL";
            this.Load += new System.EventHandler(this.MenuL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroExam;
        private System.Windows.Forms.Button btnAtencionNacio;
        private System.Windows.Forms.Button btnRegistroPaci;
    }
}