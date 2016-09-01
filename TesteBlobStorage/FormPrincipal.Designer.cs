namespace TesteBlobStorage
{
    partial class FormPrincipal
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeBlob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCarregados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Container:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label2.Location = new System.Drawing.Point(193, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "testecontainer";
            // 
            // txtNomeBlob
            // 
            this.txtNomeBlob.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBlob.Location = new System.Drawing.Point(60, 128);
            this.txtNomeBlob.MaxLength = 1024;
            this.txtNomeBlob.Name = "txtNomeBlob";
            this.txtNomeBlob.Size = new System.Drawing.Size(517, 33);
            this.txtNomeBlob.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blob:";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(60, 186);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 40);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(246, 186);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(150, 40);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Dowload";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(427, 186);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Blobs já carregados:";
            // 
            // lstCarregados
            // 
            this.lstCarregados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCarregados.Font = new System.Drawing.Font("Arial Narrow", 13.2F);
            this.lstCarregados.FormattingEnabled = true;
            this.lstCarregados.ItemHeight = 26;
            this.lstCarregados.Location = new System.Drawing.Point(60, 283);
            this.lstCarregados.Name = "lstCarregados";
            this.lstCarregados.Size = new System.Drawing.Size(517, 184);
            this.lstCarregados.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 530);
            this.Controls.Add(this.lstCarregados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeBlob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Utilização - Blob Storage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeBlob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCarregados;
    }
}

