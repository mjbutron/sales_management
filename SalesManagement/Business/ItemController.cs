using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Business
{
    public class ItemController
    {
        #region Methods
        public static string Insert(string codeIt, string nameIt, string descriptionIt, byte[] imagenIt, int idCat)
        {
            ItemData DItem = new ItemData();
            DItem.CodeItem = codeIt;
            DItem.Name = nameIt;
            DItem.Description = descriptionIt;
            DItem.Image = imagenIt;
            DItem.IdCategory = idCat;
            return DItem.Insert(DItem);
        }

        public static string Edit(int idItem, string codeIt, string nameIt, string descriptionIt, byte[] imagenIt, int idCat)
        {
            ItemData DItem = new ItemData();
            DItem.IdItem = idItem;
            DItem.CodeItem = codeIt;
            DItem.Name = nameIt;
            DItem.Description = descriptionIt;
            DItem.Image = imagenIt;
            DItem.IdCategory = idCat;
            return DItem.Edit(DItem);
        }

        public static string Delete(int idItem)
        {
            ItemData DItem = new ItemData();
            DItem.IdItem = idItem;
            return DItem.Delete(DItem);
        }

        public static DataTable Show()
        {
            return new ItemData().Show();
        }

        public static DataTable FindByName(string text)
        {
            ItemData DItem = new ItemData();
            DItem.FindText = text;
            return DItem.FindByName(DItem);
        }
        #endregion
    }
}
