using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BatchNoInfo
	{
		#region Constructor
		public BatchNoInfo() { }

		public BatchNoInfo(String batchNo,DateTime start_time,DateTime end_time,DateTime create_time)
		{
			this.batchNo = batchNo;
			this.start_time = start_time;
			this.end_time = end_time;
			this.create_time = create_time;
		}
		#endregion

		#region Attributes
		private String batchNo;

		public String BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
		}
		private DateTime? start_time;

		public DateTime? Start_time
		{
			get { return start_time; }
			set { start_time = value; }
		}
		private DateTime? end_time;

		public DateTime? End_time
		{
			get { return end_time; }
			set { end_time = value; }
		}
		private DateTime? create_time;

		public DateTime? Create_time
		{
			get { return create_time; }
			set { create_time = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.BatchNo))
			{
				validatorResult = false;
				this.ErrorList.Add("The BatchNo should not be empty!");
			}
			if (this.BatchNo != null && 50 < this.BatchNo.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of BatchNo should not be greater then 50!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
