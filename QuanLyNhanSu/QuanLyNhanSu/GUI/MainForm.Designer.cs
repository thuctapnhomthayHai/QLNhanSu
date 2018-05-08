namespace QuanLyNhanSu.GUI
{
    partial class MainForm
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
            this.btnQLUser = new System.Windows.Forms.Button();
            this.btnQLLuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnQLNhanSu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLUser
            // 
            this.btnQLUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLUser.Location = new System.Drawing.Point(80, 145);
            this.btnQLUser.Name = "btnQLUser";
            this.btnQLUser.Size = new System.Drawing.Size(206, 33);
            this.btnQLUser.TabIndex = 2;
            this.btnQLUser.Text = "Quản Lý Người Dùng";
            this.btnQLUser.UseVisualStyleBackColor = true;
            // 
            // btnQLLuong
            // 
            this.btnQLLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLuong.Location = new System.Drawing.Point(80, 88);
            this.btnQLLuong.Name = "btnQLLuong";
            this.btnQLLuong.Size = new System.Drawing.Size(206, 34);
            this.btnQLLuong.TabIndex = 1;
            this.btnQLLuong.Text = "Quản Lý Tiền Lương";
            this.btnQLLuong.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(80, 258);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(206, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Về Màn Hình Đăng Nhập";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(80, 202);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(206, 33);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm Thông Tin Nhân Sự";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnQLNhanSu
            // 
            this.btnQLNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanSu.Location = new System.Drawing.Point(80, 30);
            this.btnQLNhanSu.Name = "btnQLNhanSu";
            this.btnQLNhanSu.Size = new System.Drawing.Size(206, 34);
            this.btnQLNhanSu.TabIndex = 0;
            this.btnQLNhanSu.Text = "Quản Lý Thông Tin Nhân Sụ";
            this.btnQLNhanSu.UseVisualStyleBackColor = true;
            this.btnQLNhanSu.Click += new System.EventHandler(this.btnQLNhanSu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(378, 497);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnQLNhanSu);
            this.Controls.Add(this.btnQLUser);
            this.Controls.Add(this.btnQLLuong);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLUser;
        private System.Windows.Forms.Button btnQLLuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnQLNhanSu;
    }
}