using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class V_BASE_ENTERPRISE_RUNNING_MFT
	{
		#region Constructor
		public V_BASE_ENTERPRISE_RUNNING_MFT() { }

		public V_BASE_ENTERPRISE_RUNNING_MFT(Int64 bIG_RUNNING_AUID,Int64 bIG_GENDECL_DETAILS_AUID,Int32 iNT_YEAR,Int32 iNT_MONTH,Int32 iNT_DAY,Int32 iNT_HALFYEAR,Int32 iNT_QUARTER,Int64 bIG_ENTERPRISE_AUID,String nVR_CN_NAME,String nVR_ORDER_ID,String nVR_SHIP_ID,String nVR_VOYAGE_NO,DateTime dTE_DECLARE,String nVR_CUSTOMS_CODE,Decimal dCE_MONEY,Int32 iNT_RUNNING_TYPE,DateTime dTE_CREATE_DATE,Decimal dEC_PRICE,Decimal dCE_BALANCE,String nVR_DECLARE_PERSON,DateTime dE_CREATE_DATE,Int32 iNT_I_OR_E,String nVR_SHIP_NAME,Int32 iNT_ORDER_TYPE,Int32 iNT_CHARGE_STATUS,Int32 bIG_REFUND_RUNNING_AUID)
		{
			this.bIG_RUNNING_AUID = bIG_RUNNING_AUID;
			this.bIG_GENDECL_DETAILS_AUID = bIG_GENDECL_DETAILS_AUID;
			this.iNT_YEAR = iNT_YEAR;
			this.iNT_MONTH = iNT_MONTH;
			this.iNT_DAY = iNT_DAY;
			this.iNT_HALFYEAR = iNT_HALFYEAR;
			this.iNT_QUARTER = iNT_QUARTER;
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.nVR_ORDER_ID = nVR_ORDER_ID;
			this.nVR_SHIP_ID = nVR_SHIP_ID;
			this.nVR_VOYAGE_NO = nVR_VOYAGE_NO;
			this.dTE_DECLARE = dTE_DECLARE;
			this.nVR_CUSTOMS_CODE = nVR_CUSTOMS_CODE;
			this.dCE_MONEY = dCE_MONEY;
			this.iNT_RUNNING_TYPE = iNT_RUNNING_TYPE;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
			this.dEC_PRICE = dEC_PRICE;
			this.dCE_BALANCE = dCE_BALANCE;
			this.nVR_DECLARE_PERSON = nVR_DECLARE_PERSON;
			this.dE_CREATE_DATE = dE_CREATE_DATE;
			this.iNT_I_OR_E = iNT_I_OR_E;
			this.nVR_SHIP_NAME = nVR_SHIP_NAME;
			this.iNT_ORDER_TYPE = iNT_ORDER_TYPE;
			this.iNT_CHARGE_STATUS = iNT_CHARGE_STATUS;
			this.bIG_REFUND_RUNNING_AUID = bIG_REFUND_RUNNING_AUID;
		}
		#endregion

		#region Attributes
		private Int64 bIG_RUNNING_AUID;

		public Int64 BIG_RUNNING_AUID
		{
			get { return bIG_RUNNING_AUID; }
			set { bIG_RUNNING_AUID = value; }
		}
		private Int64 bIG_GENDECL_DETAILS_AUID;

		public Int64 BIG_GENDECL_DETAILS_AUID
		{
			get { return bIG_GENDECL_DETAILS_AUID; }
			set { bIG_GENDECL_DETAILS_AUID = value; }
		}
		private Int32 iNT_YEAR;

		public Int32 INT_YEAR
		{
			get { return iNT_YEAR; }
			set { iNT_YEAR = value; }
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
		private String nVR_ORDER_ID;

		public String NVR_ORDER_ID
		{
			get { return nVR_ORDER_ID; }
			set { nVR_ORDER_ID = value; }
		}
		private String nVR_SHIP_ID;

		public String NVR_SHIP_ID
		{
			get { return nVR_SHIP_ID; }
			set { nVR_SHIP_ID = value; }
		}
		private String nVR_VOYAGE_NO;

		public String NVR_VOYAGE_NO
		{
			get { return nVR_VOYAGE_NO; }
			set { nVR_VOYAGE_NO = value; }
		}
		private DateTime? dTE_DECLARE;

		public DateTime? DTE_DECLARE
		{
			get { return dTE_DECLARE; }
			set { dTE_DECLARE = value; }
		}
		private String nVR_CUSTOMS_CODE;

		public String NVR_CUSTOMS_CODE
		{
			get { return nVR_CUSTOMS_CODE; }
			set { nVR_CUSTOMS_CODE = value; }
		}
		private Decimal dCE_MONEY;

		public Decimal DCE_MONEY
		{
			get { return dCE_MONEY; }
			set { dCE_MONEY = value; }
		}
		private Int32 iNT_RUNNING_TYPE;

		public Int32 INT_RUNNING_TYPE
		{
			get { return iNT_RUNNING_TYPE; }
			set { iNT_RUNNING_TYPE = value; }
		}
		private DateTime? dTE_CREATE_DATE;

		public DateTime? DTE_CREATE_DATE
		{
			get { return dTE_CREATE_DATE; }
			set { dTE_CREATE_DATE = value; }
		}
		private Decimal dEC_PRICE;

		public Decimal DEC_PRICE
		{
			get { return dEC_PRICE; }
			set { dEC_PRICE = value; }
		}
		private Decimal dCE_BALANCE;

		public Decimal DCE_BALANCE
		{
			get { return dCE_BALANCE; }
			set { dCE_BALANCE = value; }
		}
		private String nVR_DECLARE_PERSON;

		public String NVR_DECLARE_PERSON
		{
			get { return nVR_DECLARE_PERSON; }
			set { nVR_DECLARE_PERSON = value; }
		}
		private DateTime? dE_CREATE_DATE;

		public DateTime? DE_CREATE_DATE
		{
			get { return dE_CREATE_DATE; }
			set { dE_CREATE_DATE = value; }
		}
		private Int32 iNT_I_OR_E;

		public Int32 INT_I_OR_E
		{
			get { return iNT_I_OR_E; }
			set { iNT_I_OR_E = value; }
		}
		private String nVR_SHIP_NAME;

		public String NVR_SHIP_NAME
		{
			get { return nVR_SHIP_NAME; }
			set { nVR_SHIP_NAME = value; }
		}
		private Int32 iNT_ORDER_TYPE;

		public Int32 INT_ORDER_TYPE
		{
			get { return iNT_ORDER_TYPE; }
			set { iNT_ORDER_TYPE = value; }
		}
		private Int32 iNT_CHARGE_STATUS;

		public Int32 INT_CHARGE_STATUS
		{
			get { return iNT_CHARGE_STATUS; }
			set { iNT_CHARGE_STATUS = value; }
		}
		private Int32 bIG_REFUND_RUNNING_AUID;

		public Int32 BIG_REFUND_RUNNING_AUID
		{
			get { return bIG_REFUND_RUNNING_AUID; }
			set { bIG_REFUND_RUNNING_AUID = value; }
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
			if (this.NVR_ORDER_ID != null && 64 < this.NVR_ORDER_ID.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_ORDER_ID should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.NVR_SHIP_ID))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_SHIP_ID should not be empty!");
			}
			if (this.NVR_SHIP_ID != null && 64 < this.NVR_SHIP_ID.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_SHIP_ID should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.NVR_VOYAGE_NO))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_VOYAGE_NO should not be empty!");
			}
			if (this.NVR_VOYAGE_NO != null && 64 < this.NVR_VOYAGE_NO.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_VOYAGE_NO should not be greater then 64!");
			}
			if (this.DTE_DECLARE==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_DECLARE should not be empty!");
			}
			if (this.NVR_CUSTOMS_CODE != null && 64 < this.NVR_CUSTOMS_CODE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CUSTOMS_CODE should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.NVR_DECLARE_PERSON))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_DECLARE_PERSON should not be empty!");
			}
			if (this.NVR_DECLARE_PERSON != null && 64 < this.NVR_DECLARE_PERSON.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_DECLARE_PERSON should not be greater then 64!");
			}
			if (this.NVR_SHIP_NAME != null && 64 < this.NVR_SHIP_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_SHIP_NAME should not be greater then 64!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
