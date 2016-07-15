using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class SYS_PROC_LOG
	{
		#region Constructor
		public SYS_PROC_LOG() { }

		public SYS_PROC_LOG(Int32 iNT_PROC_RECORD_AUID,Int32 iNT_PROC_TYPE,String nVR_PROC_NAME,Boolean iNT_IS_SUCCESS,DateTime dTE_EXEC_BEGIN_DATE,DateTime dTE_EXEC_END_DATE,Int32 iNT_DURATION,String nVR_MESSAGE,DateTime dTE_CREATE_DATE)
		{
			this.iNT_PROC_RECORD_AUID = iNT_PROC_RECORD_AUID;
			this.iNT_PROC_TYPE = iNT_PROC_TYPE;
			this.nVR_PROC_NAME = nVR_PROC_NAME;
			this.iNT_IS_SUCCESS = iNT_IS_SUCCESS;
			this.dTE_EXEC_BEGIN_DATE = dTE_EXEC_BEGIN_DATE;
			this.dTE_EXEC_END_DATE = dTE_EXEC_END_DATE;
			this.iNT_DURATION = iNT_DURATION;
			this.nVR_MESSAGE = nVR_MESSAGE;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
		}
		#endregion

		#region Attributes
		private Int32 iNT_PROC_RECORD_AUID;

		public Int32 INT_PROC_RECORD_AUID
		{
			get { return iNT_PROC_RECORD_AUID; }
			set { iNT_PROC_RECORD_AUID = value; }
		}
		private Int32 iNT_PROC_TYPE;

		public Int32 INT_PROC_TYPE
		{
			get { return iNT_PROC_TYPE; }
			set { iNT_PROC_TYPE = value; }
		}
		private String nVR_PROC_NAME;

		public String NVR_PROC_NAME
		{
			get { return nVR_PROC_NAME; }
			set { nVR_PROC_NAME = value; }
		}
		private Boolean iNT_IS_SUCCESS;

		public Boolean INT_IS_SUCCESS
		{
			get { return iNT_IS_SUCCESS; }
			set { iNT_IS_SUCCESS = value; }
		}
		private DateTime? dTE_EXEC_BEGIN_DATE;

		public DateTime? DTE_EXEC_BEGIN_DATE
		{
			get { return dTE_EXEC_BEGIN_DATE; }
			set { dTE_EXEC_BEGIN_DATE = value; }
		}
		private DateTime? dTE_EXEC_END_DATE;

		public DateTime? DTE_EXEC_END_DATE
		{
			get { return dTE_EXEC_END_DATE; }
			set { dTE_EXEC_END_DATE = value; }
		}
		private Int32 iNT_DURATION;

		public Int32 INT_DURATION
		{
			get { return iNT_DURATION; }
			set { iNT_DURATION = value; }
		}
		private String nVR_MESSAGE;

		public String NVR_MESSAGE
		{
			get { return nVR_MESSAGE; }
			set { nVR_MESSAGE = value; }
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
			if (this.NVR_PROC_NAME != null && 50 < this.NVR_PROC_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_PROC_NAME should not be greater then 50!");
			}
			if (this.NVR_MESSAGE != null && 500 < this.NVR_MESSAGE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_MESSAGE should not be greater then 500!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
