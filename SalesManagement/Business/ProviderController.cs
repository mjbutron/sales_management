using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Business
{
    public class ProviderController
    {
        #region Methods
        public static string Insert(string businessName, string sector, string typeDoc, string numDoc, string address, string phone, string mobile, string fax, string email, string web)
        {
            ProviderData DProvider = new ProviderData();
            DProvider.BusinessName = businessName;
            DProvider.Sector = sector;
            DProvider.TypeDoc = typeDoc;
            DProvider.NumDoc = numDoc;
            DProvider.Address = address;
            DProvider.Phone = phone;
            DProvider.Mobile = mobile;
            DProvider.Fax = fax;
            DProvider.Email = email;
            DProvider.Web = web;

            return DProvider.Insert(DProvider);
        }

        public static string Edit(int idPro, string businessName, string sector, string typeDoc, string numDoc, string address, string phone, string mobile, string fax, string email, string web)
        {
            ProviderData DProvider = new ProviderData();
            DProvider.IdProvider = idPro;
            DProvider.BusinessName = businessName;
            DProvider.Sector = sector;
            DProvider.TypeDoc = typeDoc;
            DProvider.NumDoc = numDoc;
            DProvider.Address = address;
            DProvider.Phone = phone;
            DProvider.Mobile = mobile;
            DProvider.Fax = fax;
            DProvider.Email = email;
            DProvider.Web = web;

            return DProvider.Edit(DProvider);
        }

        public static string Delete(int idPro)
        {
            ProviderData DProvider = new ProviderData();
            DProvider.IdProvider = idPro;
            return DProvider.Delete(DProvider);
        }

        public static DataTable Show()
        {
            return new ProviderData().Show();
        }

        public static DataTable FindByBusinessName(string text)
        {
            ProviderData DProvider = new ProviderData();
            DProvider.FindText = text;
            return DProvider.FindByBusinessName(DProvider);
        }

        public static DataTable FindByNumDoc(string text)
        {
            ProviderData DProvider = new ProviderData();
            DProvider.FindText = text;
            return DProvider.FindByNumDoc(DProvider);
        }
        #endregion
    }
}
