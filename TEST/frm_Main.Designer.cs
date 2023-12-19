namespace TEST
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_CoSo = new System.Windows.Forms.ComboBox();
            this.dtgv_GV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_DonVi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cellContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_GV)).BeginInit();
            this.cellContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở";
            // 
            // cbo_CoSo
            // 
            this.cbo_CoSo.FormattingEnabled = true;
            this.cbo_CoSo.Location = new System.Drawing.Point(156, 27);
            this.cbo_CoSo.Name = "cbo_CoSo";
            this.cbo_CoSo.Size = new System.Drawing.Size(214, 26);
            this.cbo_CoSo.TabIndex = 1;
            this.cbo_CoSo.SelectedIndexChanged += new System.EventHandler(this.cbo_CoSo_SelectedIndexChanged);
            // 
            // dtgv_GV
            // 
            this.dtgv_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_GV.Location = new System.Drawing.Point(46, 147);
            this.dtgv_GV.Name = "dtgv_GV";
            this.dtgv_GV.Size = new System.Drawing.Size(447, 215);
            this.dtgv_GV.TabIndex = 2;
            this.dtgv_GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_GV_CellClick);
            this.dtgv_GV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_GV_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn vị đào tạo";
            // 
            // cbo_DonVi
            // 
            this.cbo_DonVi.FormattingEnabled = true;
            this.cbo_DonVi.Location = new System.Drawing.Point(156, 70);
            this.cbo_DonVi.Name = "cbo_DonVi";
            this.cbo_DonVi.Size = new System.Drawing.Size(214, 26);
            this.cbo_DonVi.TabIndex = 1;
            this.cbo_DonVi.SelectedIndexChanged += new System.EventHandler(this.cbo_DonVi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách giáo viên";
            // 
            // cellContextMenu
            // 
            this.cellContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOption1,
            this.menuOption2});
            this.cellContextMenu.Name = "cellContextMenu";
            this.cellContextMenu.Size = new System.Drawing.Size(226, 70);
            // 
            // menuOption1
            // 
            this.menuOption1.Name = "menuOption1";
            this.menuOption1.Size = new System.Drawing.Size(225, 22);
            this.menuOption1.Text = "Hiển thị thông tin chi tiết GV";
            this.menuOption1.Click += new System.EventHandler(this.menuOption1_Click);
            // 
            // menuOption2
            // 
            this.menuOption2.Name = "menuOption2";
            this.menuOption2.Size = new System.Drawing.Size(225, 22);
            this.menuOption2.Text = "Xóa GV đang chọn";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgv_GV);
            this.Controls.Add(this.cbo_DonVi);
            this.Controls.Add(this.cbo_CoSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_GV)).EndInit();
            this.cellContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_CoSo;
        private System.Windows.Forms.DataGridView dtgv_GV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_DonVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cellContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuOption1;
        private System.Windows.Forms.ToolStripMenuItem menuOption2;
    }
}