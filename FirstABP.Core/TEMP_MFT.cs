using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class TEMP_MFT
	{
		#region Constructor
		public TEMP_MFT() { }

		public TEMP_MFT(Int32 公司ID,String 公司名,String 航次,String 船名,String 提单,DateTime 进出口日期,String 关区,String 计费日期)
		{
			this.公司ID = 公司ID;
			this.公司名 = 公司名;
			this.航次 = 航次;
			this.船名 = 船名;
			this.提单 = 提单;
			this.进出口日期 = 进出口日期;
			this.关区 = 关区;
			this.计费日期 = 计费日期;
		}
		#endregion

		#region Attributes
		private Int32 公司ID;

		public Int32 公司ID
		{
			get { return 公司ID; }
			set { 公司ID = value; }
		}
		private String 公司名;

		public String 公司名
		{
			get { return 公司名; }
			set { 公司名 = value; }
		}
		private String 航次;

		public String 航次
		{
			get { return 航次; }
			set { 航次 = value; }
		}
		private String 船名;

		public String 船名
		{
			get { return 船名; }
			set { 船名 = value; }
		}
		private String 提单;

		public String 提单
		{
			get { return 提单; }
			set { 提单 = value; }
		}
		private DateTime? 进出口日期;

		public DateTime? 进出口日期
		{
			get { return 进出口日期; }
			set { 进出口日期 = value; }
		}
		private String 关区;

		public String 关区
		{
			get { return 关区; }
			set { 关区 = value; }
		}
		private String 计费日期;

		public String 计费日期
		{
			get { return 计费日期; }
			set { 计费日期 = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.公司名 != null && 50 < this.公司名.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of 公司名 should not be greater then 50!");
			}
			if (this.航次 != null && 50 < this.航次.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of 航次 should not be greater then 50!");
			}
			if (this.船名 != null && 50 < this.船名.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of 船名 should not be greater then 50!");
			}
			if (this.提单 != null && 50 < this.提单.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of 提单 should not be greater then 50!");
			}
			if (this.关区 != null && 50 < this.关区.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of 关区 should not be greater then 50!");
			}
			if (this.计费日期 != null && 50 < this.计费日期.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of 计费日期 should not be greater then 50!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
