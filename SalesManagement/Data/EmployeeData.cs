using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class EmployeeData
    {
        private int _IdEmployee;
        private string _Name;
        private string _LastName;
        private string _Sex;
        private DateTime _Birthdate;
        private string _NumDoc;
        private string _Address;
        private string _Phone;
        private string _Email;
        private string _Rol;
        private string _User;
        private string _Pass;

        private string _FindText;

        #region Get y Set
        public int IdEmployee
        {
            get
            {
                return _IdEmployee;
            }

            set
            {
                _IdEmployee = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string Sex
        {
            get
            {
                return _Sex;
            }

            set
            {
                _Sex = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return _Birthdate;
            }

            set
            {
                _Birthdate = value;
            }
        }

        public string NumDoc
        {
            get
            {
                return _NumDoc;
            }

            set
            {
                _NumDoc = value;
            }
        }

        public string Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        public string Phone
        {
            get
            {
                return _Phone;
            }

            set
            {
                _Phone = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }

            set
            {
                _Rol = value;
            }
        }

        public string User
        {
            get
            {
                return _User;
            }

            set
            {
                _User = value;
            }
        }

        public string Pass
        {
            get
            {
                return _Pass;
            }

            set
            {
                _Pass = value;
            }
        }

        public string FindText
        {
            get
            {
                return _FindText;
            }

            set
            {
                _FindText = value;
            }
        }
        #endregion

        #region Constructor
        public EmployeeData() { }

        public EmployeeData(int idEmp, string name, string lastName, string sex, DateTime birthdate, string numDoc, string address, string phone, string email, string rol, string user, string pass, string text)
        {
            this.IdEmployee = idEmp;
            this.Name = name;
            this.LastName = lastName;
            this.Sex = sex;
            this.Birthdate = birthdate;
            this.NumDoc = numDoc;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Rol = rol;
            this.User = user;
            this.Pass = pass;
            this.FindText = text;
        }
        #endregion

        #region Methods
        public string Insert(EmployeeData Employee)
        {
            string res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                // Connection
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                // Comand
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_empleado";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 50;
                ParName.Value = Employee.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParLastName = new SqlParameter();
                ParLastName.ParameterName = "@apellidos";
                ParLastName.SqlDbType = SqlDbType.VarChar;
                ParLastName.Size = 50;
                ParLastName.Value = Employee.LastName;
                SqlCmd.Parameters.Add(ParLastName);

                SqlParameter ParSex = new SqlParameter();
                ParSex.ParameterName = "@sexo";
                ParSex.SqlDbType = SqlDbType.VarChar;
                ParSex.Size = 1;
                ParSex.Value = Employee.Sex;
                SqlCmd.Parameters.Add(ParSex);

                SqlParameter ParBirthdate = new SqlParameter();
                ParBirthdate.ParameterName = "@fecha_nacimiento";
                ParBirthdate.SqlDbType = SqlDbType.DateTime;
                ParBirthdate.Value = Employee.Birthdate;
                SqlCmd.Parameters.Add(ParBirthdate);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@dni";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 9;
                ParNumDoc.Value = Employee.NumDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 150;
                ParAddress.Value = Employee.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParPhone = new SqlParameter();
                ParPhone.ParameterName = "@telefono";
                ParPhone.SqlDbType = SqlDbType.VarChar;
                ParPhone.Size = 10;
                ParPhone.Value = Employee.Phone;
                SqlCmd.Parameters.Add(ParPhone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Employee.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParRol = new SqlParameter();
                ParRol.ParameterName = "@rol";
                ParRol.SqlDbType = SqlDbType.VarChar;
                ParRol.Size = 20;
                ParRol.Value = Employee.Rol;
                SqlCmd.Parameters.Add(ParRol);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@usuario";
                ParUser.SqlDbType = SqlDbType.VarChar;
                ParUser.Size = 50;
                ParUser.Value = Employee.User;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPass = new SqlParameter();
                ParPass.ParameterName = "@password";
                ParPass.SqlDbType = SqlDbType.VarChar;
                ParPass.Size = 50;
                ParPass.Value = Employee.Pass;
                SqlCmd.Parameters.Add(ParPass);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido insertar el registro";
            }
            catch (Exception e)
            {
                res = e.Message;
            }
            finally
            {
                // Close connection
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return res;
        }

        public string Edit(EmployeeData Employee)
        {
            string res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                // Connection
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                // Comand
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "peditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_empleado";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Employee.IdEmployee;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 50;
                ParName.Value = Employee.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParLastName = new SqlParameter();
                ParLastName.ParameterName = "@apellidos";
                ParLastName.SqlDbType = SqlDbType.VarChar;
                ParLastName.Size = 50;
                ParLastName.Value = Employee.LastName;
                SqlCmd.Parameters.Add(ParLastName);

                SqlParameter ParSex = new SqlParameter();
                ParSex.ParameterName = "@sexo";
                ParSex.SqlDbType = SqlDbType.VarChar;
                ParSex.Size = 1;
                ParSex.Value = Employee.Sex;
                SqlCmd.Parameters.Add(ParSex);

                SqlParameter ParBirthdate = new SqlParameter();
                ParBirthdate.ParameterName = "@fecha_nacimiento";
                ParBirthdate.SqlDbType = SqlDbType.DateTime;
                ParBirthdate.Value = Employee.Birthdate;
                SqlCmd.Parameters.Add(ParBirthdate);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@dni";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 9;
                ParNumDoc.Value = Employee.NumDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 150;
                ParAddress.Value = Employee.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParPhone = new SqlParameter();
                ParPhone.ParameterName = "@telefono";
                ParPhone.SqlDbType = SqlDbType.VarChar;
                ParPhone.Size = 10;
                ParPhone.Value = Employee.Phone;
                SqlCmd.Parameters.Add(ParPhone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Employee.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParRol = new SqlParameter();
                ParRol.ParameterName = "@rol";
                ParRol.SqlDbType = SqlDbType.VarChar;
                ParRol.Size = 20;
                ParRol.Value = Employee.Rol;
                SqlCmd.Parameters.Add(ParRol);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@usuario";
                ParUser.SqlDbType = SqlDbType.VarChar;
                ParUser.Size = 50;
                ParUser.Value = Employee.User;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPass = new SqlParameter();
                ParPass.ParameterName = "@password";
                ParPass.SqlDbType = SqlDbType.VarChar;
                ParPass.Size = 50;
                ParPass.Value = Employee.Pass;
                SqlCmd.Parameters.Add(ParPass);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido modificar el registro";
            }
            catch (Exception e)
            {
                res = e.Message;
            }
            finally
            {
                // Close connection
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return res;
        }

        public string Delete(EmployeeData Employee)
        {
            string res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                // Connection
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                // Comand
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "peliminar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_empleado";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Employee.IdEmployee;
                SqlCmd.Parameters.Add(ParId);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido eliminar el registro";
            }
            catch (Exception e)
            {
                res = e.Message;
            }
            finally
            {
                // Close connection
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return res;
        }

        public DataTable Show()
        {
            DataTable DataTableRes = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlAdapter = new SqlDataAdapter(SqlCmd);
                SqlAdapter.Fill(DataTableRes);
            }
            catch (Exception e)
            {
                DataTableRes = null;
                Console.WriteLine(e);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return DataTableRes;

        }

        public DataTable FindByComboBox(string procedure, string param, EmployeeData Employee)
        {
            DataTable DataTableRes = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = procedure;
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParText = new SqlParameter();
                ParText.ParameterName = param;
                ParText.SqlDbType = SqlDbType.VarChar;
                ParText.Size = 50;
                ParText.Value = Employee.FindText;
                SqlCmd.Parameters.Add(ParText);

                SqlDataAdapter SqlAdapter = new SqlDataAdapter(SqlCmd);
                SqlAdapter.Fill(DataTableRes);
            }
            catch (Exception e)
            {
                DataTableRes = null;
                Console.WriteLine(e);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return DataTableRes;

        }

        public DataTable Login(EmployeeData Employee)
        {
            DataTable DataTableRes = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "plogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@usuario";
                ParUser.SqlDbType = SqlDbType.VarChar;
                ParUser.Size = 50;
                ParUser.Value = Employee.User;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPass = new SqlParameter();
                ParPass.ParameterName = "@password";
                ParPass.SqlDbType = SqlDbType.VarChar;
                ParPass.Size = 50;
                ParPass.Value = Employee.Pass;
                SqlCmd.Parameters.Add(ParPass);

                SqlDataAdapter SqlAdapter = new SqlDataAdapter(SqlCmd);
                SqlAdapter.Fill(DataTableRes);
            }
            catch (Exception e)
            {
                DataTableRes = null;
                Console.WriteLine(e);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return DataTableRes;

        }

        public DataTable ShowTopEmployee()
        {
            DataTable DataTableRes = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_top_empleados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlAdapter = new SqlDataAdapter(SqlCmd);
                SqlAdapter.Fill(DataTableRes);
            }
            catch (Exception e)
            {
                DataTableRes = null;
                Console.WriteLine(e);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return DataTableRes;
        }

        public DataTable NumEmployee()
        {
            DataTable DataTableRes = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_num_empleados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlAdapter = new SqlDataAdapter(SqlCmd);
                SqlAdapter.Fill(DataTableRes);
            }
            catch (Exception e)
            {
                DataTableRes = null;
                Console.WriteLine(e);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return DataTableRes;

        }
        #endregion
    }
}
