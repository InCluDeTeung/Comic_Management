using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDowsFormsDEMO
{
    public partial class frmTT : Form
    {
        private MangaList mg;
        public frmTT()
        {
            InitializeComponent();
            mg = new MangaList();
        }
        /*--------------------------------------*/
        void Reset()
        {
            txtMangaID.Text = "";
            txtDateRepublic.Text = "";
            txtQuantity.Text = "";
            txtAuthors.Text = "";
            txtMangaName.Text = "";
            txtNhaXuatBan.Text = "";
        }
        /*--------------------------------------*/
        void UpdateListView()
        {
            lvData.Items.Clear();
            for(int i =0; i < mg.SoPhanTu; i++)
            {
                Manga tempData = mg.GetInfoForm(i);
                lvData.Items.Add(new ListViewItem(new String[] { ""+
                    tempData.MangaID, tempData.DateOfRePublic,tempData.Author,
                    tempData.MangaName, tempData.NhaXuatBan,tempData.Quantity.ToString()}));
            }
        }
        /*--------------------------------------*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            if (btnAdd.Text.Equals("Thêm"))
            {
                for(int i = 0; i<lvData.SelectedItems.Count; i++)
                {
                    lvData.SelectedItems[i].Selected = false;
                }
                btnAdd.Text = "Hủy";
                txtMangaID.Enabled = true;
                txtMangaName.Enabled = true;
                txtDateRepublic.Enabled = true;
                txtAuthors.Enabled = true;
                txtNhaXuatBan.Enabled = true;
                txtQuantity.Enabled = true;
                txtMangaID.Focus();
            }
            else
            {
                btnAdd.Text = "Thêm";
                txtMangaID.Enabled = false;
                txtMangaName.Enabled = false;
                txtDateRepublic.Enabled = false;
                txtAuthors.Enabled = false;
                txtNhaXuatBan.Enabled = false;
                txtQuantity.Enabled = false;
            }
        }
        /*--------------------------------------*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Manga manga = new Manga(int.Parse(txtMangaID.Text),
                    txtDateRepublic.Text, txtAuthors.Text, txtNhaXuatBan.Text, txtMangaName.Text, txtQuantity.Text);
                if (mg.AddManga(manga))
                {
                    UpdateListView();
                    Reset();
                }
            }catch (Exception)
            {
                MessageBox.Show("Lỗi Dữ Liệu!", "Quản Lý thông tin truyện tranh- lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } finally
            {
                txtMangaID.Focus();
                txtMangaID.SelectAll();
            }
        }
        /*--------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("are you want to delete ?", "Quản Lý thông tin truyện tranh - Xóa dữ liệu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            for(int i = 0; i < lvData.SelectedItems.Count; i++)
            {
                int maSo = int.Parse(lvData.SelectedItems[i].SubItems[0].Text);
                if(d == DialogResult.Yes)
                {
                    mg.DeleteManga(maSo);
                }
            }
            UpdateListView();
        }
        /*--------------------------------------*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*--------------------------------------*/
        private void frmTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you Want to Close ? ", "Quản Lý Thông Tin Truyện Tranh", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void frmTT_Load(object sender, EventArgs e)
        {
            txtMangaID.Enabled = false;
            txtMangaName.Enabled = false;
            txtDateRepublic.Enabled = false;
            txtAuthors.Enabled = false;
            txtNhaXuatBan.Enabled = false;
            txtQuantity.Enabled = false;
        }
    }
}
