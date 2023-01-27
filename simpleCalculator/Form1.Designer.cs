namespace simpleCalculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.cboOpr = new System.Windows.Forms.ComboBox();
            this.Complete = new System.Windows.Forms.Button();
            this.lblEqual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(76, 169);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(125, 27);
            this.txtOp1.TabIndex = 0;
            this.txtOp1.Text = "op1";
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(324, 169);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(125, 27);
            this.txtOp2.TabIndex = 1;
            this.txtOp2.Text = "op2";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(518, 170);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(125, 27);
            this.txtAns.TabIndex = 2;
            this.txtAns.Text = "Ans";
            // 
            // cboOpr
            // 
            this.cboOpr.FormattingEnabled = true;
            this.cboOpr.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cboOpr.Location = new System.Drawing.Point(225, 169);
            this.cboOpr.Name = "cboOpr";
            this.cboOpr.Size = new System.Drawing.Size(76, 28);
            this.cboOpr.TabIndex = 3;
            this.cboOpr.Text = "Opr";
            // 
            // Complete
            // 
            this.Complete.Location = new System.Drawing.Point(301, 262);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(94, 29);
            this.Complete.TabIndex = 4;
            this.Complete.Text = "compute";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEqual.Location = new System.Drawing.Point(475, 174);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(22, 23);
            this.lblEqual.TabIndex = 5;
            this.lblEqual.Text = "=";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.cboOpr);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Name = "Calculator";
            this.Text = "Simple calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOp1;
        private TextBox txtOp2;
        private TextBox txtAns;
        private ComboBox cboOpr;
        private Button Complete;
        private Label lblEqual;
    }
}