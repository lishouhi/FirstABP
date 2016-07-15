using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BASE_OPERATE_LOG
	{
		#region Constructor
		public BASE_OPERATE_LOG() { }

		public BASE_OPERATE_LOG(Int64 bIG_OPERATE_LOG_AUID,Int64 bIG_OPERATOR_AUID,String nVR_ADDRESS_IP,DateTime dTE_OPERATE_DATE,String nVR_CONTENT)
		{
			this.bIG_OPERATE_LOG_AUID = bIG_OPERATE_LOG_AUID;
			this.bIG_OPERATOR_AUID = bIG_OPERATOR_AUID;
			this.nVR_ADDRESS_IP = nVR_ADDRESS_IP;
			this.dTE_OPERATE_DATE = dTE_OPERATE_DATE;
			this.nVR_CONTENT = nVR_CONTENT;
		}
		#endregion

		#region Attributes
		private Int64 bIG_OPERATE_LOG_AUID;

		public Int64 BIG_OPERATE_LOG_AUID
		{
			get { return bIG_OPERATE_LOG_AUID; }
			set { bIG_OPERATE_LOG_AUID = value; }
		}
		private Int64 bIG_OPERATOR_AUID;

		public Int64 BIG_OPERATOR_AUID
		{
			get { return bIG_OPERATOR_AUID; }
			set { bIG_OPERATOR_AUID = value; }
		}
		private String nVR_ADDRESS_IP;

		public String NVR_ADDRESS_IP
		{
			get { return nVR_ADDRESS_IP; }
			set { nVR_ADDRESS_IP = value; }
		}
		private DateTime? dTE_OPERATE_DATE;

		public DateTime? DTE_OPERATE_DATE
		{
			get { return dTE_OPERATE_DATE; }
			set { dTE_OPERATE_DATE = value; }
		}
		private String nVR_CONTENT;

		public String NVR_CONTENT
		{
			get { return nVR_CONTENT; }
			set { nVR_CONTENT = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.NVR_ADDRESS_IP))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_ADDRESS_IP should not be empty!");
			}
			if (this.NVR_ADDRESS_IP != null && 32 < this.NVR_ADDRESS_IP.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_ADDRESS_IP should not be greater then 32!");
			}
			if (this.DTE_OPERATE_DATE==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_OPERATE_DATE should not be empty!");
			}
			if (string.IsNullOrEmpty(this.NVR_CONTENT))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_CONTENT should not be empty!");
			}
			if (this.NVR_CONTENT != null && 2147483647 < this.NVR_CONTENT.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CONTENT should not be greater then 2147483647!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
