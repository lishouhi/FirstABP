using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class M_1
	{
		#region Constructor
		public M_1() { }

		public M_1(Int32 iNT_SYSTEM_PKID,String nVR_CN_NAME,String nVR_SHIP_ID,String nVR_SHIP_NAME,String nVR_VOYAGE_NO,String nVR_ORDER_ID,String nVR_CUSTOMS_CODE,DateTime dTE_I_E_DATE,String pAYMENT_DATE)
		{
			this.iNT_SYSTEM_PKID = iNT_SYSTEM_PKID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.nVR_SHIP_ID = nVR_SHIP_ID;
			this.nVR_SHIP_NAME = nVR_SHIP_NAME;
			this.nVR_VOYAGE_NO = nVR_VOYAGE_NO;
			this.nVR_ORDER_ID = nVR_ORDER_ID;
			this.nVR_CUSTOMS_CODE = nVR_CUSTOMS_CODE;
			this.dTE_I_E_DATE = dTE_I_E_DATE;
			this.pAYMENT_DATE = pAYMENT_DATE;
		}
		#endregion

		#region Attributes
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
		private String nVR_SHIP_ID;

		public String NVR_SHIP_ID
		{
			get { return nVR_SHIP_ID; }
			set { nVR_SHIP_ID = value; }
		}
		private String nVR_SHIP_NAME;

		public String NVR_SHIP_NAME
		{
			get { return nVR_SHIP_NAME; }
			set { nVR_SHIP_NAME = value; }
		}
		private String nVR_VOYAGE_NO;

		public String NVR_VOYAGE_NO
		{
			get { return nVR_VOYAGE_NO; }
			set { nVR_VOYAGE_NO = value; }
		}
		private String nVR_ORDER_ID;

		public String NVR_ORDER_ID
		{
			get { return nVR_ORDER_ID; }
			set { nVR_ORDER_ID = value; }
		}
		private String nVR_CUSTOMS_CODE;

		public String NVR_CUSTOMS_CODE
		{
			get { return nVR_CUSTOMS_CODE; }
			set { nVR_CUSTOMS_CODE = value; }
		}
		private DateTime? dTE_I_E_DATE;

		public DateTime? DTE_I_E_DATE
		{
			get { return dTE_I_E_DATE; }
			set { dTE_I_E_DATE = value; }
		}
		private String pAYMENT_DATE;

		public String PAYMENT_DATE
		{
			get { return pAYMENT_DATE; }
			set { pAYMENT_DATE = value; }
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
			if (this.NVR_SHIP_NAME != null && 64 < this.NVR_SHIP_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_SHIP_NAME should not be greater then 64!");
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
			if (this.NVR_ORDER_ID != null && 64 < this.NVR_ORDER_ID.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_ORDER_ID should not be greater then 64!");
			}
			if (this.NVR_CUSTOMS_CODE != null && 64 < this.NVR_CUSTOMS_CODE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CUSTOMS_CODE should not be greater then 64!");
			}
			if (this.PAYMENT_DATE != null && 8 < this.PAYMENT_DATE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of PAYMENT_DATE should not be greater then 8!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
