namespace Serialisierung
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
            this.LbxFahrzeuge = new System.Windows.Forms.ListBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbxFahrzeuge
            // 
            this.LbxFahrzeuge.FormattingEnabled = true;
            this.LbxFahrzeuge.Location = new System.Drawing.Point(12, 10);
            this.LbxFahrzeuge.Name = "LbxFahrzeuge";
            this.LbxFahrzeuge.Size = new System.Drawing.Size(190, 225);
            this.LbxFahrzeuge.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(222, 12);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(137, 29);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "Neu";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(222, 117);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(137, 29);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Laden";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(222, 82);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 29);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(222, 47);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(137, 29);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 249);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LbxFahrzeuge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbxFahrzeuge;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
    }
}

