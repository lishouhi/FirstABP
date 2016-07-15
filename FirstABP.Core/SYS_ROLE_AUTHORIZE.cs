using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class SYS_ROLE_AUTHORIZE
	{
		#region Constructor
		public SYS_ROLE_AUTHORIZE() { }

		public SYS_ROLE_AUTHORIZE(Int64 bGT_FUNCTION_AUID,Int64 bGT_ROLE_AUID)
		{
			this.bGT_FUNCTION_AUID = bGT_FUNCTION_AUID;
			this.bGT_ROLE_AUID = bGT_ROLE_AUID;
		}
		#endregion

		#region Attributes
		private Int64 bGT_FUNCTION_AUID;

		public Int64 BGT_FUNCTION_AUID
		{
			get { return bGT_FUNCTION_AUID; }
			set { bGT_FUNCTION_AUID = value; }
		}
		private Int64 bGT_ROLE_AUID;

		public Int64 BGT_ROLE_AUID
		{
			get { return bGT_ROLE_AUID; }
			set { bGT_ROLE_AUID = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			return validatorResult;
		}	
		#endregion
	}
}
