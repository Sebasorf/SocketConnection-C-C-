namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.up_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.down_btn = new System.Windows.Forms.Button();
            this.push_btn = new System.Windows.Forms.Button();
            this.pull_btn = new System.Windows.Forms.Button();
            this.ip_lbl = new System.Windows.Forms.Label();
            this.port_lbl = new System.Windows.Forms.Label();
            this.init_btn = new System.Windows.Forms.Button();
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // up_btn
            // 
            this.up_btn.Enabled = false;
            this.up_btn.Location = new System.Drawing.Point(165, 111);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(75, 23);
            this.up_btn.TabIndex = 0;
            this.up_btn.Text = "Up";
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.Enabled = false;
            this.right_btn.Location = new System.Drawing.Point(254, 149);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(75, 23);
            this.right_btn.TabIndex = 1;
            this.right_btn.Text = "Right";
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // left_btn
            // 
            this.left_btn.Enabled = false;
            this.left_btn.Location = new System.Drawing.Point(78, 148);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(75, 23);
            this.left_btn.TabIndex = 2;
            this.left_btn.Text = "Left";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // down_btn
            // 
            this.down_btn.Enabled = false;
            this.down_btn.Location = new System.Drawing.Point(165, 189);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(75, 23);
            this.down_btn.TabIndex = 3;
            this.down_btn.Text = "Down";
            this.down_btn.UseVisualStyleBackColor = true;
            this.down_btn.Click += new System.EventHandler(this.down_btn_Click);
            // 
            // push_btn
            // 
            this.push_btn.Enabled = false;
            this.push_btn.Location = new System.Drawing.Point(414, 111);
            this.push_btn.Name = "push_btn";
            this.push_btn.Size = new System.Drawing.Size(75, 40);
            this.push_btn.TabIndex = 4;
            this.push_btn.Text = "Push";
            this.push_btn.UseVisualStyleBackColor = true;
            this.push_btn.Click += new System.EventHandler(this.push_btn_Click);
            // 
            // pull_btn
            // 
            this.pull_btn.Enabled = false;
            this.pull_btn.Location = new System.Drawing.Point(414, 172);
            this.pull_btn.Name = "pull_btn";
            this.pull_btn.Size = new System.Drawing.Size(75, 40);
            this.pull_btn.TabIndex = 5;
            this.pull_btn.Text = "Pull";
            this.pull_btn.UseVisualStyleBackColor = true;
            this.pull_btn.Click += new System.EventHandler(this.pull_btn_Click);
            // 
            // ip_lbl
            // 
            this.ip_lbl.AutoSize = true;
            this.ip_lbl.Location = new System.Drawing.Point(106, 24);
            this.ip_lbl.Name = "ip_lbl";
            this.ip_lbl.Size = new System.Drawing.Size(17, 13);
            this.ip_lbl.TabIndex = 6;
            this.ip_lbl.Text = "IP";
            // 
            // port_lbl
            // 
            this.port_lbl.AutoSize = true;
            this.port_lbl.Location = new System.Drawing.Point(106, 58);
            this.port_lbl.Name = "port_lbl";
            this.port_lbl.Size = new System.Drawing.Size(26, 13);
            this.port_lbl.TabIndex = 7;
            this.port_lbl.Text = "Port";
            // 
            // init_btn
            // 
            this.init_btn.Location = new System.Drawing.Point(336, 39);
            this.init_btn.Name = "init_btn";
            this.init_btn.Size = new System.Drawing.Size(75, 23);
            this.init_btn.TabIndex = 8;
            this.init_btn.Text = "Initialize";
            this.init_btn.UseVisualStyleBackColor = true;
            this.init_btn.Click += new System.EventHandler(this.init_btn_Click);
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(165, 24);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(100, 20);
            this.ip_txt.TabIndex = 9;
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(165, 58);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(100, 20);
            this.port_txt.TabIndex = 10;
            // 
            // reset_btn
            // 
            this.reset_btn.Enabled = false;
            this.reset_btn.Location = new System.Drawing.Point(220, 274);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(116, 29);
            this.reset_btn.TabIndex = 11;
            this.reset_btn.Text = "Reset Connection";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 324);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.ip_txt);
            this.Controls.Add(this.init_btn);
            this.Controls.Add(this.port_lbl);
            this.Controls.Add(this.ip_lbl);
            this.Controls.Add(this.pull_btn);
            this.Controls.Add(this.push_btn);
            this.Controls.Add(this.down_btn);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.up_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.Button push_btn;
        private System.Windows.Forms.Button pull_btn;
        private System.Windows.Forms.Label ip_lbl;
        private System.Windows.Forms.Label port_lbl;
        private System.Windows.Forms.Button init_btn;
        private System.Windows.Forms.TextBox ip_txt;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Button reset_btn;
    }
}

