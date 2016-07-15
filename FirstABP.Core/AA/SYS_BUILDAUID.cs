using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class SYS_BUILDAUID
	{
		#region Constructor
		public SYS_BUILDAUID() { }

		public SYS_BUILDAUID(String vRC_TABLE_NAME,String vRC_FIELD_NAME,DateTime dTE_MODIFIED,Int64 bIG_END_VAL)
		{
			this.vRC_TABLE_NAME = vRC_TABLE_NAME;
			this.vRC_FIELD_NAME = vRC_FIELD_NAME;
			this.dTE_MODIFIED = dTE_MODIFIED;
			this.bIG_END_VAL = bIG_END_VAL;
		}
		#endregion

		#region Attributes
		private String vRC_TABLE_NAME;

		public String VRC_TABLE_NAME
		{
			get { return vRC_TABLE_NAME; }
			set { vRC_TABLE_NAME = value; }
		}
		private String vRC_FIELD_NAME;

		public String VRC_FIELD_NAME
		{
			get { return vRC_FIELD_NAME; }
			set { vRC_FIELD_NAME = value; }
		}
		private DateTime? dTE_MODIFIED;

		public DateTime? DTE_MODIFIED
		{
			get { return dTE_MODIFIED; }
			set { dTE_MODIFIED = value; }
		}
		private Int64 bIG_END_VAL;

		public Int64 BIG_END_VAL
		{
			get { return bIG_END_VAL; }
			set { bIG_END_VAL = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.VRC_TABLE_NAME))
			{
				validatorResult = false;
				this.ErrorList.Add("The VRC_TABLE_NAME should not be empty!");
			}
			if (this.VRC_TABLE_NAME != null && 64 < this.VRC_TABLE_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of VRC_TABLE_NAME should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.VRC_FIELD_NAME))
			{
				validatorResult = false;
				this.ErrorList.Add("The VRC_FIELD_NAME should not be empty!");
			}
			if (this.VRC_FIELD_NAME != null && 64 < this.VRC_FIELD_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of VRC_FIELD_NAME should not be greater then 64!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
