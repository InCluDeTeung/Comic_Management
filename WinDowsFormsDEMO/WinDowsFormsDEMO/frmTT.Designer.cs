namespace WinDowsFormsDEMO
{
    partial class frmTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTT));
            this.gbQuanLyTruyentranh = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtDateRepublic = new System.Windows.Forms.TextBox();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.txtMangaName = new System.Windows.Forms.TextBox();
            this.txtMangaID = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbNhaXuatBan = new System.Windows.Forms.Label();
            this.lbDateRepublic = new System.Windows.Forms.Label();
            this.lbAuthors = new System.Windows.Forms.Label();
            this.lbMangaName = new System.Windows.Forms.Label();
            this.lbMangaID = new System.Windows.Forms.Label();
            this.lvData = new System.Windows.Forms.ListView();
            this.clMangaID = new System.Windows.Forms.ColumnHeader();
            this.clMangaName = new System.Windows.Forms.ColumnHeader();
            this.clNhaXuatBan = new System.Windows.Forms.ColumnHeader();
            this.clYearRepublic = new System.Windows.Forms.ColumnHeader();
            this.clAuthors = new System.Windows.Forms.ColumnHeader();
            this.clQuantity = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.gbQuanLyTruyentranh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQuanLyTruyentranh
            // 
            this.gbQuanLyTruyentranh.Controls.Add(this.txtQuantity);
            this.gbQuanLyTruyentranh.Controls.Add(this.txtNhaXuatBan);
            this.gbQuanLyTruyentranh.Controls.Add(this.txtDateRepublic);
            this.gbQuanLyTruyentranh.Controls.Add(this.txtAuthors);
            this.gbQuanLyTruyentranh.Controls.Add(this.txtMangaName);
            this.gbQuanLyTruyentranh.Controls.Add(this.txtMangaID);
            this.gbQuanLyTruyentranh.Controls.Add(this.lbQuantity);
            this.gbQuanLyTruyentranh.Controls.Add(this.lbNhaXuatBan);
            this.gbQuanLyTruyentranh.Controls.Add(this.lbDateRepublic);
            this.gbQuanLyTruyentranh.Controls.Add(this.lbAuthors);
            this.gbQuanLyTruyentranh.Controls.Add(this.lbMangaName);
            this.gbQuanLyTruyentranh.Controls.Add(this.lbMangaID);
            this.gbQuanLyTruyentranh.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbQuanLyTruyentranh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbQuanLyTruyentranh.Location = new System.Drawing.Point(12, 16);
            this.gbQuanLyTruyentranh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQuanLyTruyentranh.Name = "gbQuanLyTruyentranh";
            this.gbQuanLyTruyentranh.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQuanLyTruyentranh.Size = new System.Drawing.Size(790, 305);
            this.gbQuanLyTruyentranh.TabIndex = 0;
            this.gbQuanLyTruyentranh.TabStop = false;
            this.gbQuanLyTruyentranh.Text = "Quản Lý Truyện Tranh ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(522, 206);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(262, 26);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhaXuatBan.Location = new System.Drawing.Point(522, 137);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(262, 26);
            this.txtNhaXuatBan.TabIndex = 9;
            // 
            // txtDateRepublic
            // 
            this.txtDateRepublic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateRepublic.Location = new System.Drawing.Point(522, 66);
            this.txtDateRepublic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateRepublic.Name = "txtDateRepublic";
            this.txtDateRepublic.Size = new System.Drawing.Size(262, 26);
            this.txtDateRepublic.TabIndex = 8;
            // 
            // txtAuthors
            // 
            this.txtAuthors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthors.Location = new System.Drawing.Point(129, 209);
            this.txtAuthors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.Size = new System.Drawing.Size(262, 26);
            this.txtAuthors.TabIndex = 7;
            // 
            // txtMangaName
            // 
            this.txtMangaName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMangaName.Location = new System.Drawing.Point(129, 137);
            this.txtMangaName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMangaName.Name = "txtMangaName";
            this.txtMangaName.Size = new System.Drawing.Size(262, 26);
            this.txtMangaName.TabIndex = 6;
            // 
            // txtMangaID
            // 
            this.txtMangaID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMangaID.Location = new System.Drawing.Point(129, 66);
            this.txtMangaID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMangaID.Name = "txtMangaID";
            this.txtMangaID.Size = new System.Drawing.Size(262, 26);
            this.txtMangaID.TabIndex = 1;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQuantity.Location = new System.Drawing.Point(415, 209);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(70, 19);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Số Lượng";
            // 
            // lbNhaXuatBan
            // 
            this.lbNhaXuatBan.AutoSize = true;
            this.lbNhaXuatBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNhaXuatBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNhaXuatBan.Location = new System.Drawing.Point(415, 144);
            this.lbNhaXuatBan.Name = "lbNhaXuatBan";
            this.lbNhaXuatBan.Size = new System.Drawing.Size(96, 19);
            this.lbNhaXuatBan.TabIndex = 4;
            this.lbNhaXuatBan.Text = "Nhà Xuất Bản";
            // 
            // lbDateRepublic
            // 
            this.lbDateRepublic.AutoSize = true;
            this.lbDateRepublic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateRepublic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDateRepublic.Location = new System.Drawing.Point(415, 73);
            this.lbDateRepublic.Name = "lbDateRepublic";
            this.lbDateRepublic.Size = new System.Drawing.Size(99, 19);
            this.lbDateRepublic.TabIndex = 3;
            this.lbDateRepublic.Text = "Năm Sản Xuất";
            // 
            // lbAuthors
            // 
            this.lbAuthors.AutoSize = true;
            this.lbAuthors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAuthors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAuthors.Location = new System.Drawing.Point(6, 209);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(61, 19);
            this.lbAuthors.TabIndex = 2;
            this.lbAuthors.Text = "Tác Giả ";
            // 
            // lbMangaName
            // 
            this.lbMangaName.AutoSize = true;
            this.lbMangaName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMangaName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMangaName.Location = new System.Drawing.Point(6, 144);
            this.lbMangaName.Name = "lbMangaName";
            this.lbMangaName.Size = new System.Drawing.Size(119, 19);
            this.lbMangaName.TabIndex = 1;
            this.lbMangaName.Text = "Tên Truyện Tranh ";
            // 
            // lbMangaID
            // 
            this.lbMangaID.AutoSize = true;
            this.lbMangaID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMangaID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMangaID.Location = new System.Drawing.Point(6, 73);
            this.lbMangaID.Name = "lbMangaID";
            this.lbMangaID.Size = new System.Drawing.Size(117, 19);
            this.lbMangaID.TabIndex = 0;
            this.lbMangaID.Text = "Mã Truyện Tranh ";
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMangaID,
            this.clMangaName,
            this.clNhaXuatBan,
            this.clYearRepublic,
            this.clAuthors,
            this.clQuantity});
            this.lvData.Location = new System.Drawing.Point(12, 329);
            this.lvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(665, 285);
            this.lvData.TabIndex = 5;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // clMangaID
            // 
            this.clMangaID.Text = "Mã Truyện";
            // 
            // clMangaName
            // 
            this.clMangaName.Text = "Tên Truyện";
            // 
            // clNhaXuatBan
            // 
            this.clNhaXuatBan.Text = "Nhà Xuất Bản ";
            // 
            // clYearRepublic
            // 
            this.clYearRepublic.Text = "Năm Xuất Bản";
            // 
            // clAuthors
            // 
            this.clAuthors.Text = "Tác Giả ";
            // 
            // clQuantity
            // 
            this.clQuantity.Text = "Số Lượng";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(683, 329);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 61);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(683, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 61);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(683, 467);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 61);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(683, 536);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 61);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.Image = ((System.Drawing.Image)(resources.GetObject("pbAnh.Image")));
            this.pbAnh.Location = new System.Drawing.Point(808, 31);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(261, 583);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 6;
            this.pbAnh.TabStop = false;
            // 
            // frmTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 628);
            this.Controls.Add(this.pbAnh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.gbQuanLyTruyentranh);
            this.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTT_FormClosing);
            this.Load += new System.EventHandler(this.frmTT_Load);
            this.gbQuanLyTruyentranh.ResumeLayout(false);
            this.gbQuanLyTruyentranh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbQuanLyTruyentranh;
        private Label lbMangaID;
        private Label lbMangaName;
        private Label lbAuthors;
        private Label lbDateRepublic;
        private Label lbNhaXuatBan;
        private Label lbQuantity;
        private TextBox txtMangaID;
        private TextBox txtMangaName;
        private TextBox txtAuthors;
        private TextBox txtDateRepublic;
        private TextBox txtNhaXuatBan;
        private TextBox txtQuantity;
        private ListView lvData;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
        private ColumnHeader clMangaID;
        private ColumnHeader clMangaName;
        private ColumnHeader clNhaXuatBan;
        private ColumnHeader clYearRepublic;
        private ColumnHeader clAuthors;
        private ColumnHeader clQuantity;
        private PictureBox pbAnh;
    }
}