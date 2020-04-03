namespace Homework7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.drawTree = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.Label();
            this.leng = new System.Windows.Forms.Label();
            this.per1 = new System.Windows.Forms.Label();
            this.per2 = new System.Windows.Forms.Label();
            this.th1 = new System.Windows.Forms.Label();
            this.th2 = new System.Windows.Forms.Label();
            this.depthValue = new System.Windows.Forms.TextBox();
            this.lengValue = new System.Windows.Forms.TextBox();
            this.per1Value = new System.Windows.Forms.TextBox();
            this.per2Value = new System.Windows.Forms.TextBox();
            this.th1Value = new System.Windows.Forms.TextBox();
            this.th2Value = new System.Windows.Forms.TextBox();
            this.penColor = new System.Windows.Forms.Label();
            this.penColorValue = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawTree
            // 
            this.drawTree.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drawTree.ForeColor = System.Drawing.Color.White;
            this.drawTree.Image = global::Homework7.Properties.Resources.preview;
            this.drawTree.Location = new System.Drawing.Point(53, 386);
            this.drawTree.Name = "drawTree";
            this.drawTree.Size = new System.Drawing.Size(129, 74);
            this.drawTree.TabIndex = 0;
            this.drawTree.Text = "画树";
            this.drawTree.UseVisualStyleBackColor = true;
            this.drawTree.Click += new System.EventHandler(this.drawTree_Click);
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Location = new System.Drawing.Point(3, 13);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(142, 15);
            this.depth.TabIndex = 1;
            this.depth.Text = "递归深度（正整数）";
            // 
            // leng
            // 
            this.leng.AutoSize = true;
            this.leng.Location = new System.Drawing.Point(12, 56);
            this.leng.Name = "leng";
            this.leng.Size = new System.Drawing.Size(67, 15);
            this.leng.TabIndex = 2;
            this.leng.Text = "主干长度";
            // 
            // per1
            // 
            this.per1.AutoSize = true;
            this.per1.Location = new System.Drawing.Point(3, 96);
            this.per1.Name = "per1";
            this.per1.Size = new System.Drawing.Size(97, 15);
            this.per1.TabIndex = 3;
            this.per1.Text = "右分支长度比";
            // 
            // per2
            // 
            this.per2.AutoSize = true;
            this.per2.Location = new System.Drawing.Point(3, 140);
            this.per2.Name = "per2";
            this.per2.Size = new System.Drawing.Size(97, 15);
            this.per2.TabIndex = 4;
            this.per2.Text = "左分支长度比";
            // 
            // th1
            // 
            this.th1.AutoSize = true;
            this.th1.Location = new System.Drawing.Point(3, 182);
            this.th1.Name = "th1";
            this.th1.Size = new System.Drawing.Size(82, 15);
            this.th1.TabIndex = 5;
            this.th1.Text = "右分支角度";
            // 
            // th2
            // 
            this.th2.AutoSize = true;
            this.th2.Location = new System.Drawing.Point(3, 232);
            this.th2.Name = "th2";
            this.th2.Size = new System.Drawing.Size(82, 15);
            this.th2.TabIndex = 6;
            this.th2.Text = "左分支角度";
            // 
            // depthValue
            // 
            this.depthValue.Location = new System.Drawing.Point(164, 10);
            this.depthValue.Name = "depthValue";
            this.depthValue.Size = new System.Drawing.Size(57, 25);
            this.depthValue.TabIndex = 7;
            this.depthValue.Text = "10";
            this.depthValue.TextChanged += new System.EventHandler(this.depthValue_TextChanged);
            // 
            // lengValue
            // 
            this.lengValue.Location = new System.Drawing.Point(164, 56);
            this.lengValue.Name = "lengValue";
            this.lengValue.Size = new System.Drawing.Size(55, 25);
            this.lengValue.TabIndex = 8;
            this.lengValue.Text = "100";
            this.lengValue.TextChanged += new System.EventHandler(this.lengValue_TextChanged);
            // 
            // per1Value
            // 
            this.per1Value.Location = new System.Drawing.Point(162, 96);
            this.per1Value.Name = "per1Value";
            this.per1Value.Size = new System.Drawing.Size(57, 25);
            this.per1Value.TabIndex = 9;
            this.per1Value.Text = "0.6";
            this.per1Value.TextChanged += new System.EventHandler(this.per1Value_TextChanged);
            // 
            // per2Value
            // 
            this.per2Value.Location = new System.Drawing.Point(162, 137);
            this.per2Value.Name = "per2Value";
            this.per2Value.Size = new System.Drawing.Size(57, 25);
            this.per2Value.TabIndex = 10;
            this.per2Value.Text = "0.7";
            this.per2Value.TextChanged += new System.EventHandler(this.per2Value_TextChanged);
            // 
            // th1Value
            // 
            this.th1Value.Location = new System.Drawing.Point(164, 179);
            this.th1Value.Name = "th1Value";
            this.th1Value.Size = new System.Drawing.Size(57, 25);
            this.th1Value.TabIndex = 11;
            this.th1Value.Text = "30";
            this.th1Value.TextChanged += new System.EventHandler(this.th1Value_TextChanged);
            // 
            // th2Value
            // 
            this.th2Value.Location = new System.Drawing.Point(162, 229);
            this.th2Value.Name = "th2Value";
            this.th2Value.Size = new System.Drawing.Size(57, 25);
            this.th2Value.TabIndex = 12;
            this.th2Value.Text = "20";
            this.th2Value.TextChanged += new System.EventHandler(this.th2Value_TextChanged);
            // 
            // penColor
            // 
            this.penColor.AutoSize = true;
            this.penColor.Location = new System.Drawing.Point(3, 303);
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(67, 15);
            this.penColor.TabIndex = 13;
            this.penColor.Text = "画笔颜色";
            // 
            // penColorValue
            // 
            this.penColorValue.FormattingEnabled = true;
            this.penColorValue.Items.AddRange(new object[] {
            "White",
            "Red",
            "Blue",
            "Yellow",
            "Purple",
            "Silver",
            "Black",
            "Orange",
            "Green"});
            this.penColorValue.Location = new System.Drawing.Point(118, 300);
            this.penColorValue.Name = "penColorValue";
            this.penColorValue.Size = new System.Drawing.Size(121, 23);
            this.penColorValue.TabIndex = 14;
            this.penColorValue.Text = "Blue";
            this.penColorValue.SelectedIndexChanged += new System.EventHandler(this.penColorValue_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(397, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 696);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clear_btn);
            this.panel2.Controls.Add(this.depth);
            this.panel2.Controls.Add(this.depthValue);
            this.panel2.Controls.Add(this.drawTree);
            this.panel2.Controls.Add(this.penColorValue);
            this.panel2.Controls.Add(this.leng);
            this.panel2.Controls.Add(this.penColor);
            this.panel2.Controls.Add(this.lengValue);
            this.panel2.Controls.Add(this.th2Value);
            this.panel2.Controls.Add(this.per1);
            this.panel2.Controls.Add(this.th2);
            this.panel2.Controls.Add(this.th1Value);
            this.panel2.Controls.Add(this.per1Value);
            this.panel2.Controls.Add(this.per2Value);
            this.panel2.Controls.Add(this.th1);
            this.panel2.Controls.Add(this.per2);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 607);
            this.panel2.TabIndex = 16;
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear_btn.Location = new System.Drawing.Point(53, 486);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(129, 74);
            this.clear_btn.TabIndex = 15;
            this.clear_btn.Text = "清除";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawTree;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label leng;
        private System.Windows.Forms.Label per1;
        private System.Windows.Forms.Label per2;
        private System.Windows.Forms.Label th1;
        private System.Windows.Forms.Label th2;
        private System.Windows.Forms.TextBox depthValue;
        private System.Windows.Forms.TextBox lengValue;
        private System.Windows.Forms.TextBox per1Value;
        private System.Windows.Forms.TextBox per2Value;
        private System.Windows.Forms.TextBox th1Value;
        private System.Windows.Forms.TextBox th2Value;
        private System.Windows.Forms.Label penColor;
        private System.Windows.Forms.ComboBox penColorValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clear_btn;
    }
}

