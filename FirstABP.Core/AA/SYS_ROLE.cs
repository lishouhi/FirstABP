using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class SYS_ROLE
	{
		#region Constructor
		public SYS_ROLE() { }

		public SYS_ROLE(Int64 bGT_ROLE_AUID,String nVR_NAME,String nVR_REMARK,Int32 iNT_IS_USE)
		{
			this.bGT_ROLE_AUID = bGT_ROLE_AUID;
			this.nVR_NAME = nVR_NAME;
			this.nVR_REMARK = nVR_REMARK;
			this.iNT_IS_USE = iNT_IS_USE;
		}
		#endregion

		#region Attributes
		private Int64 bGT_ROLE_AUID;

		public Int64 BGT_ROLE_AUID
		{
			get { return bGT_ROLE_AUID; }
			set { bGT_ROLE_AUID = value; }
		}
		private String nVR_NAME;

		public String NVR_NAME
		{
			get { return nVR_NAME; }
			set { nVR_NAME = value; }
		}
		private String nVR_REMARK;

		public String NVR_REMARK
		{
			get { return nVR_REMARK; }
			set { nVR_REMARK = value; }
		}
		private Int32 iNT_IS_USE;

		public Int32 INT_IS_USE
		{
			get { return iNT_IS_USE; }
			set { iNT_IS_USE = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.NVR_NAME != null && 64 < this.NVR_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_NAME should not be greater then 64!");
			}
			if (this.NVR_REMARK != null && 256 < this.NVR_REMARK.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_REMARK should not be greater then 256!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
