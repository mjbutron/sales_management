using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class ItemData
    {
        private int _IdItem;
        private string _CodeItem;
        private string _Name;
        private string _Description;
        private byte[] _Image;
        private int _IdCategory;

        private string _FindText;

        #region Get y Set
        public int IdItem
        {
            get
            {
                return _IdItem;
            }

            set
            {
                _IdItem = value;
            }
        }

        public string CodeItem
        {
            get
            {
                return _CodeItem;
            }

            set
            {
                _CodeItem = value;
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

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public byte[] Image
        {
            get
            {
                return _Image;
            }

            set
            {
                _Image = value;
            }
        }

        public int IdCategory
        {
            get
            {
                return _IdCategory;
            }

            set
            {
                _IdCategory = value;
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
        public ItemData() { }

        public ItemData(int idIt, string codeIt,string nameIt, string descriptionIt, byte[] imageIt, int idCat ,string text)
        {
            this.IdItem = idIt;
            this.CodeItem = codeIt;
            this.Name = nameIt;
            this.Description = descriptionIt;
            this.Image = imageIt;
            this.IdCategory = idCat;
            this.FindText = text;
        }

        #endregion

        #region Methods
        public string Insert(ItemData Item)
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
                SqlCmd.CommandText = "pinsertar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_articulo";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParCodeIt = new SqlParameter();
                ParCodeIt.ParameterName = "@codigo";
                ParCodeIt.SqlDbType = SqlDbType.VarChar;
                ParCodeIt.Size = 50;
                ParCodeIt.Value = Item.CodeItem;
                SqlCmd.Parameters.Add(ParCodeIt);

                SqlParameter ParNameIt = new SqlParameter();
                ParNameIt.ParameterName = "@nombre";
                ParNameIt.SqlDbType = SqlDbType.VarChar;
                ParNameIt.Size = 50;
                ParNameIt.Value = Item.Name;
                SqlCmd.Parameters.Add(ParNameIt);

                SqlParameter ParDescriptionIt = new SqlParameter();
                ParDescriptionIt.ParameterName = "@descripcion";
                ParDescriptionIt.SqlDbType = SqlDbType.VarChar;
                ParDescriptionIt.Size = 512;
                ParDescriptionIt.Value = Item.Description;
                SqlCmd.Parameters.Add(ParDescriptionIt);

                SqlParameter ParImageIt = new SqlParameter();
                ParImageIt.ParameterName = "@image";
                ParImageIt.SqlDbType = SqlDbType.Image;
                ParImageIt.Value = Item.Image;
                SqlCmd.Parameters.Add(ParImageIt);

                SqlParameter ParIdCat = new SqlParameter();
                ParIdCat.ParameterName = "@id_categoria";
                ParIdCat.SqlDbType = SqlDbType.Int;
                ParIdCat.Value = Item.IdCategory;
                SqlCmd.Parameters.Add(ParIdCat);

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

        public string Edit(ItemData Item)
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
                SqlCmd.CommandText = "peditar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_articulo";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Item.IdItem;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParCodeIt = new SqlParameter();
                ParCodeIt.ParameterName = "@codigo";
                ParCodeIt.SqlDbType = SqlDbType.VarChar;
                ParCodeIt.Size = 50;
                ParCodeIt.Value = Item.CodeItem;
                SqlCmd.Parameters.Add(ParCodeIt);

                SqlParameter ParNameIt = new SqlParameter();
                ParNameIt.ParameterName = "@nombre";
                ParNameIt.SqlDbType = SqlDbType.VarChar;
                ParNameIt.Size = 50;
                ParNameIt.Value = Item.Name;
                SqlCmd.Parameters.Add(ParNameIt);

                SqlParameter ParDescriptionIt = new SqlParameter();
                ParDescriptionIt.ParameterName = "@descripcion";
                ParDescriptionIt.SqlDbType = SqlDbType.VarChar;
                ParDescriptionIt.Size = 512;
                ParDescriptionIt.Value = Item.Description;
                SqlCmd.Parameters.Add(ParDescriptionIt);

                SqlParameter ParImageIt = new SqlParameter();
                ParImageIt.ParameterName = "@imagen";
                ParImageIt.SqlDbType = SqlDbType.Image;
                ParImageIt.Value = Item.Image;
                SqlCmd.Parameters.Add(ParImageIt);

                SqlParameter ParIdCat = new SqlParameter();
                ParIdCat.ParameterName = "@id_categoria";
                ParIdCat.SqlDbType = SqlDbType.Int;
                ParIdCat.Value = Item.IdCategory;
                SqlCmd.Parameters.Add(ParIdCat);

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

        public string Delete(ItemData Item)
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
                SqlCmd.CommandText = "peliminar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_articulo";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Item.IdItem;
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
            DataTable DataTableRes = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_articulo";
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

        public DataTable FindByName(ItemData Item)
        {
            DataTable DataTableRes = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscarnombre_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextIt = new SqlParameter();
                ParTextIt.ParameterName = "@nombre";
                ParTextIt.SqlDbType = SqlDbType.VarChar;
                ParTextIt.Size = 50;
                ParTextIt.Value = Item.FindText;
                SqlCmd.Parameters.Add(ParTextIt);

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
