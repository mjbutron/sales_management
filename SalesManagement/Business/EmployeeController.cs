﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;
using System.Security.Cryptography;

namespace Business
{
    public class EmployeeController
    {
        #region Methods
        public static string Insert(string name, string lastName, string sex, DateTime birthdate, string numDoc, string address, string phone, string email, string rol, string user, string pass)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.Name = name;
            DEmployee.LastName = lastName;
            DEmployee.Sex = sex;
            DEmployee.Birthdate = birthdate;
            DEmployee.NumDoc = numDoc;
            DEmployee.Address = address;
            DEmployee.Phone = phone;
            DEmployee.Email = email;
            DEmployee.Rol = rol;
            DEmployee.User = user;
            DEmployee.Pass = EncodePassword(string.Concat(user, pass));

            return DEmployee.Insert(DEmployee);
        }

        public static string Edit(int idEmp, string name, string lastName, string sex, DateTime birthdate, string numDoc, string address, string phone, string email, string rol, string user, string pass)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.IdEmployee = idEmp;
            DEmployee.Name = name;
            DEmployee.LastName = lastName;
            DEmployee.Sex = sex;
            DEmployee.Birthdate = birthdate;
            DEmployee.NumDoc = numDoc;
            DEmployee.Address = address;
            DEmployee.Phone = phone;
            DEmployee.Email = email;
            DEmployee.Rol = rol;
            DEmployee.User = user;
            DEmployee.Pass = EncodePassword(string.Concat(user, pass));

            return DEmployee.Edit(DEmployee);
        }

        public static string Delete(int idEmp)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.IdEmployee = idEmp;
            return DEmployee.Delete(DEmployee);
        }

        public static DataTable Show()
        {
            return new EmployeeData().Show();
        }

        public static DataTable FindByComboBox(string procedure, string param, string text)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.FindText = text;
            return DEmployee.FindByComboBox(procedure, param, DEmployee);
        }

        public static DataTable Login(string user, string pass)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.User = user;
            DEmployee.Pass = EncodePassword(string.Concat(user, pass));
            return DEmployee.Login(DEmployee);
        }

        public static DataTable ShowTopEmployee()
        {
            return new EmployeeData().ShowTopEmployee();
        }

        public static string EncodePassword(string originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }

        public static string NumEmployee()
        {
            DataTable dtResutl = new EmployeeData().NumEmployee();
            string numEmployee;
            if(dtResutl.Rows.Count == 0)
            {
                numEmployee = "00";
            }else
            {
                numEmployee = dtResutl.Rows[0][0].ToString();
                numEmployee = (numEmployee.Length == 1) ? "0" + numEmployee : numEmployee;
            }
            return numEmployee;            
        }
        #endregion
    }
}
