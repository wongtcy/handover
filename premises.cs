using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handover
{
    public class premises
    {
        public string PremisesID { get; set; }
		public string ProAddressEng { get; set; }
        public string ProAddressChn { get; set; }
		public decimal Share { get; set; }
		public decimal MgtUnit { get; set; }
        public decimal GFA { get; set; }
		public decimal SaleArea { get; set; }
        public decimal BayWindow { get; set; }
        public decimal FlatRoof { get; set; }
        public decimal Roof { get; set; }
        public decimal ChgArea { get; set; }
        public decimal MgtFeeDeposit { get; set; }
        public decimal AdvMgtFee { get; set; }
        public decimal CapitalFund { get; set; }
        public decimal BdgImpFund { get; set; }
        public decimal DecorFund { get; set; }
        public decimal ExtWallFund { get; set; }
        public decimal WaterDeposit { get; set; }
        public decimal ElectDeposit { get; set; }
        public decimal MeterDeposit { get; set; }
        public decimal DebrisDeposit { get; set; }
        public decimal GovernRent { get; set; }
        public string PropertyCode { get; set; }
        public int CardQuota { get; set; }
        public string Payable { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
