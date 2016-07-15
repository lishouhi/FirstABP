using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class TEST_ENTERPRISE
	{
		#region Constructor
		public TEST_ENTERPRISE() { }

		public TEST_ENTERPRISE(Int64 bIG_ENTERPRISE_AUID,String nVR_CN_NAME,Decimal dCE_BALANCE,Decimal dCE_BALANCE2,Decimal dIFF,Decimal dCE_TOTAL_CHARGE,Decimal dCE_TOTAL_CUSTOME,String dTE_CREATE_DATE)
		{
			this.bIG_ENTERPRISE_AUID = bIG_ENTERPRISE_AUID;
			this.nVR_CN_NAME = nVR_CN_NAME;
			this.dCE_BALANCE = dCE_BALANCE;
			this.dCE_BALANCE2 = dCE_BALANCE2;
			this.dIFF = dIFF;
			this.dCE_TOTAL_CHARGE = dCE_TOTAL_CHARGE;
			this.dCE_TOTAL_CUSTOME = dCE_TOTAL_CUSTOME;
			this.dTE_CREATE_DATE = dTE_CREATE_DATE;
		}
		#endregion

		#region Attributes
		private Int64 bIG_ENTERPRISE_AUID;

		public Int64 BIG_ENTERPRISE_AUID
		{
			get { return bIG_ENTERPRISE_AUID; }
			set { bIG_ENTERPRISE_AUID = value; }
		}
		private String nVR_CN_NAME;

		public String NVR_CN_NAME
		{
			get { return nVR_CN_NAME; }
			set { nVR_CN_NAME = value; }
		}
		private Decimal dCE_BALANCE;

		public Decimal DCE_BALANCE
		{
			get { return dCE_BALANCE; }
			set { dCE_BALANCE = value; }
		}
		private Decimal dCE_BALANCE2;

		public Decimal DCE_BALANCE2
		{
			get { return dCE_BALANCE2; }
			set { dCE_BALANCE2 = value; }
		}
		private Decimal dIFF;

		public Decimal DIFF
		{
			get { return dIFF; }
			set { dIFF = value; }
		}
		private Decimal dCE_TOTAL_CHARGE;

		public Decimal DCE_TOTAL_CHARGE
		{
			get { return dCE_TOTAL_CHARGE; }
			set { dCE_TOTAL_CHARGE = value; }
		}
		private Decimal dCE_TOTAL_CUSTOME;

		public Decimal DCE_TOTAL_CUSTOME
		{
			get { return dCE_TOTAL_CUSTOME; }
			set { dCE_TOTAL_CUSTOME = value; }
		}
		private String dTE_CREATE_DATE;

		public String DTE_CREATE_DATE
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
			if (string.IsNullOrEmpty(this.NVR_CN_NAME))
			{
				validatorResult = false;
				this.ErrorList.Add("The NVR_CN_NAME should not be empty!");
			}
			if (this.NVR_CN_NAME != null && 128 < this.NVR_CN_NAME.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_CN_NAME should not be greater then 128!");
			}
			if (this.DTE_CREATE_DATE != null && 20 < this.DTE_CREATE_DATE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of DTE_CREATE_DATE should not be greater then 20!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
