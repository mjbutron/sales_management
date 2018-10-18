using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Business
{
    public class CategoryController
    {
        #region Methods
        public static string Insert(string nameCat, string descriptionCat)
        {
            CategoryData DCat = new CategoryData();
            DCat.Name = nameCat;
            DCat.Description = descriptionCat;
            return DCat.Insert(DCat);
        }

        public static string Edit(int idCat, string nameCat, string descriptionCat)
        {
            CategoryData DCat = new CategoryData();
            DCat.IdCategory = idCat;
            DCat.Name = nameCat;
            DCat.Description = descriptionCat;
            return DCat.Edit(DCat);
        }

        public static string Delete(int idCat)
        {
            CategoryData DCat = new CategoryData();
            DCat.IdCategory = idCat;
            return DCat.Delete(DCat);
        }

        public static DataTable Show()
        {
            return new CategoryData().Show();
        }

        public static DataTable FindByName(string text)
        {
            CategoryData DCat = new CategoryData();
            DCat.FindText = text;
            return DCat.FindByName(DCat);
        }

        public static string NumCategory()
        {
            DataTable dtResutl = new CategoryData().NumCategory();
            string numCategory;
            if (dtResutl.Rows.Count == 0)
            {
                numCategory = "00";
            }
            else
            {
                numCategory = dtResutl.Rows[0][0].ToString();
                numCategory = (numCategory.Length == 1) ? "0" + numCategory : numCategory;
            }
            return numCategory;
        }
        #endregion
    }
}
