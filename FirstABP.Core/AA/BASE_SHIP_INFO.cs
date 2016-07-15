using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BASE_SHIP_INFO
	{
		#region Constructor
		public BASE_SHIP_INFO() { }

		public BASE_SHIP_INFO(String nVR_SHIP_ID,String nVR_SHIP_NAME)
		{
			this.nVR_SHIP_ID = nVR_SHIP_ID;
			this.nVR_SHIP_NAME = nVR_SHIP_NAME;
		}
		#endregion

		#region Attributes
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
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.NVR_SHIP_ID))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_SHIP_ID should not be empty!");
			}
			if (this.NVR_SHIP_ID != null && 25 < this.NVR_SHIP_ID.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_SHIP_ID should not be greater then 25!");
			}
			if (string.IsNullOrEmpty(this.NVR_SHIP_NAME))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_SHIP_NAME should not be empty!");
			}
			if (this.NVR_SHIP_NAME != null && 64 < this.NVR_SHIP_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_SHIP_NAME should not be greater then 64!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
