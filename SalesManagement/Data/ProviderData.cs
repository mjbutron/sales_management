using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class ProviderData
    {
        private int _IdProvider;
        private string _BusinessName;
        private string _Sector;
        private string _TypeDoc;
        private string _NumDoc;
        private string _Address;
        private string _Phone;
        private string _Mobile;
        private string _Fax;
        private string _Email;
        private string _Web;

        private string _FindText;

        #region Get y Set
        public int IdProvider
        {
            get
            {
                return _IdProvider;
            }

            set
            {
                _IdProvider = value;
            }
        }

        public string BusinessName
        {
            get
            {
                return _BusinessName;
            }

            set
            {
                _BusinessName = value;
            }
        }

        public string Sector
        {
            get
            {
                return _Sector;
            }

            set
            {
                _Sector = value;
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

        public string Mobile
        {
            get
            {
                return _Mobile;
            }

            set
            {
                _Mobile = value;
            }
        }

        public string Fax
        {
            get
            {
                return _Fax;
            }

            set
            {
                _Fax = value;
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

        public string Web
        {
            get
            {
                return _Web;
            }

            set
            {
                _Web = value;
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
        public ProviderData() { }

        public ProviderData(int idPro, string businessName, string sector, string typeDoc, string numDoc, string address, string phone, string mobile, string fax, string email, string web, string text)
        {
            this.IdProvider = idPro;
            this.BusinessName = businessName;
            this.Sector = sector;
            this.TypeDoc = typeDoc;
            this.NumDoc = numDoc;
            this.Address = address;
            this.Phone = phone;
            this.Mobile = mobile;
            this.Fax = fax;
            this.Email = email;
            this.Web = web;
            this.FindText = text;
        }

        #endregion

        #region Methods
        public string Insert(ProviderData Provider)
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
                SqlCmd.CommandText = "pinsertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_proveedor";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParBName = new SqlParameter();
                ParBName.ParameterName = "@razon_social";
                ParBName.SqlDbType = SqlDbType.VarChar;
                ParBName.Size = 150;
                ParBName.Value = Provider.BusinessName;
                SqlCmd.Parameters.Add(ParBName);

                SqlParameter ParSector = new SqlParameter();
                ParSector.ParameterName = "@sector";
                ParSector.SqlDbType = SqlDbType.VarChar;
                ParSector.Size = 50;
                ParSector.Value = Provider.Sector;
                SqlCmd.Parameters.Add(ParSector);

                SqlParameter ParTypeDoc = new SqlParameter();
                ParTypeDoc.ParameterName = "@tipo_documento";
                ParTypeDoc.SqlDbType = SqlDbType.VarChar;
                ParTypeDoc.Size = 50;
                ParTypeDoc.Value = Provider.TypeDoc;
                SqlCmd.Parameters.Add(ParTypeDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@num_documento";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 15;
                ParNumDoc.Value = Provider.NumDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 150;
                ParAddress.Value = Provider.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParPhone = new SqlParameter();
                ParPhone.ParameterName = "@telefono";
                ParPhone.SqlDbType = SqlDbType.VarChar;
                ParPhone.Size = 10;
                ParPhone.Value = Provider.Phone;
                SqlCmd.Parameters.Add(ParPhone);

                SqlParameter ParMobile = new SqlParameter();
                ParMobile.ParameterName = "@movil";
                ParMobile.SqlDbType = SqlDbType.VarChar;
                ParMobile.Size = 12;
                ParMobile.Value = Provider.Mobile;
                SqlCmd.Parameters.Add(ParMobile);

                SqlParameter ParFax = new SqlParameter();
                ParFax.ParameterName = "@fax";
                ParFax.SqlDbType = SqlDbType.VarChar;
                ParFax.Size = 12;
                ParFax.Value = Provider.Fax;
                SqlCmd.Parameters.Add(ParFax);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Provider.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParWeb = new SqlParameter();
                ParWeb.ParameterName = "@web";
                ParWeb.SqlDbType = SqlDbType.VarChar;
                ParWeb.Size = 150;
                ParWeb.Value = Provider.Web;
                SqlCmd.Parameters.Add(ParWeb);

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

        public string Edit(ProviderData Provider)
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
                SqlCmd.CommandText = "peditar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_proveedor";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Provider.IdProvider;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParBName = new SqlParameter();
                ParBName.ParameterName = "@razon_social";
                ParBName.SqlDbType = SqlDbType.VarChar;
                ParBName.Size = 150;
                ParBName.Value = Provider.BusinessName;
                SqlCmd.Parameters.Add(ParBName);

                SqlParameter ParSector = new SqlParameter();
                ParSector.ParameterName = "@sector";
                ParSector.SqlDbType = SqlDbType.VarChar;
                ParSector.Size = 50;
                ParSector.Value = Provider.Sector;
                SqlCmd.Parameters.Add(ParSector);

                SqlParameter ParTypeDoc = new SqlParameter();
                ParTypeDoc.ParameterName = "@tipo_documento";
                ParTypeDoc.SqlDbType = SqlDbType.VarChar;
                ParTypeDoc.Size = 50;
                ParTypeDoc.Value = Provider.TypeDoc;
                SqlCmd.Parameters.Add(ParTypeDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@num_documento";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 15;
                ParNumDoc.Value = Provider.NumDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParAddress = new SqlParameter();
                ParAddress.ParameterName = "@direccion";
                ParAddress.SqlDbType = SqlDbType.VarChar;
                ParAddress.Size = 150;
                ParAddress.Value = Provider.Address;
                SqlCmd.Parameters.Add(ParAddress);

                SqlParameter ParPhone = new SqlParameter();
                ParPhone.ParameterName = "@telefono";
                ParPhone.SqlDbType = SqlDbType.VarChar;
                ParPhone.Size = 10;
                ParPhone.Value = Provider.Phone;
                SqlCmd.Parameters.Add(ParPhone);

                SqlParameter ParMobile = new SqlParameter();
                ParMobile.ParameterName = "@movil";
                ParMobile.SqlDbType = SqlDbType.VarChar;
                ParMobile.Size = 12;
                ParMobile.Value = Provider.Mobile;
                SqlCmd.Parameters.Add(ParMobile);

                SqlParameter ParFax = new SqlParameter();
                ParFax.ParameterName = "@fax";
                ParFax.SqlDbType = SqlDbType.VarChar;
                ParFax.Size = 12;
                ParFax.Value = Provider.Fax;
                SqlCmd.Parameters.Add(ParFax);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Provider.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParWeb = new SqlParameter();
                ParWeb.ParameterName = "@web";
                ParWeb.SqlDbType = SqlDbType.VarChar;
                ParWeb.Size = 150;
                ParWeb.Value = Provider.Web;
                SqlCmd.Parameters.Add(ParWeb);

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

        public string Delete(ProviderData Provider)
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
                SqlCmd.CommandText = "peliminar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_proveedor";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Provider.IdProvider;
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
            DataTable DataTableRes = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_proveedor";
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

        public DataTable FindByBusinessName(ProviderData Provider)
        {
            DataTable DataTableRes = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParText = new SqlParameter();
                ParText.ParameterName = "@razon_social";
                ParText.SqlDbType = SqlDbType.VarChar;
                ParText.Size = 150;
                ParText.Value = Provider.FindText;
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

        public DataTable FindByNumDoc(ProviderData Provider)
        {
            DataTable DataTableRes = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscar_proveedor_doc";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParText = new SqlParameter();
                ParText.ParameterName = "@num_documento";
                ParText.SqlDbType = SqlDbType.VarChar;
                ParText.Size = 15;
                ParText.Value = Provider.FindText;
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
