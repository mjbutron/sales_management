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

    }
}
