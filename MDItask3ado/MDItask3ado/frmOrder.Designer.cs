namespace MDItask3ado
{
    partial class frmOrder
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
            this.lblcmt1 = new System.Windows.Forms.Label();
            this.lbldish = new System.Windows.Forms.Label();
            this.lblcmt2 = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcmt1
            // 
            this.lblcmt1.AutoSize = true;
            this.lblcmt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmt1.Location = new System.Drawing.Point(243, 107);
            this.lblcmt1.Name = "lblcmt1";
            this.lblcmt1.Size = new System.Drawing.Size(153, 26);
            this.lblcmt1.TabIndex = 0;
            this.lblcmt1.Text = "Your Menu is :";
            // 
            // lbldish
            // 
            this.lbldish.AutoSize = true;
            this.lbldish.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbldish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldish.Location = new System.Drawing.Point(415, 108);
            this.lbldish.Name = "lbldish";
            this.lbldish.Size = new System.Drawing.Size(56, 25);
            this.lbldish.TabIndex = 1;
            this.lbldish.Text = "qqqq";
            // 
            // lblcmt2
            // 
            this.lblcmt2.AutoSize = true;
            this.lblcmt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmt2.Location = new System.Drawing.Point(243, 207);
            this.lblcmt2.Name = "lblcmt2";
            this.lblcmt2.Size = new System.Drawing.Size(161, 26);
            this.lblcmt2.TabIndex = 2;
            this.lblcmt2.Text = "Total Price is :  ";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(410, 208);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(56, 25);
            this.lblcost.TabIndex = 3;
            this.lblcost.Text = "qqqq";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(248, 285);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 32);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(395, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.lblcmt2);
            this.Controls.Add(this.lbldish);
            this.Controls.Add(this.lblcmt1);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcmt1;
        private System.Windows.Forms.Label lbldish;
        private System.Windows.Forms.Label lblcmt2;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}