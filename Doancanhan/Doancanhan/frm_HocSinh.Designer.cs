namespace Doancanhan
{
    partial class frm_HocSinh
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
            this.data_Gridhocsinh = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mshs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_xeploai = new System.Windows.Forms.TextBox();
            this.txt_hocluc = new System.Windows.Forms.TextBox();
            this.txt_diemso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Gridhocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Gridhocsinh
            // 
            this.data_Gridhocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Gridhocsinh.Location = new System.Drawing.Point(41, 332);
            this.data_Gridhocsinh.Name = "data_Gridhocsinh";
            this.data_Gridhocsinh.RowTemplate.Height = 24;
            this.data_Gridhocsinh.Size = new System.Drawing.Size(796, 159);
            this.data_Gridhocsinh.TabIndex = 1;
            this.data_Gridhocsinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Gridhocsinh_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.Location = new System.Drawing.Point(85, 275);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(106, 29);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Location = new System.Drawing.Point(257, 275);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 29);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Location = new System.Drawing.Point(434, 275);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 29);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã số học sinh";
            // 
            // txt_mshs
            // 
            this.txt_mshs.Location = new System.Drawing.Point(211, 7);
            this.txt_mshs.Name = "txt_mshs";
            this.txt_mshs.Size = new System.Drawing.Size(179, 22);
            this.txt_mshs.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Điểm Số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Xếp loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Học Lực";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(211, 44);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(179, 22);
            this.txt_ten.TabIndex = 21;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(211, 87);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(179, 22);
            this.txt_diachi.TabIndex = 22;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(774, 49);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 27;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // txt_xeploai
            // 
            this.txt_xeploai.Location = new System.Drawing.Point(211, 169);
            this.txt_xeploai.Name = "txt_xeploai";
            this.txt_xeploai.Size = new System.Drawing.Size(179, 22);
            this.txt_xeploai.TabIndex = 24;
            // 
            // txt_hocluc
            // 
            this.txt_hocluc.Location = new System.Drawing.Point(211, 217);
            this.txt_hocluc.Name = "txt_hocluc";
            this.txt_hocluc.Size = new System.Drawing.Size(179, 22);
            this.txt_hocluc.TabIndex = 25;
            // 
            // txt_diemso
            // 
            this.txt_diemso.Location = new System.Drawing.Point(211, 131);
            this.txt_diemso.Name = "txt_diemso";
            this.txt_diemso.Size = new System.Drawing.Size(179, 22);
            this.txt_diemso.TabIndex = 23;
            // 
            // frm_HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 520);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_hocluc);
            this.Controls.Add(this.txt_xeploai);
            this.Controls.Add(this.txt_diemso);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mshs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.data_Gridhocsinh);
            this.Name = "frm_HocSinh";
            this.Text = "frm_HocSinh";
            this.Load += new System.EventHandler(this.frm_HocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Gridhocsinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_Gridhocsinh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mshs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_xeploai;
        private System.Windows.Forms.TextBox txt_hocluc;
        private System.Windows.Forms.TextBox txt_diemso;
    }
}