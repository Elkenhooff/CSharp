﻿namespace ListasdeTarefas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnCadastros = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastros.BackgroundImage")));
            this.btnCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastros.Location = new System.Drawing.Point(12, 222);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(225, 225);
            this.btnCadastros.TabIndex = 0;
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.BackColor = System.Drawing.Color.Transparent;
            this.btnTarefas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTarefas.BackgroundImage")));
            this.btnTarefas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTarefas.Location = new System.Drawing.Point(474, 222);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(225, 225);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.UseVisualStyleBackColor = false;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFunc.BackgroundImage")));
            this.btnFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFunc.Location = new System.Drawing.Point(243, 222);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(225, 225);
            this.btnFunc.TabIndex = 3;
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 484);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnCadastros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastros;
        private Button btnTarefas;
        private Label label1;
        private Button btnFunc;
    }
}