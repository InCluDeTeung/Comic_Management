using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDowsFormsDEMO
{
    public class MangaList
    {
        private LinkedList<Manga> mg;
        public int SoPhanTu { get { return mg.Count; } }

        public MangaList()
        {
            mg = new LinkedList<Manga>();
        }

        public Manga GetInfo(int mangaID)
        {
            foreach (Manga manga in mg)
            {
                if(manga.MangaID == mangaID)
                {
                    return manga;
                }
            }
            return null;
        }

        public bool AddManga(Manga item)
        {
            if (GetInfo(item.MangaID) != null)
            {
                MessageBox.Show("MangaID has been exist!!", "quản lý thông tin truyện tranh - Lỗi Dữ Liệu"+ MessageBoxButtons.OK+ MessageBoxIcon.Warning);
                return false;
            } else
            {
                mg.AddLast(item);
            }
            return true;
        }

        public bool DeleteManga(int mangaID)
        {
            Manga man = GetInfo(mangaID);
            if(man == null)
            {
                return false;
            } else
            {
                mg.Remove(man);
            }
            return true;
        }
        public Manga GetInfoForm (int index)
        {
            if(index <0 || index >= mg.Count)
            {
                return null; 
            } else
            {
                LinkedListNode<Manga> tam = mg.First;
                for(int i =0; i< index; i++)
                {
                    tam = tam.Next;
                }
                return tam.Value;
            }
        }
    }
}
