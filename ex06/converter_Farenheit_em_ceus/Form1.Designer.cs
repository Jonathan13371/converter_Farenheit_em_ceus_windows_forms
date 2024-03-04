
namespace ex06
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
            this.bntConversor = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.textFarenheit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntConversor
            // 
            this.bntConversor.Location = new System.Drawing.Point(306, 158);
            this.bntConversor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntConversor.Name = "bntConversor";
            this.bntConversor.Size = new System.Drawing.Size(248, 66);
            this.bntConversor.TabIndex = 0;
            this.bntConversor.Text = "Converter Temperatura";
            this.bntConversor.UseVisualStyleBackColor = true;
            this.bntConversor.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(211, 114);
            this.lblTemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(195, 16);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Temperatura em Farenheit:";
            this.lblTemperatura.Click += new System.EventHandler(this.label1_Click);
            // 
            // textFarenheit
            // 
            this.textFarenheit.Location = new System.Drawing.Point(414, 109);
            this.textFarenheit.Name = "textFarenheit";
            this.textFarenheit.Size = new System.Drawing.Size(174, 22);
            this.textFarenheit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura em Celsius:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(402, 283);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 16);
            this.lblSaida.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(852, 346);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFarenheit);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.bntConversor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntConversor;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox textFarenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaida;
    }
}

