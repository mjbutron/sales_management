using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class CategoryData
    {
        private int _IdCategory;
        private string _Name;
        private string _Description;
        
        private string _FindText;

        #region Get y Set
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
        public CategoryData(){}

        public CategoryData(int idCat, string nameCat, string descriptionCat, string text)
        {
            this.IdCategory = idCat;
            this.Name = nameCat;
            this.Description = descriptionCat;
            this.FindText = text;
        }
        #endregion

        #region Methods
        public string Insert(CategoryData Category)
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
                SqlCmd.CommandText = "pinsertar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_categoria";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNameCat = new SqlParameter();
                ParNameCat.ParameterName = "@nombre";
                ParNameCat.SqlDbType = SqlDbType.VarChar;
                ParNameCat.Size = 50;
                ParNameCat.Value = Category.Name;
                SqlCmd.Parameters.Add(ParNameCat);

                SqlParameter ParDescriptionCat = new SqlParameter();
                ParDescriptionCat.ParameterName = "@descripcion";
                ParDescriptionCat.SqlDbType = SqlDbType.VarChar;
                ParDescriptionCat.Size = 512;
                ParDescriptionCat.Value = Category.Description;
                SqlCmd.Parameters.Add(ParDescriptionCat);

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

        public string Edit(CategoryData Category)
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
                SqlCmd.CommandText = "peditar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_categoria";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Category.IdCategory;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNameCat = new SqlParameter();
                ParNameCat.ParameterName = "@nombre";
                ParNameCat.SqlDbType = SqlDbType.VarChar;
                ParNameCat.Size = 50;
                ParNameCat.Value = Category.Name;
                SqlCmd.Parameters.Add(ParNameCat);

                SqlParameter ParDescriptionCat = new SqlParameter();
                ParDescriptionCat.ParameterName = "@descripcion";
                ParDescriptionCat.SqlDbType = SqlDbType.VarChar;
                ParDescriptionCat.Size = 512;
                ParDescriptionCat.Value = Category.Description;
                SqlCmd.Parameters.Add(ParDescriptionCat);

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

        public string Delete(CategoryData Category)
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
                SqlCmd.CommandText = "peliminar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_categoria";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Category.IdCategory;
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
            DataTable DataTableRes = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_categoria";
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

        public DataTable FindByName(CategoryData Category)
        {
            DataTable DataTableRes = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscarnombre_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextCat = new SqlParameter();
                ParTextCat.ParameterName = "@nombre";
                ParTextCat.SqlDbType = SqlDbType.VarChar;
                ParTextCat.Size = 50;
                ParTextCat.Value = Category.FindText;
                SqlCmd.Parameters.Add(ParTextCat);

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

        public DataTable NumCategory()
        {
            DataTable DataTableRes = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_num_categorias";
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
