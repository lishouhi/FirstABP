using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class MFT_GENDECL_STATISTICS2_HISTORY
	{
		#region Constructor
		public MFT_GENDECL_STATISTICS2_HISTORY() { }

		public MFT_GENDECL_STATISTICS2_HISTORY(Int32 iNT_YEAR,Int32 iNT_HALFYEAR,Int32 iNT_QUARTER,Int32 iNT_MONTH,Int32 iNT_DAY,DateTime dTE_CREATE_DATE,Int64 bIG_ENTERPRISE_AUID,String nVR_CN_NAME,String iNT_CUSTOMS_CODE,String nVR_CUSTOMS_NAME,Int32 iNT_TOTAL_COUNT,Decimal dEC_PRICE,Decimal dEC_TOTAL_CHARGES,Int32 iNT_MANIFEST_COUNT,Int32 iNT_MANIFEST_I_COUNT,Int32 iNT_MANIFEST_E_COUNT,Int32 iNT_BL_COUNT,Int32 iNT_BL_G_COUNT,Int32 iNT_BL_S_COUNT,Int32 iNT_BL_P_COUNT,Int32 iNT_BL_J_COUNT,Int32 iNT_BL_I_COUNT,Int32 iNT_BL_E_COUNT,Int32 iNT_MANIFEST_J_COUNT,Int32 iNT_J_I_SHIP_COUNT,Int32 iNT_J_E_SHIP_COUNT,Int32 iNT_CHARGE_BACK_MODE,Int32 iNT_IS_TRADELINK,DateTime dTE_CREATE_TIME)
		{
			this.iNT_YEAR = iNT_YEAR;
			this.iNT_HALFYEAR = iNT_HALFYEAR;
			this.iNT_QUARTER = iNT_QUARTER;
			this.iNT_MONTH = iNT_MONTH;
			this.iNT_DAY = iNT_DAY;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.iNT_CUSTOMS_CODE = iNT_CUSTOMS_CODE;
			this.nVR_CUSTOMS_NAME = nVR_CUSTOMS_NAME;
			this.iNT_TOTAL_COUNT = iNT_TOTAL_COUNT;
			this.dEC_PRICE = dEC_PRICE;
			this.dEC_TOTAL_CHARGES = dEC_TOTAL_CHARGES;
			this.iNT_MANIFEST_COUNT = iNT_MANIFEST_COUNT;
			this.iNT_MANIFEST_I_COUNT = iNT_MANIFEST_I_COUNT;
			this.iNT_MANIFEST_E_COUNT = iNT_MANIFEST_E_COUNT;
			this.iNT_BL_COUNT = iNT_BL_COUNT;
			this.iNT_BL_G_COUNT = iNT_BL_G_COUNT;
			this.iNT_BL_S_COUNT = iNT_BL_S_COUNT;
			this.iNT_BL_P_COUNT = iNT_BL_P_COUNT;
			this.iNT_BL_J_COUNT = iNT_BL_J_COUNT;
			this.iNT_BL_I_COUNT = iNT_BL_I_COUNT;
			this.iNT_BL_E_COUNT = iNT_BL_E_COUNT;
			this.iNT_MANIFEST_J_COUNT = iNT_MANIFEST_J_COUNT;
			this.iNT_J_I_SHIP_COUNT = iNT_J_I_SHIP_COUNT;
			this.iNT_J_E_SHIP_COUNT = iNT_J_E_SHIP_COUNT;
			this.iNT_CHARGE_BACK_MODE = iNT_CHARGE_BACK_MODE;
			this.iNT_IS_TRADELINK = iNT_IS_TRADELINK;
			this.dTE_CREATE_TIME = dTE_CREATE_TIME;
		}
		#endregion

		#region Attributes
		private Int32 iNT_YEAR;

		public Int32 INT_YEAR
		{
			get { return iNT_YEAR; }
			set { iNT_YEAR = value; }
		}
		private Int32 iNT_HALFYEAR;

		public Int32 INT_HALFYEAR
		{
			get { return iNT_HALFYEAR; }
			set { iNT_HALFYEAR = value; }
		}
		private Int32 iNT_QUARTER;

		public Int32 INT_QUARTER
		{
			get { return iNT_QUARTER; }
			set { iNT_QUARTER = value; }
		}
		private Int32 iNT_MONTH;

		public Int32 INT_MONTH
		{
			get { return iNT_MONTH; }
			set { iNT_MONTH = value; }
		}
		private Int32 iNT_DAY;

		public Int32 INT_DAY
		{
			get { return iNT_DAY; }
			set { iNT_DAY = value; }
		}
		private DateTime? dTE_CREATE_DATE;

		public DateTime? DTE_CREATE_DATE
		{
			get { return dTE_CREATE_DATE; }
			set { dTE_CREATE_DATE = value; }
		}
		private Int64 bIG_ENTERPRISE_AUID;

		public Int64 BIG_ENTERPRISE_AUID
		{
			get { return bIG_ENTERPRISE_AUID; }
			set { bIG_ENTERPRISE_AUID = value; }
		}
		private String nVR_CN_NAME;

		public String NVR_CN_NAME
		{
			get { return nVR_CN_NAME; }
			set { nVR_CN_NAME = value; }
		}
		private String iNT_CUSTOMS_CODE;

		public String INT_CUSTOMS_CODE
		{
			get { return iNT_CUSTOMS_CODE; }
			set { iNT_CUSTOMS_CODE = value; }
		}
		private String nVR_CUSTOMS_NAME;

		public String NVR_CUSTOMS_NAME
		{
			get { return nVR_CUSTOMS_NAME; }
			set { nVR_CUSTOMS_NAME = value; }
		}
		private Int32 iNT_TOTAL_COUNT;

		public Int32 INT_TOTAL_COUNT
		{
			get { return iNT_TOTAL_COUNT; }
			set { iNT_TOTAL_COUNT = value; }
		}
		private Decimal dEC_PRICE;

		public Decimal DEC_PRICE
		{
			get { return dEC_PRICE; }
			set { dEC_PRICE = value; }
		}
		private Decimal dEC_TOTAL_CHARGES;

		public Decimal DEC_TOTAL_CHARGES
		{
			get { return dEC_TOTAL_CHARGES; }
			set { dEC_TOTAL_CHARGES = value; }
		}
		private Int32 iNT_MANIFEST_COUNT;

		public Int32 INT_MANIFEST_COUNT
		{
			get { return iNT_MANIFEST_COUNT; }
			set { iNT_MANIFEST_COUNT = value; }
		}
		private Int32 iNT_MANIFEST_I_COUNT;

		public Int32 INT_MANIFEST_I_COUNT
		{
			get { return iNT_MANIFEST_I_COUNT; }
			set { iNT_MANIFEST_I_COUNT = value; }
		}
		private Int32 iNT_MANIFEST_E_COUNT;

		public Int32 INT_MANIFEST_E_COUNT
		{
			get { return iNT_MANIFEST_E_COUNT; }
			set { iNT_MANIFEST_E_COUNT = value; }
		}
		private Int32 iNT_BL_COUNT;

		public Int32 INT_BL_COUNT
		{
			get { return iNT_BL_COUNT; }
			set { iNT_BL_COUNT = value; }
		}
		private Int32 iNT_BL_G_COUNT;

		public Int32 INT_BL_G_COUNT
		{
			get { return iNT_BL_G_COUNT; }
			set { iNT_BL_G_COUNT = value; }
		}
		private Int32 iNT_BL_S_COUNT;

		public Int32 INT_BL_S_COUNT
		{
			get { return iNT_BL_S_COUNT; }
			set { iNT_BL_S_COUNT = value; }
		}
		private Int32 iNT_BL_P_COUNT;

		public Int32 INT_BL_P_COUNT
		{
			get { return iNT_BL_P_COUNT; }
			set { iNT_BL_P_COUNT = value; }
		}
		private Int32 iNT_BL_J_COUNT;

		public Int32 INT_BL_J_COUNT
		{
			get { return iNT_BL_J_COUNT; }
			set { iNT_BL_J_COUNT = value; }
		}
		private Int32 iNT_BL_I_COUNT;

		public Int32 INT_BL_I_COUNT
		{
			get { return iNT_BL_I_COUNT; }
			set { iNT_BL_I_COUNT = value; }
		}
		private Int32 iNT_BL_E_COUNT;

		public Int32 INT_BL_E_COUNT
		{
			get { return iNT_BL_E_COUNT; }
			set { iNT_BL_E_COUNT = value; }
		}
		private Int32 iNT_MANIFEST_J_COUNT;

		public Int32 INT_MANIFEST_J_COUNT
		{
			get { return iNT_MANIFEST_J_COUNT; }
			set { iNT_MANIFEST_J_COUNT = value; }
		}
		private Int32 iNT_J_I_SHIP_COUNT;

		public Int32 INT_J_I_SHIP_COUNT
		{
			get { return iNT_J_I_SHIP_COUNT; }
			set { iNT_J_I_SHIP_COUNT = value; }
		}
		private Int32 iNT_J_E_SHIP_COUNT;

		public Int32 INT_J_E_SHIP_COUNT
		{
			get { return iNT_J_E_SHIP_COUNT; }
			set { iNT_J_E_SHIP_COUNT = value; }
		}
		private Int32 iNT_CHARGE_BACK_MODE;

		public Int32 INT_CHARGE_BACK_MODE
		{
			get { return iNT_CHARGE_BACK_MODE; }
			set { iNT_CHARGE_BACK_MODE = value; }
		}
		private Int32 iNT_IS_TRADELINK;

		public Int32 INT_IS_TRADELINK
		{
			get { return iNT_IS_TRADELINK; }
			set { iNT_IS_TRADELINK = value; }
		}
		private DateTime? dTE_CREATE_TIME;

		public DateTime? DTE_CREATE_TIME
		{
			get { return dTE_CREATE_TIME; }
			set { dTE_CREATE_TIME = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.DTE_CREATE_DATE==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_CREATE_DATE should not be empty!");
			}
			if (this.NVR_CN_NAME != null && 128 < this.NVR_CN_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CN_NAME should not be greater then 128!");
			}
			if (this.INT_CUSTOMS_CODE != null && 10 < this.INT_CUSTOMS_CODE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of INT_CUSTOMS_CODE should not be greater then 10!");
			}
			if (string.IsNullOrEmpty(this.NVR_CUSTOMS_NAME))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_CUSTOMS_NAME should not be empty!");
			}
			if (this.NVR_CUSTOMS_NAME != null && 64 < this.NVR_CUSTOMS_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CUSTOMS_NAME should not be greater then 64!");
			}
			if (this.DTE_CREATE_TIME==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_CREATE_TIME should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
