using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class report
	{
		#region Constructor
		public report() { }

		public report(Int32 id,String ship_id,String ship_name,Int32 count,Int32 e_voyage_count,Int32 i_voyage_count,Int32 e_stop_voyage,Int32 i_stop_voyage,Int32 e_voyage_count_e,Int32 i_voyage_count_e,String batchNo)
		{
			this.id = id;
			this.ship_id = ship_id;
			this.ship_name = ship_name;
			this.count = count;
			this.e_voyage_count = e_voyage_count;
			this.i_voyage_count = i_voyage_count;
			this.e_stop_voyage = e_stop_voyage;
			this.i_stop_voyage = i_stop_voyage;
			this.e_voyage_count_e = e_voyage_count_e;
			this.i_voyage_count_e = i_voyage_count_e;
			this.batchNo = batchNo;
		}
		#endregion

		#region Attributes
		private Int32 id;

		public Int32 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String ship_id;

		public String Ship_id
		{
			get { return ship_id; }
			set { ship_id = value; }
		}
		private String ship_name;

		public String Ship_name
		{
			get { return ship_name; }
			set { ship_name = value; }
		}
		private Int32 count;

		public Int32 Count
		{
			get { return count; }
			set { count = value; }
		}
		private Int32 e_voyage_count;

		public Int32 E_voyage_count
		{
			get { return e_voyage_count; }
			set { e_voyage_count = value; }
		}
		private Int32 i_voyage_count;

		public Int32 I_voyage_count
		{
			get { return i_voyage_count; }
			set { i_voyage_count = value; }
		}
		private Int32 e_stop_voyage;

		public Int32 E_stop_voyage
		{
			get { return e_stop_voyage; }
			set { e_stop_voyage = value; }
		}
		private Int32 i_stop_voyage;

		public Int32 I_stop_voyage
		{
			get { return i_stop_voyage; }
			set { i_stop_voyage = value; }
		}
		private Int32 e_voyage_count_e;

		public Int32 E_voyage_count_e
		{
			get { return e_voyage_count_e; }
			set { e_voyage_count_e = value; }
		}
		private Int32 i_voyage_count_e;

		public Int32 I_voyage_count_e
		{
			get { return i_voyage_count_e; }
			set { i_voyage_count_e = value; }
		}
		private String batchNo;

		public String BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.Ship_id != null && 50 < this.Ship_id.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Ship_id should not be greater then 50!");
			}
			if (this.Ship_name != null && 50 < this.Ship_name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Ship_name should not be greater then 50!");
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
