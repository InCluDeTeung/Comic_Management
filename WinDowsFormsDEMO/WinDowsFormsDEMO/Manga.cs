using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDowsFormsDEMO
{
    public class Manga
    {
        public int MangaID { get; set; }
        public string DateOfRePublic { get; set; }
        public string Author { get; set; }
        public string MangaName { get; set; }
        public string NhaXuatBan { get; set; }
        public string Quantity { get; set; }

        public Manga(int mangaID, string dateOfRePublic, string author, string mangaName, string nhaXuatBan, string quantity)
        {
            MangaID = mangaID;
            DateOfRePublic = dateOfRePublic;
            Author = author;
            MangaName = mangaName;
            NhaXuatBan = nhaXuatBan;
            Quantity = quantity;
        }

    }
}
