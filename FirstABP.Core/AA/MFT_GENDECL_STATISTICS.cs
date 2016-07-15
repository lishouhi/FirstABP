using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class MFT_GENDECL_STATISTICS
	{
		#region Constructor
		public MFT_GENDECL_STATISTICS() { }

		public MFT_GENDECL_STATISTICS(Int32 iNT_YEAR,Int32 iNT_HALFYEAR,Int32 iNT_QUARTER,Int32 iNT_MONTH,Int32 iNT_DAY,Int64 bIG_ENTERPRISE_AUID,String nVR_CN_NAME,String nVR_CUSTOMS_CODE,Int32 iNT_MANIFEST_COUNT,Int32 iNT_BL_COUNT,Int32 iNT_TOTAL_COUNT,Decimal dEC_PRICE,Decimal dEC_TOTAL_CHARGES,DateTime dTE_CREATE_DATE,Int32 iNT_CHARGE_BACK_MODE)
		{
			this.iNT_YEAR = iNT_YEAR;
			this.iNT_HALFYEAR = iNT_HALFYEAR;
			this.iNT_QUARTER = iNT_QUARTER;
			this.iNT_MONTH = iNT_MONTH;
			this.iNT_DAY = iNT_DAY;
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.nVR_CUSTOMS_CODE = nVR_CUSTOMS_CODE;
			this.iNT_MANIFEST_COUNT = iNT_MANIFEST_COUNT;
			this.iNT_BL_COUNT = iNT_BL_COUNT;
			this.iNT_TOTAL_COUNT = iNT_TOTAL_COUNT;
			this.dEC_PRICE = dEC_PRICE;
			this.dEC_TOTAL_CHARGES = dEC_TOTAL_CHARGES;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
			this.iNT_CHARGE_BACK_MODE = iNT_CHARGE_BACK_MODE;
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
		private String nVR_CUSTOMS_CODE;

		public String NVR_CUSTOMS_CODE
		{
			get { return nVR_CUSTOMS_CODE; }
			set { nVR_CUSTOMS_CODE = value; }
		}
		private Int32 iNT_MANIFEST_COUNT;

		public Int32 INT_MANIFEST_COUNT
		{
			get { return iNT_MANIFEST_COUNT; }
			set { iNT_MANIFEST_COUNT = value; }
		}
		private Int32 iNT_BL_COUNT;

		public Int32 INT_BL_COUNT
		{
			get { return iNT_BL_COUNT; }
			set { iNT_BL_COUNT = value; }
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
		private DateTime? dTE_CREATE_DATE;

		public DateTime? DTE_CREATE_DATE
		{
			get { return dTE_CREATE_DATE; }
			set { dTE_CREATE_DATE = value; }
		}
		private Int32 iNT_CHARGE_BACK_MODE;

		public Int32 INT_CHARGE_BACK_MODE
		{
			get { return iNT_CHARGE_BACK_MODE; }
			set { iNT_CHARGE_BACK_MODE = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.NVR_CN_NAME))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_CN_NAME should not be empty!");
			}
			if (this.NVR_CN_NAME != null && 128 < this.NVR_CN_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CN_NAME should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.NVR_CUSTOMS_CODE))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_CUSTOMS_CODE should not be empty!");
			}
			if (this.NVR_CUSTOMS_CODE != null && 64 < this.NVR_CUSTOMS_CODE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CUSTOMS_CODE should not be greater then 64!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
