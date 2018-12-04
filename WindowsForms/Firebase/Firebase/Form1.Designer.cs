namespace Firebase
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
            this.BrnCreate = new System.Windows.Forms.Button();
            this.BrnRead = new System.Windows.Forms.Button();
            this.BrnUpdate = new System.Windows.Forms.Button();
            this.BrnDelete = new System.Windows.Forms.Button();
            this.TxbKey = new System.Windows.Forms.TextBox();
            this.cbxChaves = new System.Windows.Forms.ComboBox();
            this.TxbValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrnCreate
            // 
            this.BrnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrnCreate.Location = new System.Drawing.Point(20, 121);
            this.BrnCreate.Name = "BrnCreate";
            this.BrnCreate.Size = new System.Drawing.Size(75, 23);
            this.BrnCreate.TabIndex = 0;
            this.BrnCreate.Text = "criar";
            this.BrnCreate.UseVisualStyleBackColor = true;
            this.BrnCreate.Click += new System.EventHandler(this.BrnCreate_Click);
            // 
            // BrnRead
            // 
            this.BrnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrnRead.Location = new System.Drawing.Point(101, 121);
            this.BrnRead.Name = "BrnRead";
            this.BrnRead.Size = new System.Drawing.Size(75, 23);
            this.BrnRead.TabIndex = 1;
            this.BrnRead.Text = "Ler";
            this.BrnRead.UseVisualStyleBackColor = true;
            this.BrnRead.Click += new System.EventHandler(this.BrnRead_Click);
            // 
            // BrnUpdate
            // 
            this.BrnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrnUpdate.Location = new System.Drawing.Point(182, 121);
            this.BrnUpdate.Name = "BrnUpdate";
            this.BrnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BrnUpdate.TabIndex = 2;
            this.BrnUpdate.Text = "Atualizar";
            this.BrnUpdate.UseVisualStyleBackColor = true;
            this.BrnUpdate.Click += new System.EventHandler(this.BrnUpdate_Click);
            // 
            // BrnDelete
            // 
            this.BrnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrnDelete.Location = new System.Drawing.Point(263, 121);
            this.BrnDelete.Name = "BrnDelete";
            this.BrnDelete.Size = new System.Drawing.Size(75, 23);
            this.BrnDelete.TabIndex = 3;
            this.BrnDelete.Text = "Deletar";
            this.BrnDelete.UseVisualStyleBackColor = true;
            this.BrnDelete.Click += new System.EventHandler(this.BrnDelete_Click);
            // 
            // TxbKey
            // 
            this.TxbKey.Location = new System.Drawing.Point(81, 13);
            this.TxbKey.Name = "TxbKey";
            this.TxbKey.Size = new System.Drawing.Size(257, 20);
            this.TxbKey.TabIndex = 4;
            this.TxbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxChaves
            // 
            this.cbxChaves.FormattingEnabled = true;
            this.cbxChaves.Location = new System.Drawing.Point(81, 39);
            this.cbxChaves.Name = "cbxChaves";
            this.cbxChaves.Size = new System.Drawing.Size(257, 21);
            this.cbxChaves.TabIndex = 5;
            this.cbxChaves.SelectedIndexChanged += new System.EventHandler(this.cbxChaves_SelectedIndexChanged);
            // 
            // TxbValor
            // 
            this.TxbValor.Location = new System.Drawing.Point(81, 66);
            this.TxbValor.Multiline = true;
            this.TxbValor.Name = "TxbValor";
            this.TxbValor.Size = new System.Drawing.Size(257, 49);
            this.TxbValor.TabIndex = 6;
            this.TxbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seletor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbValor);
            this.Controls.Add(this.cbxChaves);
            this.Controls.Add(this.TxbKey);
            this.Controls.Add(this.BrnDelete);
            this.Controls.Add(this.BrnUpdate);
            this.Controls.Add(this.BrnRead);
            this.Controls.Add(this.BrnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIREBASE_CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrnCreate;
        private System.Windows.Forms.Button BrnRead;
        private System.Windows.Forms.Button BrnUpdate;
        private System.Windows.Forms.Button BrnDelete;
        private System.Windows.Forms.TextBox TxbKey;
        private System.Windows.Forms.ComboBox cbxChaves;
        private System.Windows.Forms.TextBox TxbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

