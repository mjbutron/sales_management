using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class EntryDetailData
    {
        private int _IdEntryDetail;
        private decimal _PriceBuy;
        private decimal _PriceSale;
        private int _StockIni;
        private int _StockCurrent;
        private DateTime _Fecha;
        private int _IdEntry;
        private int _IdItem;

        #region Get y Set
        public int IdEntryDetail
        {
            get
            {
                return _IdEntryDetail;
            }

            set
            {
                _IdEntryDetail = value;
            }
        }

        public decimal PriceBuy
        {
            get
            {
                return _PriceBuy;
            }

            set
            {
                _PriceBuy = value;
            }
        }

        public decimal PriceSale
        {
            get
            {
                return _PriceSale;
            }

            set
            {
                _PriceSale = value;
            }
        }

        public int StockIni
        {
            get
            {
                return _StockIni;
            }

            set
            {
                _StockIni = value;
            }
        }

        public int StockCurrent
        {
            get
            {
                return _StockCurrent;
            }

            set
            {
                _StockCurrent = value;
            }
        }

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

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }
        #endregion

        #region Constructor
        public EntryDetailData() { }

        public EntryDetailData(int idEntryDet, decimal priceBuy, decimal priceSale, int stockIni, int stockCurrent, DateTime dateProduction, int idEntry, int idItem)
        {
            this.IdEntryDetail = idEntryDet;
            this.PriceBuy = priceBuy;
            this.PriceSale = priceSale;
            this.StockIni = stockIni;
            this.StockCurrent = stockCurrent;
            this.Fecha = dateProduction;
            this.IdEntry = idEntry;
            this.IdItem = idItem;
        }
        #endregion

        #region Methods
        public string Insert(EntryDetailData EntryDetail, ref SqlConnection SqlCon, ref SqlTransaction Trans)
        {
            string res = "";
            try
            {
                // Comand
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = Trans;
                SqlCmd.CommandText = "pinsertar_detalle_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_detalle_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdEntry = new SqlParameter();
                ParIdEntry.ParameterName = "@id_entrada";
                ParIdEntry.SqlDbType = SqlDbType.Int;
                ParIdEntry.Value = EntryDetail.IdEntry;
                SqlCmd.Parameters.Add(ParIdEntry);

                SqlParameter ParIdItem = new SqlParameter();
                ParIdItem.ParameterName = "@id_articulo";
                ParIdItem.SqlDbType = SqlDbType.Int;
                ParIdItem.Value = EntryDetail.IdItem;
                SqlCmd.Parameters.Add(ParIdItem);

                SqlParameter ParPriceBuy = new SqlParameter();
                ParPriceBuy.ParameterName = "@precio_compra";
                ParPriceBuy.SqlDbType = SqlDbType.Money;
                ParPriceBuy.Value = EntryDetail.PriceBuy;
                SqlCmd.Parameters.Add(ParPriceBuy);

                SqlParameter ParPriceSale = new SqlParameter();
                ParPriceSale.ParameterName = "@precio_venta";
                ParPriceSale.SqlDbType = SqlDbType.Money;
                ParPriceSale.Value = EntryDetail.PriceSale;
                SqlCmd.Parameters.Add(ParPriceSale);

                SqlParameter ParStockIni = new SqlParameter();
                ParStockIni.ParameterName = "@stock_inicial";
                ParStockIni.SqlDbType = SqlDbType.Int;
                ParStockIni.Value = EntryDetail.StockIni;
                SqlCmd.Parameters.Add(ParStockIni);

                SqlParameter ParStockCur = new SqlParameter();
                ParStockCur.ParameterName = "@stock_actual";
                ParStockCur.SqlDbType = SqlDbType.Int;
                ParStockCur.Value = EntryDetail.StockCurrent;
                SqlCmd.Parameters.Add(ParStockCur);

                SqlParameter ParDateProd = new SqlParameter();
                ParDateProd.ParameterName = "@fecha_produccion";
                ParDateProd.SqlDbType = SqlDbType.Date;
                ParDateProd.Value = EntryDetail.Fecha;
                SqlCmd.Parameters.Add(ParDateProd);

                // Execute
                res = SqlCmd.ExecuteNonQuery() == 1 ? "Correcto" : "No se ha podido insertar el registro";
            }
            catch (Exception e)
            {
                res = e.Message;
            }
            
            return res;
        }

        #endregion
    }
}
