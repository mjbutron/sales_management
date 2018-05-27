using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class SaleData
    {
        private int _IdSale;
        private DateTime _DateSale;
        private string _ReceiptType;
        private string _Serie;
        private string _Sequent;
        private decimal _Iva;
        private int _IdCustomer;
        private int _IdEmployee;

        #region Get y Set
        public int IdSale
        {
            get
            {
                return _IdSale;
            }

            set
            {
                _IdSale = value;
            }
        }

        public DateTime DateSale
        {
            get
            {
                return _DateSale;
            }

            set
            {
                _DateSale = value;
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

        #endregion

        #region Constructor
        public SaleData() { }

        public SaleData(int idSale, DateTime dateSale, string receiptType, string serie, string sequent, decimal iva, int idCustomer, int idEmployee)
        {
            this.IdSale = idSale;
            this.DateSale = dateSale;
            this.ReceiptType = receiptType;
            this.Serie = serie;
            this.Sequent = sequent;
            this.Iva = iva;
            this.IdCustomer = idCustomer;
            this.IdEmployee = idEmployee;
        }
        #endregion

        #region Methods
        public string Insert(SaleData Sale, List<SaleDetailData> ListSaleDetail)
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
                SqlCmd.CommandText = "pinsertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_venta";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdCustomer = new SqlParameter();
                ParIdCustomer.ParameterName = "@id_cliente";
                ParIdCustomer.SqlDbType = SqlDbType.Int;
                ParIdCustomer.Value = Sale.IdCustomer;
                SqlCmd.Parameters.Add(ParIdCustomer);

                SqlParameter ParIdEmployee = new SqlParameter();
                ParIdEmployee.ParameterName = "@id_empleado";
                ParIdEmployee.SqlDbType = SqlDbType.Int;
                ParIdEmployee.Value = Sale.IdEmployee;
                SqlCmd.Parameters.Add(ParIdEmployee);

                SqlParameter ParDate = new SqlParameter();
                ParDate.ParameterName = "@fecha";
                ParDate.SqlDbType = SqlDbType.Date;
                ParDate.Value = Sale.DateSale;
                SqlCmd.Parameters.Add(ParDate);

                SqlParameter ParReceiptType = new SqlParameter();
                ParReceiptType.ParameterName = "@tipo_recibo";
                ParReceiptType.SqlDbType = SqlDbType.VarChar;
                ParReceiptType.Size = 50;
                ParReceiptType.Value = Sale.ReceiptType;
                SqlCmd.Parameters.Add(ParReceiptType);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 4;
                ParSerie.Value = Sale.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                SqlParameter ParSequent = new SqlParameter();
                ParSequent.ParameterName = "@consecutivo";
                ParSequent.SqlDbType = SqlDbType.VarChar;
                ParSequent.Size = 8;
                ParSequent.Value = Sale.Sequent;
                SqlCmd.Parameters.Add(ParSequent);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Precision = 4;
                ParIva.Scale = 2;
                ParIva.Value = Sale.Iva;
                SqlCmd.Parameters.Add(ParIva);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido insertar el registro";

                if (res.Equals("Correcto"))
                {
                    // Get Sale ID
                    this.IdSale = Convert.ToInt32(SqlCmd.Parameters["@id_venta"].Value);
                    foreach (SaleDetailData detail in ListSaleDetail)
                    {
                        detail.IdSale = this.IdSale;
                        res = detail.Insert(detail, ref SqlCon, ref SqlTst);
                        if (!res.Equals("Correcto"))
                        {
                            break;
                        }
                        else
                        {
                            // Update Stock
                            res = ReduceStock(detail.IdEntryDetail, detail.Amount);
                            if (!res.Equals("Correcto"))
                            {
                                break;
                            }
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

        public string Delete(SaleData Sale)
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
                SqlCmd.CommandText = "peliminar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_venta";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Sale.IdSale;
                SqlCmd.Parameters.Add(ParId);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "Correcto"; // Igual por el tema de los triggers
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
            DataTable DataTableRes = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_venta";
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
            DataTable DataTableRes = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscar_venta_fecha";
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

        public DataTable ShowDetail(String IdSale)
        {
            DataTable DataTableRes = new DataTable("detalle_venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_venta";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = IdSale;
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

        public string ReduceStock(int idEntryDetail, int amount)
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
                SqlCmd.CommandText = "preducir_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_detalle_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = idEntryDetail;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParAmount = new SqlParameter();
                ParAmount.ParameterName = "@cantidad";
                ParAmount.SqlDbType = SqlDbType.Int;
                ParAmount.Value = amount;
                SqlCmd.Parameters.Add(ParAmount);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido actualizar el stock";
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

        public DataTable ShowItemToSaleByName(String Name)
        {
            DataTable DataTableRes = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscar_articulos_venta_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 50;
                ParName.Value = Name;
                SqlCmd.Parameters.Add(ParName);

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

        public DataTable ShowItemToSaleByCode(String Code)
        {
            DataTable DataTableRes = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pbuscar_articulos_venta_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCode = new SqlParameter();
                ParCode.ParameterName = "@codigo";
                ParCode.SqlDbType = SqlDbType.VarChar;
                ParCode.Size = 50;
                ParCode.Value = Code;
                SqlCmd.Parameters.Add(ParCode);

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

        public DataTable ShowLastSales()
        {
            DataTable DataTableRes = new DataTable("venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Con;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pmostrar_ultimas_venta";
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
