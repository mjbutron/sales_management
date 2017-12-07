using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class CustomerData
    {
        private int _IdCustomer;
        private string _Name;
        private string _LastName;
        private string _Sex;
        private DateTime _Birthdate;
        private string _TypeDoc;
        private string _NumDoc;
        private string _Address;
        private string _Phone;
        private string _Email;

        private string _FindText;

        #region Get y Set
        public int IdCustomer
        {
            get
            {
                return _IdCustomer;
            }

            set
            {
                _IdCustomer = value;
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

        public string TypeDoc
        {
            get
            {
                return _TypeDoc;
            }

            set
            {
                _TypeDoc = value;
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
        public CustomerData() { }

        public CustomerData(int idCus, string name, string lastName, string sex, DateTime birthdate, string typeDoc, string numDoc, string address, string phone, string email, string text)
        {
            this.IdCustomer = idCus;
            this.Name = name;
            this.LastName = lastName;
            this.Sex = sex;
            this.Birthdate = birthdate;
            this.TypeDoc = typeDoc;
            this.NumDoc = numDoc;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.FindText = text;
        }
        #endregion

        #region Methods
        public string Insert(CustomerData Customer)
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
                SqlCmd.CommandText = "pinsertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_cliente";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 50;
                ParName.Value = Customer.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParLastName = new SqlParameter();
                ParLastName.ParameterName = "@apellidos";
                ParLastName.SqlDbType = SqlDbType.VarChar;
                ParLastName.Size = 50;
                ParLastName.Value = Customer.LastName;
                SqlCmd.Parameters.Add(ParLastName);

                SqlParameter ParSex = new SqlParameter();
                ParSex.ParameterName = "@sexo";
                ParSex.SqlDbType = SqlDbType.VarChar;
                ParSex.Size = 1;
                ParSex.Value = Customer.Sex;
                SqlCmd.Parameters.Add(ParSex);

                SqlParameter ParBirthdate = new SqlParameter();
                ParBirthdate.ParameterName = "@fecha_nacimiento";
                ParBirthdate.SqlDbType = SqlDbType.DateTime;
                ParBirthdate.Value = Customer.Birthdate;
                SqlCmd.Parameters.Add(ParBirthdate);

                SqlParameter ParTypeDoc = new SqlParameter();
                ParTypeDoc.ParameterName = "@tipo_documento";
                ParTypeDoc.SqlDbType = SqlDbType.VarChar;
                ParTypeDoc.Size = 50;
                ParTypeDoc.Value = Customer.TypeDoc;
                SqlCmd.Parameters.Add(ParTypeDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@num_documento";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 15;
                ParNumDoc.Value = Customer.NumDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 150;
                ParAddress.Value = Customer.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParPhone = new SqlParameter();
                ParPhone.ParameterName = "@telefono";
                ParPhone.SqlDbType = SqlDbType.VarChar;
                ParPhone.Size = 10;
                ParPhone.Value = Customer.Phone;
                SqlCmd.Parameters.Add(ParPhone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Customer.Email;
                SqlCmd.Parameters.Add(ParEmail);
  
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

        public string Edit(CustomerData Customer)
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
                SqlCmd.CommandText = "peditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_cliente";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Customer.IdCustomer;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 50;
                ParName.Value = Customer.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParLastName = new SqlParameter();
                ParLastName.ParameterName = "@apellidos";
                ParLastName.SqlDbType = SqlDbType.VarChar;
                ParLastName.Size = 50;
                ParLastName.Value = Customer.LastName;
                SqlCmd.Parameters.Add(ParLastName);

                SqlParameter ParSex = new SqlParameter();
                ParSex.ParameterName = "@sexo";
                ParSex.SqlDbType = SqlDbType.VarChar;
                ParSex.Size = 1;
                ParSex.Value = Customer.Sex;
                SqlCmd.Parameters.Add(ParSex);

                SqlParameter ParBirthdate = new SqlParameter();
                ParBirthdate.ParameterName = "@fecha_nacimiento";
                ParBirthdate.SqlDbType = SqlDbType.DateTime;
                ParBirthdate.Value = Customer.Birthdate;
                SqlCmd.Parameters.Add(ParBirthdate);

                SqlParameter ParTypeDoc = new SqlParameter();
                ParTypeDoc.ParameterName = "@tipo_documento";
                ParTypeDoc.SqlDbType = SqlDbType.VarChar;
                ParTypeDoc.Size = 50;
                ParTypeDoc.Value = Customer.TypeDoc;
                SqlCmd.Parameters.Add(ParTypeDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@num_documento";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 15;
                ParNumDoc.Value = Customer.NumDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 150;
                ParAddress.Value = Customer.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParPhone = new SqlParameter();
                ParPhone.ParameterName = "@telefono";
                ParPhone.SqlDbType = SqlDbType.VarChar;
                ParPhone.Size = 10;
                ParPhone.Value = Customer.Phone;
                SqlCmd.Parameters.Add(ParPhone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Customer.Email;
                SqlCmd.Parameters.Add(ParEmail);

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

        public string Delete(CustomerData Customer)
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
                SqlCmd.CommandText = "peliminar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_cliente";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Customer.IdCustomer;
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
            DataTable DataTableRes = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_cliente";
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

        public DataTable FindByLastName(CustomerData Customer)
        {
            DataTable DataTableRes = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscarapellidos_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParText = new SqlParameter();
                ParText.ParameterName = "@apellidos";
                ParText.SqlDbType = SqlDbType.VarChar;
                ParText.Size = 50;
                ParText.Value = Customer.FindText;
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

        public DataTable FindByNumDoc(CustomerData Customer)
        {
            DataTable DataTableRes = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscar_cliente_documento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParText = new SqlParameter();
                ParText.ParameterName = "@num_documento";
                ParText.SqlDbType = SqlDbType.VarChar;
                ParText.Size = 15;
                ParText.Value = Customer.FindText;
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
        #endregion
    }
}
