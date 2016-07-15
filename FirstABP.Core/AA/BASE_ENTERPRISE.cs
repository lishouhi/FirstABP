using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BASE_ENTERPRISE
	{
		#region Constructor
		public BASE_ENTERPRISE() { }

		public BASE_ENTERPRISE(Int64 bIG_ENTERPRISE_AUID,String vCR_CHARGE_BACK_TYPE,Int32 iNT_SYSTEM_PKID,String nVR_CN_NAME,String nVR_EN_NAME,String nVR_ATIFICIAL_PERSON,String nVR_BUSINESS_LICENSE,String uQF_LICENSEE,Int32 iNT_CHARGE_BACK_MODE,Decimal dCE_BALANCE,String nVR_REMARK,DateTime dTE_CREATE_DATE,DateTime dTE_ALTER_DATE,String nVR_CREATE_PERSON,String nVR_ALTER_PERSON,Decimal dCE_BALANCE_REMIND,Boolean bIT_IS_STOP,Int32 iNT_IS_TRADELINK)
		{
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.vCR_CHARGE_BACK_TYPE = vCR_CHARGE_BACK_TYPE;
			this.iNT_SYSTEM_PKID = iNT_SYSTEM_PKID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.nVR_EN_NAME = nVR_EN_NAME;
			this.nVR_ATIFICIAL_PERSON = nVR_ATIFICIAL_PERSON;
			this.nVR_BUSINESS_LICENSE = nVR_BUSINESS_LICENSE;
			this.uQF_LICENSEE = uQF_LICENSEE;
			this.iNT_CHARGE_BACK_MODE = iNT_CHARGE_BACK_MODE;
			this.dCE_BALANCE = dCE_BALANCE;
			this.nVR_REMARK = nVR_REMARK;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
			this.dTE_ALTER_DATE = dTE_ALTER_DATE;
			this.nVR_CREATE_PERSON = nVR_CREATE_PERSON;
			this.nVR_ALTER_PERSON = nVR_ALTER_PERSON;
			this.dCE_BALANCE_REMIND = dCE_BALANCE_REMIND;
			this.bIT_IS_STOP = bIT_IS_STOP;
			this.iNT_IS_TRADELINK = iNT_IS_TRADELINK;
		}
		#endregion

		#region Attributes
		private Int64 bIG_ENTERPRISE_AUID;

		public Int64 BIG_ENTERPRISE_AUID
		{
			get { return bIG_ENTERPRISE_AUID; }
			set { bIG_ENTERPRISE_AUID = value; }
		}
		private String vCR_CHARGE_BACK_TYPE;

		public String VCR_CHARGE_BACK_TYPE
		{
			get { return vCR_CHARGE_BACK_TYPE; }
			set { vCR_CHARGE_BACK_TYPE = value; }
		}
		private Int32 iNT_SYSTEM_PKID;

		public Int32 INT_SYSTEM_PKID
		{
			get { return iNT_SYSTEM_PKID; }
			set { iNT_SYSTEM_PKID = value; }
		}
		private String nVR_CN_NAME;

		public String NVR_CN_NAME
		{
			get { return nVR_CN_NAME; }
			set { nVR_CN_NAME = value; }
		}
		private String nVR_EN_NAME;

		public String NVR_EN_NAME
		{
			get { return nVR_EN_NAME; }
			set { nVR_EN_NAME = value; }
		}
		private String nVR_ATIFICIAL_PERSON;

		public String NVR_ATIFICIAL_PERSON
		{
			get { return nVR_ATIFICIAL_PERSON; }
			set { nVR_ATIFICIAL_PERSON = value; }
		}
		private String nVR_BUSINESS_LICENSE;

		public String NVR_BUSINESS_LICENSE
		{
			get { return nVR_BUSINESS_LICENSE; }
			set { nVR_BUSINESS_LICENSE = value; }
		}
		private String uQF_LICENSEE;

		public String UQF_LICENSEE
		{
			get { return uQF_LICENSEE; }
			set { uQF_LICENSEE = value; }
		}
		private Int32 iNT_CHARGE_BACK_MODE;

		public Int32 INT_CHARGE_BACK_MODE
		{
			get { return iNT_CHARGE_BACK_MODE; }
			set { iNT_CHARGE_BACK_MODE = value; }
		}
		private Decimal dCE_BALANCE;

		public Decimal DCE_BALANCE
		{
			get { return dCE_BALANCE; }
			set { dCE_BALANCE = value; }
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
		private Decimal dCE_BALANCE_REMIND;

		public Decimal DCE_BALANCE_REMIND
		{
			get { return dCE_BALANCE_REMIND; }
			set { dCE_BALANCE_REMIND = value; }
		}
		private Boolean bIT_IS_STOP;

		public Boolean BIT_IS_STOP
		{
			get { return bIT_IS_STOP; }
			set { bIT_IS_STOP = value; }
		}
		private Int32 iNT_IS_TRADELINK;

		public Int32 INT_IS_TRADELINK
		{
			get { return iNT_IS_TRADELINK; }
			set { iNT_IS_TRADELINK = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
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
			if (this.NVR_EN_NAME != null && 128 < this.NVR_EN_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_EN_NAME should not be greater then 128!");
			}
			if (this.NVR_ATIFICIAL_PERSON != null && 16 < this.NVR_ATIFICIAL_PERSON.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_ATIFICIAL_PERSON should not be greater then 16!");
			}
			if (this.NVR_BUSINESS_LICENSE != null && 32 < this.NVR_BUSINESS_LICENSE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_BUSINESS_LICENSE should not be greater then 32!");
			}
			if (this.UQF_LICENSEE != null && -1 < this.UQF_LICENSEE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of UQF_LICENSEE should not be greater then -1!");
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
			return validatorResult;
		}	
		#endregion
	}
}
