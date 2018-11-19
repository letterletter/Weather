namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.showwea = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ipcity = new System.Windows.Forms.TextBox();
            this.city2 = new System.Windows.Forms.RichTextBox();
            this.selfcity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(222, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询本地天气";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showwea
            // 
            this.showwea.BackColor = System.Drawing.Color.Thistle;
            this.showwea.ForeColor = System.Drawing.Color.Black;
            this.showwea.Location = new System.Drawing.Point(371, 104);
            this.showwea.Name = "showwea";
            this.showwea.Size = new System.Drawing.Size(287, 303);
            this.showwea.TabIndex = 1;
            this.showwea.Text = "";
            this.showwea.TextChanged += new System.EventHandler(this.showwea_TextChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(26, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "显示IP和城市";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ipcity
            // 
            this.ipcity.Location = new System.Drawing.Point(25, 63);
            this.ipcity.Name = "ipcity";
            this.ipcity.Size = new System.Drawing.Size(85, 21);
            this.ipcity.TabIndex = 4;
            // 
            // city2
            // 
            this.city2.Location = new System.Drawing.Point(117, 61);
            this.city2.Name = "city2";
            this.city2.Size = new System.Drawing.Size(99, 22);
            this.city2.TabIndex = 5;
            this.city2.Text = "";
            // 
            // selfcity
            // 
            this.selfcity.Location = new System.Drawing.Point(117, 104);
            this.selfcity.Name = "selfcity";
            this.selfcity.Size = new System.Drawing.Size(100, 21);
            this.selfcity.TabIndex = 7;
            this.selfcity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "输入城市名";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Indigo;
            this.button3.Location = new System.Drawing.Point(223, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 419);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selfcity);
            this.Controls.Add(this.city2);
            this.Controls.Add(this.ipcity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showwea);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Plum;
            this.Name = "Form1";
            this.Text = "雾霾探测系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox showwea;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ipcity;
        private System.Windows.Forms.RichTextBox city2;
        private System.Windows.Forms.TextBox selfcity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

