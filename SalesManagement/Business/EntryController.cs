using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Business
{
    public class EntryController
    {
        #region Methods
        public static string Insert(DateTime dateEntry, string receiptType, string serie, string sequent, decimal iva, string status, int idEmployee, int idProvider, DataTable dtDetails)
        {
            EntryData DEntry = new EntryData();
            DEntry.DateEntry = dateEntry;
            DEntry.ReceiptType = receiptType;
            DEntry.Serie = serie;
            DEntry.Sequent = sequent;
            DEntry.Iva = iva;
            DEntry.Status = status;
            DEntry.IdEmployee = idEmployee;
            DEntry.IdProvider = idProvider;

            List<EntryDetailData> entryDetails = new List<EntryDetailData>();
            foreach(DataRow row in dtDetails.Rows)
            {
                EntryDetailData detail = new EntryDetailData();
                detail.IdItem = Convert.ToInt32(row["id_articulo"].ToString());
                detail.PriceBuy = Convert.ToDecimal(row["precio_compra"].ToString());
                detail.PriceSale = Convert.ToDecimal(row["precio_venta"].ToString());
                detail.StockIni = Convert.ToInt32(row["stock_inicial"].ToString());
                detail.StockCurrent = Convert.ToInt32(row["stock_inicial"].ToString());
                detail.Fecha = Convert.ToDateTime(row["fecha_produccion"].ToString());
                entryDetails.Add(detail);
            }
            return DEntry.Insert(DEntry, entryDetails);
        }

        public static string Cancel(int idEntry)
        {
            EntryData DEntry = new EntryData();
            DEntry.IdEntry = idEntry;
            return DEntry.Cancel(DEntry);
        }

        public static DataTable Show()
        {
            return new EntryData().Show();
        }

        public static DataTable FindByDate(string InitDate, string EndDate)
        {
            EntryData DEntry = new EntryData();
            return DEntry.FindByDate(InitDate, EndDate);
        }

        public static DataTable ShowDetail(string IdEntry)
        {
            EntryData DEntry = new EntryData();
            return DEntry.ShowDetail(IdEntry);
        }

        #endregion
    }
}
