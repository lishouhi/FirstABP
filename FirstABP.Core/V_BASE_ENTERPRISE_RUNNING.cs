using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class V_BASE_ENTERPRISE_RUNNING
	{
		#region Constructor
		public V_BASE_ENTERPRISE_RUNNING() { }

		public V_BASE_ENTERPRISE_RUNNING(Int64 bIG_RUNNING_AUID,Int64 bIG_ENTERPRISE_AUID,String nVR_CN_NAME,Int32 iNT_YEAR,Int32 iNT_MONTH,Int32 iNT_DAY,Int32 iNT_HALFYEAR,Int32 iNT_QUARTER,Decimal dCE_BEFORE_MONEY,Decimal dCE_MONEY,Decimal dCE_AFTER_MONEY,Int32 iNT_RUNNING_TYPE,String nVR_REMARK,DateTime dTE_CREATE_DATE,DateTime dTE_ALTER_DATE,String nVR_CREATE_PERSON,String nVR_ALTER_PERSON,String vCR_CHARGE_BACK_TYPE)
		{
			this.bIG_RUNNING_AUID = bIG_RUNNING_AUID;
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.iNT_YEAR = iNT_YEAR;
			this.iNT_MONTH = iNT_MONTH;
			this.iNT_DAY = iNT_DAY;
			this.iNT_HALFYEAR = iNT_HALFYEAR;
			this.iNT_QUARTER = iNT_QUARTER;
			this.dCE_BEFORE_MONEY = dCE_BEFORE_MONEY;
			this.dCE_MONEY = dCE_MONEY;
			this.dCE_AFTER_MONEY = dCE_AFTER_MONEY;
			this.iNT_RUNNING_TYPE = iNT_RUNNING_TYPE;
			this.nVR_REMARK = nVR_REMARK;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
			this.dTE_ALTER_DATE = dTE_ALTER_DATE;
			this.nVR_CREATE_PERSON = nVR_CREATE_PERSON;
			this.nVR_ALTER_PERSON = nVR_ALTER_PERSON;
			this.vCR_CHARGE_BACK_TYPE = vCR_CHARGE_BACK_TYPE;
		}
		#endregion

		#region Attributes
		private Int64 bIG_RUNNING_AUID;

		public Int64 BIG_RUNNING_AUID
		{
			get { return bIG_RUNNING_AUID; }
			set { bIG_RUNNING_AUID = value; }
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
		private Decimal dCE_BEFORE_MONEY;

		public Decimal DCE_BEFORE_MONEY
		{
			get { return dCE_BEFORE_MONEY; }
			set { dCE_BEFORE_MONEY = value; }
		}
		private Decimal dCE_MONEY;

		public Decimal DCE_MONEY
		{
			get { return dCE_MONEY; }
			set { dCE_MONEY = value; }
		}
		private Decimal dCE_AFTER_MONEY;

		public Decimal DCE_AFTER_MONEY
		{
			get { return dCE_AFTER_MONEY; }
			set { dCE_AFTER_MONEY = value; }
		}
		private Int32 iNT_RUNNING_TYPE;

		public Int32 INT_RUNNING_TYPE
		{
			get { return iNT_RUNNING_TYPE; }
			set { iNT_RUNNING_TYPE = value; }
		}
		private String nVR_REMARK;

		public String NVR_REMARK
		{
			get { return nVR_REMARK; }
			set { nVR_REMARK = value; }
		}
		private DateTime? dTE_CREATE_DATE;

		public DateTime? DTE_CREATE_DATE
		{
			get { return dTE_CREATE_DATE; }
			set { dTE_CREATE_DATE = value; }
		}
		private DateTime? dTE_ALTER_DATE;

		public DateTime? DTE_ALTER_DATE
		{
			get { return dTE_ALTER_DATE; }
			set { dTE_ALTER_DATE = value; }
		}
		private String nVR_CREATE_PERSON;

		public String NVR_CREATE_PERSON
		{
			get { return nVR_CREATE_PERSON; }
			set { nVR_CREATE_PERSON = value; }
		}
		private String nVR_ALTER_PERSON;

		public String NVR_ALTER_PERSON
		{
			get { return nVR_ALTER_PERSON; }
			set { nVR_ALTER_PERSON = value; }
		}
		private String vCR_CHARGE_BACK_TYPE;

		public String VCR_CHARGE_BACK_TYPE
		{
			get { return vCR_CHARGE_BACK_TYPE; }
			set { vCR_CHARGE_BACK_TYPE = value; }
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
			if (this.NVR_REMARK != null && 2147483647 < this.NVR_REMARK.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_REMARK should not be greater then 2147483647!");
			}
			if (this.NVR_CREATE_PERSON != null && 64 < this.NVR_CREATE_PERSON.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CREATE_PERSON should not be greater then 64!");
			}
			if (this.NVR_ALTER_PERSON != null && 64 < this.NVR_ALTER_PERSON.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_ALTER_PERSON should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.VCR_CHARGE_BACK_TYPE))
			{
				validatorResult = false;
				this.ErrorList.Add("The VCR_CHARGE_BACK_TYPE should not be empty!");
			}
			if (this.VCR_CHARGE_BACK_TYPE != null && 12 < this.VCR_CHARGE_BACK_TYPE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of VCR_CHARGE_BACK_TYPE should not be greater then 12!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
