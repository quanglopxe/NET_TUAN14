namespace TEST
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenCSDL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên máy";
            // 
            // txt_TenMay
            // 
            this.txt_TenMay.Location = new System.Drawing.Point(171, 33);
            this.txt_TenMay.Name = "txt_TenMay";
            this.txt_TenMay.Size = new System.Drawing.Size(282, 26);
            this.txt_TenMay.TabIndex = 1;
            this.txt_TenMay.Leave += new System.EventHandler(this.txt_TenMay_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên CSDL";
            // 
            // txt_TenCSDL
            // 
            this.txt_TenCSDL.Location = new System.Drawing.Point(171, 75);
            this.txt_TenCSDL.Name = "txt_TenCSDL";
            this.txt_TenCSDL.Size = new System.Drawing.Size(282, 26);
            this.txt_TenCSDL.TabIndex = 1;
            this.txt_TenCSDL.TextChanged += new System.EventHandler(this.txt_TenCSDL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "User";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(171, 121);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(282, 26);
            this.txt_User.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(171, 166);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.Size = new System.Drawing.Size(282, 26);
            this.txt_PW.TabIndex = 1;
            this.txt_PW.UseSystemPasswordChar = true;
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(171, 240);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(82, 36);
            this.btn_conn.TabIndex = 2;
            this.btn_conn.Text = "Kết nối";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(296, 240);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(78, 36);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 343);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenCSDL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenMay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenCSDL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Button btn_Exit;
    }
}

