using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class MFT_SPECIAL_CHANNELS_HISTORY
	{
		#region Constructor
		public MFT_SPECIAL_CHANNELS_HISTORY() { }

		public MFT_SPECIAL_CHANNELS_HISTORY(Int64 bIG_SPECIAL_CHANNELS_AUID,Int64 bIG_ENTERPRISE_AUID,DateTime dTE_START_DATE,DateTime dTE_END_DATE,Int64 bIG_OPERATOR_AUID,Boolean bIT_IS_VALID,String nVR_REMARK,DateTime dTE_CREATE_DATE)
		{
			this.bIG_SPECIAL_CHANNELS_AUID = bIG_SPECIAL_CHANNELS_AUID;
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.dTE_START_DATE = dTE_START_DATE;
			this.dTE_END_DATE = dTE_END_DATE;
			this.bIG_OPERATOR_AUID = bIG_OPERATOR_AUID;
			this.bIT_IS_VALID = bIT_IS_VALID;
			this.nVR_REMARK = nVR_REMARK;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
		}
		#endregion

		#region Attributes
		private Int64 bIG_SPECIAL_CHANNELS_AUID;

		public Int64 BIG_SPECIAL_CHANNELS_AUID
		{
			get { return bIG_SPECIAL_CHANNELS_AUID; }
			set { bIG_SPECIAL_CHANNELS_AUID = value; }
		}
		private Int64 bIG_ENTERPRISE_AUID;

		public Int64 BIG_ENTERPRISE_AUID
		{
			get { return bIG_ENTERPRISE_AUID; }
			set { bIG_ENTERPRISE_AUID = value; }
		}
		private DateTime? dTE_START_DATE;

		public DateTime? DTE_START_DATE
		{
			get { return dTE_START_DATE; }
			set { dTE_START_DATE = value; }
		}
		private DateTime? dTE_END_DATE;

		public DateTime? DTE_END_DATE
		{
			get { return dTE_END_DATE; }
			set { dTE_END_DATE = value; }
		}
		private Int64 bIG_OPERATOR_AUID;

		public Int64 BIG_OPERATOR_AUID
		{
			get { return bIG_OPERATOR_AUID; }
			set { bIG_OPERATOR_AUID = value; }
		}
		private Boolean bIT_IS_VALID;

		public Boolean BIT_IS_VALID
		{
			get { return bIT_IS_VALID; }
			set { bIT_IS_VALID = value; }
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
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.DTE_START_DATE==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_START_DATE should not be empty!");
			}
			if (this.DTE_END_DATE==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_END_DATE should not be empty!");
			}
			if (this.NVR_REMARK != null && 2147483647 < this.NVR_REMARK.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_REMARK should not be greater then 2147483647!");
			}
			if (this.DTE_CREATE_DATE==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The DTE_CREATE_DATE should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
