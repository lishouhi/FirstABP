using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class V_CIQ_SHIPDECL_FREEZE
	{
		#region Constructor
		public V_CIQ_SHIPDECL_FREEZE() { }

		public V_CIQ_SHIPDECL_FREEZE(Int64 bIG_ENTERPRISE_AUID,String nVR_CN_NAME,String nVR_SHIP_ID,String nVR_VOYAGE_NO,Decimal dEC_MONEY,String nVR_ORG_CODE,DateTime dTE_DECLARE,String nVR_DECLARE_PERSON,String nVR_REMARK,DateTime dTE_CREATE_DATE,String nVR_CREATE_PERSON,Int32 iNT_I_OR_E)
		{
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.nVR_SHIP_ID = nVR_SHIP_ID;
			this.nVR_VOYAGE_NO = nVR_VOYAGE_NO;
			this.dEC_MONEY = dEC_MONEY;
			this.nVR_ORG_CODE = nVR_ORG_CODE;
			this.dTE_DECLARE = dTE_DECLARE;
			this.nVR_DECLARE_PERSON = nVR_DECLARE_PERSON;
			this.nVR_REMARK = nVR_REMARK;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
			this.nVR_CREATE_PERSON = nVR_CREATE_PERSON;
			this.iNT_I_OR_E = iNT_I_OR_E;
		}
		#endregion

		#region Attributes
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
		private Decimal dEC_MONEY;

		public Decimal DEC_MONEY
		{
			get { return dEC_MONEY; }
			set { dEC_MONEY = value; }
		}
		private String nVR_ORG_CODE;

		public String NVR_ORG_CODE
		{
			get { return nVR_ORG_CODE; }
			set { nVR_ORG_CODE = value; }
		}
		private DateTime? dTE_DECLARE;

		public DateTime? DTE_DECLARE
		{
			get { return dTE_DECLARE; }
			set { dTE_DECLARE = value; }
		}
		private String nVR_DECLARE_PERSON;

		public String NVR_DECLARE_PERSON
		{
			get { return nVR_DECLARE_PERSON; }
			set { nVR_DECLARE_PERSON = value; }
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
		private String nVR_CREATE_PERSON;

		public String NVR_CREATE_PERSON
		{
			get { return nVR_CREATE_PERSON; }
			set { nVR_CREATE_PERSON = value; }
		}
		private Int32 iNT_I_OR_E;

		public Int32 INT_I_OR_E
		{
			get { return iNT_I_OR_E; }
			set { iNT_I_OR_E = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.NVR_CN_NAME != null && 128 < this.NVR_CN_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CN_NAME should not be greater then 128!");
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
			if (this.NVR_ORG_CODE != null && 64 < this.NVR_ORG_CODE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_ORG_CODE should not be greater then 64!");
			}
			if (this.DTE_DECLARE==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_DECLARE should not be empty!");
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
			return validatorResult;
		}	
		#endregion
	}
}
