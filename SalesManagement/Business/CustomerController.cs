using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Business
{
    public class CustomerController
    {
        #region Methods
        public static string Insert(string name, string lastName, string sex, DateTime birthdate, string typeDoc, string numDoc, string address, string phone, string email)
        {
            CustomerData DCustomer = new CustomerData();
            DCustomer.Name = name;
            DCustomer.LastName = lastName;
            DCustomer.Sex = sex;
            DCustomer.Birthdate = birthdate;
            DCustomer.TypeDoc = typeDoc;
            DCustomer.NumDoc = numDoc;
            DCustomer.Address = address;
            DCustomer.Phone = phone;
            DCustomer.Email = email;

            return DCustomer.Insert(DCustomer);
        }

        public static string Edit(int idCus, string name, string lastName, string sex, DateTime birthdate, string typeDoc, string numDoc, string address, string phone, string email)
        {
            CustomerData DCustomer = new CustomerData();
            DCustomer.IdCustomer = idCus;
            DCustomer.Name = name;
            DCustomer.LastName = lastName;
            DCustomer.Sex = sex;
            DCustomer.Birthdate = birthdate;
            DCustomer.TypeDoc = typeDoc;
            DCustomer.NumDoc = numDoc;
            DCustomer.Address = address;
            DCustomer.Phone = phone;
            DCustomer.Email = email;

            return DCustomer.Edit(DCustomer);
        }

        public static string Delete(int idCus)
        {
            CustomerData DCustomer = new CustomerData();
            DCustomer.IdCustomer = idCus;
            return DCustomer.Delete(DCustomer);
        }

        public static DataTable Show()
        {
            return new CustomerData().Show();
        }

        public static DataTable FindByLastName(string text)
        {
            CustomerData DCustomer = new CustomerData();
            DCustomer.FindText = text;
            return DCustomer.FindByLastName(DCustomer);
        }

        public static DataTable FindByNumDoc(string text)
        {
            CustomerData DCustomer = new CustomerData();
            DCustomer.FindText = text;
            return DCustomer.FindByNumDoc(DCustomer);
        }

        public static string NumCustomer()
        {
            DataTable dtResutl = new CustomerData().NumCustomer();
            string numCustomer;
            if (dtResutl.Rows.Count == 0)
            {
                numCustomer = "00";
            }
            else
            {
                numCustomer = dtResutl.Rows[0][0].ToString();
                numCustomer = (numCustomer.Length == 1) ? "0" + numCustomer : numCustomer;
            }
            return numCustomer;
        }
        #endregion
    }
}
