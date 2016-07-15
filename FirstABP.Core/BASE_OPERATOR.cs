using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BASE_OPERATOR
	{
		#region Constructor
		public BASE_OPERATOR() { }

		public BASE_OPERATOR(Int64 bIG_OPERATOR_AUID,String nVR_NAME,String nVR_PASSWORD,String nVR_AUTHORIZE,DateTime dTE_CREATE_DATE,DateTime dTE_LAST_LOAD_DATE,String nVR_LAST_LOAD_IP,Int32 iNT_IS_LOCK)
		{
			this.bIG_OPERATOR_AUID = bIG_OPERATOR_AUID;
			this.nVR_NAME = nVR_NAME;
			this.nVR_PASSWORD = nVR_PASSWORD;
			this.nVR_AUTHORIZE = nVR_AUTHORIZE;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
			this.dTE_LAST_LOAD_DATE = dTE_LAST_LOAD_DATE;
			this.nVR_LAST_LOAD_IP = nVR_LAST_LOAD_IP;
			this.iNT_IS_LOCK = iNT_IS_LOCK;
		}
		#endregion

		#region Attributes
		private Int64 bIG_OPERATOR_AUID;

		public Int64 BIG_OPERATOR_AUID
		{
			get { return bIG_OPERATOR_AUID; }
			set { bIG_OPERATOR_AUID = value; }
		}
		private String nVR_NAME;

		public String NVR_NAME
		{
			get { return nVR_NAME; }
			set { nVR_NAME = value; }
		}
		private String nVR_PASSWORD;

		public String NVR_PASSWORD
		{
			get { return nVR_PASSWORD; }
			set { nVR_PASSWORD = value; }
		}
		private String nVR_AUTHORIZE;

		public String NVR_AUTHORIZE
		{
			get { return nVR_AUTHORIZE; }
			set { nVR_AUTHORIZE = value; }
		}
		private DateTime? dTE_CREATE_DATE;

		public DateTime? DTE_CREATE_DATE
		{
			get { return dTE_CREATE_DATE; }
			set { dTE_CREATE_DATE = value; }
		}
		private DateTime? dTE_LAST_LOAD_DATE;

		public DateTime? DTE_LAST_LOAD_DATE
		{
			get { return dTE_LAST_LOAD_DATE; }
			set { dTE_LAST_LOAD_DATE = value; }
		}
		private String nVR_LAST_LOAD_IP;

		public String NVR_LAST_LOAD_IP
		{
			get { return nVR_LAST_LOAD_IP; }
			set { nVR_LAST_LOAD_IP = value; }
		}
		private Int32 iNT_IS_LOCK;

		public Int32 INT_IS_LOCK
		{
			get { return iNT_IS_LOCK; }
			set { iNT_IS_LOCK = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.NVR_NAME))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_NAME should not be empty!");
			}
			if (this.NVR_NAME != null && 256 < this.NVR_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_NAME should not be greater then 256!");
			}
			if (string.IsNullOrEmpty(this.NVR_PASSWORD))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_PASSWORD should not be empty!");
			}
			if (this.NVR_PASSWORD != null && 64 < this.NVR_PASSWORD.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_PASSWORD should not be greater then 64!");
			}
			if (this.NVR_AUTHORIZE != null && 1024 < this.NVR_AUTHORIZE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_AUTHORIZE should not be greater then 1024!");
			}
			if (this.NVR_LAST_LOAD_IP != null && 64 < this.NVR_LAST_LOAD_IP.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_LAST_LOAD_IP should not be greater then 64!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
