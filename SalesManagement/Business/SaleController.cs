using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Business
{
    public class SaleController
    {
        #region Methods
        public static string Insert(DateTime dateSale, string receiptType, string serie, string sequent, decimal iva, int idCustomer, int idEmployee, DataTable dtDetails)
        {
            SaleData DSale = new SaleData();
            DSale.DateSale = dateSale;
            DSale.ReceiptType = receiptType;
            DSale.Serie = serie;
            DSale.Sequent = sequent;
            DSale.Iva = iva;
            DSale.IdCustomer = idCustomer;
            DSale.IdEmployee = idEmployee;

            List<SaleDetailData> saleDetails = new List<SaleDetailData>();
            foreach (DataRow row in dtDetails.Rows)
            {
                SaleDetailData detail = new SaleDetailData();
                detail.IdEntryDetail = Convert.ToInt32(row["id_detalle_entrada"].ToString());
                detail.Amount = Convert.ToInt32(row["cantidad"].ToString());
                detail.PriceSale = Convert.ToDecimal(row["precio_venta"].ToString());
                detail.Discount = Convert.ToDecimal(row["descuento"].ToString());
                saleDetails.Add(detail);
            }
            return DSale.Insert(DSale, saleDetails);
        }

        public static string Delete(int idSale)
        {
            SaleData DSale = new SaleData();
            DSale.IdSale = idSale;
            return DSale.Delete(DSale);
        }

        public static DataTable Show()
        {
            return new SaleData().Show();
        }

        public static DataTable FindByDate(string InitDate, string EndDate)
        {
            SaleData DSale= new SaleData();
            return DSale.FindByDate(InitDate, EndDate);
        }

        public static DataTable ShowDetail(string IdSale)
        {
            SaleData DSale = new SaleData();
            return DSale.ShowDetail(IdSale);
        }

        public static DataTable ShowItemToSaleByName(string Name)
        {
            SaleData DSale = new SaleData();
            return DSale.ShowItemToSaleByName(Name);
        }

        public static DataTable ShowItemToSaleByCode(string Code)
        {
            SaleData DSale = new SaleData();
            return DSale.ShowItemToSaleByCode(Code);
        }
        public static DataTable ShowLastSales()
        {
            return new SaleData().ShowLastSales();
        }

        #endregion
    }
}
