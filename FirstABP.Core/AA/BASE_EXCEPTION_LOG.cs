using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BASE_EXCEPTION_LOG
	{
		#region Constructor
		public BASE_EXCEPTION_LOG() { }

		public BASE_EXCEPTION_LOG(Int64 bGT_EXCEPTION_AUID,String nVR_LEVEL,String nVR_HOST,String nVR_LOGGER,String nVR_IP_ADDRESS,DateTime dTE_EXCEPTION_DATE,String nVR_THREAD,String nVR_MESSAGE,String nVR_EXCEPTION_MESSAGE)
		{
			this.bGT_EXCEPTION_AUID = bGT_EXCEPTION_AUID;
			this.nVR_LEVEL = nVR_LEVEL;
			this.nVR_HOST = nVR_HOST;
			this.nVR_LOGGER = nVR_LOGGER;
			this.nVR_IP_ADDRESS = nVR_IP_ADDRESS;
			this.dTE_EXCEPTION_DATE = dTE_EXCEPTION_DATE;
			this.nVR_THREAD = nVR_THREAD;
			this.nVR_MESSAGE = nVR_MESSAGE;
			this.nVR_EXCEPTION_MESSAGE = nVR_EXCEPTION_MESSAGE;
		}
		#endregion

		#region Attributes
		private Int64 bGT_EXCEPTION_AUID;

		public Int64 BGT_EXCEPTION_AUID
		{
			get { return bGT_EXCEPTION_AUID; }
			set { bGT_EXCEPTION_AUID = value; }
		}
		private String nVR_LEVEL;

		public String NVR_LEVEL
		{
			get { return nVR_LEVEL; }
			set { nVR_LEVEL = value; }
		}
		private String nVR_HOST;

		public String NVR_HOST
		{
			get { return nVR_HOST; }
			set { nVR_HOST = value; }
		}
		private String nVR_LOGGER;

		public String NVR_LOGGER
		{
			get { return nVR_LOGGER; }
			set { nVR_LOGGER = value; }
		}
		private String nVR_IP_ADDRESS;

		public String NVR_IP_ADDRESS
		{
			get { return nVR_IP_ADDRESS; }
			set { nVR_IP_ADDRESS = value; }
		}
		private DateTime? dTE_EXCEPTION_DATE;

		public DateTime? DTE_EXCEPTION_DATE
		{
			get { return dTE_EXCEPTION_DATE; }
			set { dTE_EXCEPTION_DATE = value; }
		}
		private String nVR_THREAD;

		public String NVR_THREAD
		{
			get { return nVR_THREAD; }
			set { nVR_THREAD = value; }
		}
		private String nVR_MESSAGE;

		public String NVR_MESSAGE
		{
			get { return nVR_MESSAGE; }
			set { nVR_MESSAGE = value; }
		}
		private String nVR_EXCEPTION_MESSAGE;

		public String NVR_EXCEPTION_MESSAGE
		{
			get { return nVR_EXCEPTION_MESSAGE; }
			set { nVR_EXCEPTION_MESSAGE = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.NVR_LEVEL != null && 50 < this.NVR_LEVEL.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_LEVEL should not be greater then 50!");
			}
			if (this.NVR_HOST != null && 50 < this.NVR_HOST.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_HOST should not be greater then 50!");
			}
			if (this.NVR_LOGGER != null && 255 < this.NVR_LOGGER.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_LOGGER should not be greater then 255!");
			}
			if (this.NVR_IP_ADDRESS != null && 20 < this.NVR_IP_ADDRESS.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_IP_ADDRESS should not be greater then 20!");
			}
			if (this.NVR_THREAD != null && 255 < this.NVR_THREAD.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_THREAD should not be greater then 255!");
			}
			if (this.NVR_MESSAGE != null && 4000 < this.NVR_MESSAGE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_MESSAGE should not be greater then 4000!");
			}
			if (this.NVR_EXCEPTION_MESSAGE != null && 4000 < this.NVR_EXCEPTION_MESSAGE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_EXCEPTION_MESSAGE should not be greater then 4000!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
