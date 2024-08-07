namespace ADOsqldemo2
{
    partial class frmDelete
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
            this.txtDelID = new System.Windows.Forms.TextBox();
            this.lbldelID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDelID
            // 
            this.txtDelID.Location = new System.Drawing.Point(275, 101);
            this.txtDelID.Name = "txtDelID";
            this.txtDelID.Size = new System.Drawing.Size(100, 22);
            this.txtDelID.TabIndex = 1;
            // 
            // lbldelID
            // 
            this.lbldelID.AutoSize = true;
            this.lbldelID.Location = new System.Drawing.Point(127, 104);
            this.lbldelID.Name = "lbldelID";
            this.lbldelID.Size = new System.Drawing.Size(23, 16);
            this.lbldelID.TabIndex = 2;
            this.lbldelID.Text = "ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(207, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 330);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbldelID);
            this.Controls.Add(this.txtDelID);
            this.Name = "frmDelete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDelID;
        private System.Windows.Forms.Label lbldelID;
        private System.Windows.Forms.Button btnDelete;
    }
}