using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class BASE_CHARGEBACK_PARAMETER
	{
		#region Constructor
		public BASE_CHARGEBACK_PARAMETER() { }

		public BASE_CHARGEBACK_PARAMETER(String vRC_CHARGE_BACK_TYPE,Decimal dCE_DEDUCTION_RATE,String nVR_REMARK)
		{
			this.vRC_CHARGE_BACK_TYPE = vRC_CHARGE_BACK_TYPE;
			this.dCE_DEDUCTION_RATE = dCE_DEDUCTION_RATE;
			this.nVR_REMARK = nVR_REMARK;
		}
		#endregion

		#region Attributes
		private String vRC_CHARGE_BACK_TYPE;

		public String VRC_CHARGE_BACK_TYPE
		{
			get { return vRC_CHARGE_BACK_TYPE; }
			set { vRC_CHARGE_BACK_TYPE = value; }
		}
		private Decimal dCE_DEDUCTION_RATE;

		public Decimal DCE_DEDUCTION_RATE
		{
			get { return dCE_DEDUCTION_RATE; }
			set { dCE_DEDUCTION_RATE = value; }
		}
		private String nVR_REMARK;

		public String NVR_REMARK
		{
			get { return nVR_REMARK; }
			set { nVR_REMARK = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.VRC_CHARGE_BACK_TYPE))
			{
				validatorResult = false;
				this.ErrorList.Add("The VRC_CHARGE_BACK_TYPE should not be empty!");
			}
			if (this.VRC_CHARGE_BACK_TYPE != null && 24 < this.VRC_CHARGE_BACK_TYPE.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of VRC_CHARGE_BACK_TYPE should not be greater then 24!");
			}
			if (this.NVR_REMARK != null && 100 < this.NVR_REMARK.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NVR_REMARK should not be greater then 100!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
