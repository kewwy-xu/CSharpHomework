namespace Order_Winform
{
    partial class DeleteOrderForm
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
            this.agree_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteInput_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // agree_btn
            // 
            this.agree_btn.Location = new System.Drawing.Point(313, 266);
            this.agree_btn.Name = "agree_btn";
            this.agree_btn.Size = new System.Drawing.Size(75, 23);
            this.agree_btn.TabIndex = 0;
            this.agree_btn.Text = "确定";
            this.agree_btn.UseVisualStyleBackColor = true;
            this.agree_btn.Click += new System.EventHandler(this.agree_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "想删除的订单号";
            // 
            // deleteInput_tbox
            // 
            this.deleteInput_tbox.Location = new System.Drawing.Point(341, 127);
            this.deleteInput_tbox.Name = "deleteInput_tbox";
            this.deleteInput_tbox.Size = new System.Drawing.Size(120, 25);
            this.deleteInput_tbox.TabIndex = 2;
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteInput_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agree_btn);
            this.Name = "DeleteOrderForm";
            this.Text = "DeleteOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agree_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteInput_tbox;
    }
}