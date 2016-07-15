using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class V_BASE_OPERATOR_ROLE_FUNCTION
	{
		#region Constructor
		public V_BASE_OPERATOR_ROLE_FUNCTION() { }

		public V_BASE_OPERATOR_ROLE_FUNCTION(Int64 bIG_OPERATOR_AUID,Int64 bGT_FUNCTION_AUID,Int64 bGT_PARENT_FUNCTION_AUID,String nVR_NAME,String nVR_ICON,String nVR_URL,String nVR_REMARK,Int32 iNT_FUNCTION_TYPE)
		{
			this.bIG_OPERATOR_AUID = bIG_OPERATOR_AUID;
			this.bGT_FUNCTION_AUID = bGT_FUNCTION_AUID;
			this.bGT_PARENT_FUNCTION_AUID = bGT_PARENT_FUNCTION_AUID;
			this.nVR_NAME = nVR_NAME;
			this.nVR_ICON = nVR_ICON;
			this.nVR_URL = nVR_URL;
			this.nVR_REMARK = nVR_REMARK;
			this.iNT_FUNCTION_TYPE = iNT_FUNCTION_TYPE;
		}
		#endregion

		#region Attributes
		private Int64 bIG_OPERATOR_AUID;

		public Int64 BIG_OPERATOR_AUID
		{
			get { return bIG_OPERATOR_AUID; }
			set { bIG_OPERATOR_AUID = value; }
		}
		private Int64 bGT_FUNCTION_AUID;

		public Int64 BGT_FUNCTION_AUID
		{
			get { return bGT_FUNCTION_AUID; }
			set { bGT_FUNCTION_AUID = value; }
		}
		private Int64 bGT_PARENT_FUNCTION_AUID;

		public Int64 BGT_PARENT_FUNCTION_AUID
		{
			get { return bGT_PARENT_FUNCTION_AUID; }
			set { bGT_PARENT_FUNCTION_AUID = value; }
		}
		private String nVR_NAME;

		public String NVR_NAME
		{
			get { return nVR_NAME; }
			set { nVR_NAME = value; }
		}
		private String nVR_ICON;

		public String NVR_ICON
		{
			get { return nVR_ICON; }
			set { nVR_ICON = value; }
		}
		private String nVR_URL;

		public String NVR_URL
		{
			get { return nVR_URL; }
			set { nVR_URL = value; }
		}
		private String nVR_REMARK;

		public String NVR_REMARK
		{
			get { return nVR_REMARK; }
			set { nVR_REMARK = value; }
		}
		private Int32 iNT_FUNCTION_TYPE;

		public Int32 INT_FUNCTION_TYPE
		{
			get { return iNT_FUNCTION_TYPE; }
			set { iNT_FUNCTION_TYPE = value; }
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
			if (this.NVR_ICON != null && 256 < this.NVR_ICON.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_ICON should not be greater then 256!");
			}
			if (this.NVR_URL != null && 256 < this.NVR_URL.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_URL should not be greater then 256!");
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
