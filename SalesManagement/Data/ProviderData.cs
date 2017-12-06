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

        #endregion

        #region Methods

        #endregion
    }
}
