using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BASE_OPERATOR_ROLE
	{
		#region Constructor
		public BASE_OPERATOR_ROLE() { }

		public BASE_OPERATOR_ROLE(Int64 bIG_OPERATOR_AUID,Int64 bGT_ROLE_AUID)
		{
			this.bIG_OPERATOR_AUID = bIG_OPERATOR_AUID;
			this.bGT_ROLE_AUID = bGT_ROLE_AUID;
		}
		#endregion

		#region Attributes
		private Int64 bIG_OPERATOR_AUID;

		public Int64 BIG_OPERATOR_AUID
		{
			get { return bIG_OPERATOR_AUID; }
			set { bIG_OPERATOR_AUID = value; }
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
