﻿namespace ControleEstacionamento.Visao.Ocupa
{
    partial class FormOcupaFechamento
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
            this.components = new System.ComponentModel.Container();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblVaga = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tmHoraEntrada = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(23, 81);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(47, 13);
            this.lblVeiculo.TabIndex = 0;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // lblVaga
            // 
            this.lblVaga.AutoSize = true;
            this.lblVaga.Location = new System.Drawing.Point(23, 123);
            this.lblVaga.Name = "lblVaga";
            this.lblVaga.Size = new System.Drawing.Size(35, 13);
            this.lblVaga.TabIndex = 1;
            this.lblVaga.Text = "Vaga:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(141, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Lançar veículo na vaga";
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(493, 16);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFuncionario.TabIndex = 12;
            this.btnSalvarFuncionario.Text = "Salvar";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
            this.btnSalvarFuncionario.Click += new System.EventHandler(this.btnSalvarFuncionario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(574, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ptbLogo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 89);
            this.panel1.TabIndex = 14;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Location = new System.Drawing.Point(12, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(100, 59);
            this.ptbLogo.TabIndex = 6;
            this.ptbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 242);
            this.panel2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblVeiculo);
            this.groupBox1.Controls.Add(this.lblVaga);
            this.groupBox1.Location = new System.Drawing.Point(110, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "dd/MM/yyyy HH:mm:ss";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hora atual";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnSalvarFuncionario);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 51);
            this.panel3.TabIndex = 16;
            // 
            // tmHoraEntrada
            // 
            this.tmHoraEntrada.Enabled = true;
            this.tmHoraEntrada.Interval = 1000;
            this.tmHoraEntrada.Tick += new System.EventHandler(this.tmHoraEntrada_Tick);
            // 
            // FormOcupaFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 331);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOcupaFechamento";
            this.Text = "Cadastro Ocupa";
            this.Load += new System.EventHandler(this.FormFuncionarioCrud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblVaga;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvarFuncionario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmHoraEntrada;
    }
}