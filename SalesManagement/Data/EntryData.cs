using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class EntryData
    {
        private int _IdEntry;
        private DateTime _DateEntry;
        private string _ReceiptType;
        private string _Serie;
        private string _Sequent;
        private decimal _Iva;
        private string _Status;
        private int _IdEmployee;
        private int _IdProvider;

        #region Get y Set
        public int IdEntry
        {
            get
            {
                return _IdEntry;
            }

            set
            {
                _IdEntry = value;
            }
        }

        public DateTime DateEntry
        {
            get
            {
                return _DateEntry;
            }

            set
            {
                _DateEntry = value;
            }
        }

        public string ReceiptType
        {
            get
            {
                return _ReceiptType;
            }

            set
            {
                _ReceiptType = value;
            }
        }

        public string Serie
        {
            get
            {
                return _Serie;
            }

            set
            {
                _Serie = value;
            }
        }

        public string Sequent
        {
            get
            {
                return _Sequent;
            }

            set
            {
                _Sequent = value;
            }
        }

        public decimal Iva
        {
            get
            {
                return _Iva;
            }

            set
            {
                _Iva = value;
            }
        }

        public string Status
        {
            get
            {
                return _Status;
            }

            set
            {
                _Status = value;
            }
        }

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

        #endregion

        #region Constructor
        public EntryData() { }

        public EntryData(int idEntry, DateTime dateEntry, string receiptType, string serie, string sequent, decimal iva, string status, int idEmployee, int idProvider)
        {
            this.IdEntry = idEntry;
            this.DateEntry = dateEntry;
            this.ReceiptType = receiptType;
            this.Serie = serie;
            this.Sequent = sequent;
            this.Iva = iva;
            this.Status = status;
            this.IdEmployee = idEmployee;
            this.IdProvider = idProvider;
        }
        #endregion

        #region Methods
        public string Insert(EntryData Entry, List<EntryDetailData> ListEntryDetail)
        {
            string res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                // Connection
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                // Transaction
                SqlTransaction SqlTst = SqlCon.BeginTransaction();

                // Comand
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTst;
                SqlCmd.CommandText = "pinsertar_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdEmployee = new SqlParameter();
                ParIdEmployee.ParameterName = "@id_empleado";
                ParIdEmployee.SqlDbType = SqlDbType.Int;
                ParIdEmployee.Value = Entry.IdEmployee;
                SqlCmd.Parameters.Add(ParIdEmployee);

                SqlParameter ParIdProvider = new SqlParameter();
                ParIdProvider.ParameterName = "@id_proveedor";
                ParIdProvider.SqlDbType = SqlDbType.Int;
                ParIdProvider.Value = Entry.IdProvider;
                SqlCmd.Parameters.Add(ParIdProvider);

                SqlParameter ParDate = new SqlParameter();
                ParDate.ParameterName = "@fecha";
                ParDate.SqlDbType = SqlDbType.Date;
                ParDate.Value = Entry.DateEntry;
                SqlCmd.Parameters.Add(ParDate);

                SqlParameter ParReceiptType = new SqlParameter();
                ParReceiptType.ParameterName = "@tipo_recibo";
                ParReceiptType.SqlDbType = SqlDbType.VarChar;
                ParReceiptType.Size = 50;
                ParReceiptType.Value = Entry.ReceiptType;
                SqlCmd.Parameters.Add(ParReceiptType);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 4;
                ParSerie.Value = Entry.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                SqlParameter ParSequent = new SqlParameter();
                ParSequent.ParameterName = "@consecutivo";
                ParSequent.SqlDbType = SqlDbType.VarChar;
                ParSequent.Size = 8;
                ParSequent.Value = Entry.Sequent;
                SqlCmd.Parameters.Add(ParSequent);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Precision = 4;
                ParIva.Scale = 2;
                ParIva.Value = Entry.Iva;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParStatus = new SqlParameter();
                ParStatus.ParameterName = "@estado";
                ParStatus.SqlDbType = SqlDbType.VarChar;
                ParStatus.Size = 10;
                ParStatus.Value = Entry.Status;
                SqlCmd.Parameters.Add(ParStatus);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido insertar el registro";

                if (res.Equals("Correcto"))
                {
                    // Get Entry ID
                    this.IdEntry = Convert.ToInt32(SqlCmd.Parameters["@id_entrada"].Value);
                    foreach(EntryDetailData detail in ListEntryDetail)
                    {
                        detail.IdEntry = this.IdEntry;
                        res = detail.Insert(detail, ref SqlCon, ref SqlTst);
                        if (!res.Equals("Correcto"))
                        {
                            break;
                        }
                    }
                }

                if (res.Equals("Correcto"))
                {
                    SqlTst.Commit();
                }
                else
                {
                    SqlTst.Rollback();
                }

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

        public string Cancel(EntryData Entry)
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
                SqlCmd.CommandText = "pcancelar_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Entry.IdEntry;
                SqlCmd.Parameters.Add(ParId);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido anular el registro";
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
            DataTable DataTableRes = new DataTable("entrada");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_entrada";
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

        public DataTable FindByDate(String InitDate, String EndDate)
        {
            DataTable DataTableRes = new DataTable("entrada");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscar_entrada_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParInitDate = new SqlParameter();
                ParInitDate.ParameterName = "@fechaini";
                ParInitDate.SqlDbType = SqlDbType.VarChar;
                ParInitDate.Size = 20;
                ParInitDate.Value = InitDate;
                SqlCmd.Parameters.Add(ParInitDate);

                SqlParameter ParEndDate = new SqlParameter();
                ParEndDate.ParameterName = "@fechafin";
                ParEndDate.SqlDbType = SqlDbType.VarChar;
                ParEndDate.Size = 20;
                ParEndDate.Value = EndDate;
                SqlCmd.Parameters.Add(ParEndDate);

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

        public DataTable ShowDetail(String IdEntry)
        {
            DataTable DataTableRes = new DataTable("detalle_entrada");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_detalle_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = IdEntry;
                SqlCmd.Parameters.Add(ParId);

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
