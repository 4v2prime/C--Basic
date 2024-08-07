namespace ADOsqltask3
{
    partial class AllUserdata
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
            this.grdAllUserdata = new System.Windows.Forms.DataGridView();
            this.Offer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllUserdata)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAllUserdata
            // 
            this.grdAllUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllUserdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Offer});
            this.grdAllUserdata.Location = new System.Drawing.Point(229, 74);
            this.grdAllUserdata.Name = "grdAllUserdata";
            this.grdAllUserdata.RowHeadersWidth = 51;
            this.grdAllUserdata.RowTemplate.Height = 24;
            this.grdAllUserdata.Size = new System.Drawing.Size(770, 323);
            this.grdAllUserdata.TabIndex = 0;
            // 
            // Offer
            // 
            this.Offer.FillWeight = 50F;
            this.Offer.HeaderText = "header";
            this.Offer.MinimumWidth = 6;
            this.Offer.Name = "Offer";
            this.Offer.Text = "Offer";
            this.Offer.UseColumnTextForButtonValue = true;
            this.Offer.Width = 90;
            // 
            // AllUserdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 516);
            this.Controls.Add(this.grdAllUserdata);
            this.Name = "AllUserdata";
            this.Text = "AllUserdata";
            this.Load += new System.EventHandler(this.AllUserdata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllUserdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAllUserdata;
        private System.Windows.Forms.DataGridViewButtonColumn Offer;
    }
}