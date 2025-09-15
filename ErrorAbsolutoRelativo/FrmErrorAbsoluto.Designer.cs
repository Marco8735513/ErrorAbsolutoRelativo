namespace ErrorAbsolutoRelativo
{
    partial class FrmErrorAbsoluto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErrorAbsoluto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorAbsoluto = new System.Windows.Forms.Label();
            this.lblErrorRelativo = new System.Windows.Forms.Label();
            this.txtValorVerdadero = new System.Windows.Forms.TextBox();
            this.txtValorAproximado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el Valor Verdadero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el Valor Aproximado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Error Absoluto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Error Relativo";
            // 
            // lblErrorAbsoluto
            // 
            this.lblErrorAbsoluto.AutoSize = true;
            this.lblErrorAbsoluto.Location = new System.Drawing.Point(571, 168);
            this.lblErrorAbsoluto.Name = "lblErrorAbsoluto";
            this.lblErrorAbsoluto.Size = new System.Drawing.Size(25, 16);
            this.lblErrorAbsoluto.TabIndex = 5;
            this.lblErrorAbsoluto.Text = "- - -";
            // 
            // lblErrorRelativo
            // 
            this.lblErrorRelativo.AutoSize = true;
            this.lblErrorRelativo.Location = new System.Drawing.Point(571, 233);
            this.lblErrorRelativo.Name = "lblErrorRelativo";
            this.lblErrorRelativo.Size = new System.Drawing.Size(25, 16);
            this.lblErrorRelativo.TabIndex = 6;
            this.lblErrorRelativo.Text = "- - -";
            // 
            // txtValorVerdadero
            // 
            this.txtValorVerdadero.Location = new System.Drawing.Point(59, 145);
            this.txtValorVerdadero.Name = "txtValorVerdadero";
            this.txtValorVerdadero.Size = new System.Drawing.Size(230, 22);
            this.txtValorVerdadero.TabIndex = 7;
            // 
            // txtValorAproximado
            // 
            this.txtValorAproximado.Location = new System.Drawing.Point(59, 237);
            this.txtValorAproximado.Name = "txtValorAproximado";
            this.txtValorAproximado.Size = new System.Drawing.Size(242, 22);
            this.txtValorAproximado.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Error Absoluto y Relativo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(59, 281);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 37);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // FrmErrorAbsoluto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(145)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(928, 497);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorAproximado);
            this.Controls.Add(this.txtValorVerdadero);
            this.Controls.Add(this.lblErrorRelativo);
            this.Controls.Add(this.lblErrorAbsoluto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmErrorAbsoluto";
            this.Text = "Error Absoluto Relativo";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorAbsoluto;
        private System.Windows.Forms.Label lblErrorRelativo;
        private System.Windows.Forms.TextBox txtValorVerdadero;
        private System.Windows.Forms.TextBox txtValorAproximado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Diagnostics.EventLog eventLog1;
    }
}

