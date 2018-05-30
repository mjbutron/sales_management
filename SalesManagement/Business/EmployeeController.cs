using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

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
            DEmployee.Pass = pass;

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
            DEmployee.Pass = pass;

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

        public static DataTable FindByLastName(string text)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.FindText = text;
            return DEmployee.FindByLastName(DEmployee);
        }

        public static DataTable FindByNumDoc(string text)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.FindText = text;
            return DEmployee.FindByNumDoc(DEmployee);
        }

        public static DataTable Login(string user, string pass)
        {
            EmployeeData DEmployee = new EmployeeData();
            DEmployee.User = user;
            DEmployee.Pass = pass;
            return DEmployee.Login(DEmployee);
        }

        public static DataTable ShowTopEmployee()
        {
            return new EmployeeData().ShowTopEmployee();
        }
        #endregion
    }
}
