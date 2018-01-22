using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class SaleDetailData
    {
        private int _IdSaleDetail;
        private int _Amount;
        private decimal _PriceSale;
        private decimal _Discount;
        private int _IdSale;
        private int _IdEntryDetail;

        #region Get y Set
        public int IdSaleDetail
        {
            get
            {
                return _IdSaleDetail;
            }

            set
            {
                _IdSaleDetail = value;
            }
        }

        public int Amount
        {
            get
            {
                return _Amount;
            }

            set
            {
                _Amount = value;
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

        public decimal Discount
        {
            get
            {
                return _Discount;
            }

            set
            {
                _Discount = value;
            }
        }

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
        #endregion

        #region Constructor
        public SaleDetailData() { }

        public SaleDetailData(int idSaleDet, int amount, decimal priceSale, decimal discount, int idSale, int idEntryDetail)
        {
            this.IdSaleDetail = idSaleDet;
            this.Amount = amount;
            this.PriceSale = priceSale;
            this.Discount = discount;
            this.IdSale = idSale;
            this.IdEntryDetail = idEntryDetail;
        }
        #endregion

        #region Methods
        public string Insert(SaleDetailData SaleDetail, ref SqlConnection SqlCon, ref SqlTransaction Trans)
        {
            string res = "";
            try
            {
                // Comand
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = Trans;
                SqlCmd.CommandText = "pinsertar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parameters
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id_detalle_venta";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdSale = new SqlParameter();
                ParIdSale.ParameterName = "@id_venta";
                ParIdSale.SqlDbType = SqlDbType.Int;
                ParIdSale.Value = SaleDetail.IdSale;
                SqlCmd.Parameters.Add(ParIdSale);

                SqlParameter ParIdEntryDetail = new SqlParameter();
                ParIdEntryDetail.ParameterName = "@id_detalle_entrada";
                ParIdEntryDetail.SqlDbType = SqlDbType.Int;
                ParIdEntryDetail.Value = SaleDetail.IdEntryDetail;
                SqlCmd.Parameters.Add(ParIdEntryDetail);

                SqlParameter ParAmount = new SqlParameter();
                ParAmount.ParameterName = "@cantidad";
                ParAmount.SqlDbType = SqlDbType.Int;
                ParAmount.Value = SaleDetail.Amount;
                SqlCmd.Parameters.Add(ParAmount);

                SqlParameter ParPriceSale = new SqlParameter();
                ParPriceSale.ParameterName = "@precio_venta";
                ParPriceSale.SqlDbType = SqlDbType.Money;
                ParPriceSale.Value = SaleDetail.PriceSale;
                SqlCmd.Parameters.Add(ParPriceSale);

                SqlParameter ParDiscount = new SqlParameter();
                ParDiscount.ParameterName = "@descuento";
                ParDiscount.SqlDbType = SqlDbType.Money;
                ParDiscount.Value = SaleDetail.Discount;
                SqlCmd.Parameters.Add(ParDiscount);



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
