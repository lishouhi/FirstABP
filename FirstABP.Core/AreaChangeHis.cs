using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class AreaChangeHis
	{
		#region Constructor
		public AreaChangeHis() { }

		public AreaChangeHis(Int32 id,String ship_id,String sim_no,String ship_name,String voyage_no,DateTime occurrence_time,DateTime last_area_time,String way,Double lat,Double lng,String cmd_text,String mft_status,String start_port,String end_port,DateTime start_voyage_time,DateTime create_time,String batchNo,String ie_flag)
		{
			this.id = id;
			this.ship_id = ship_id;
			this.sim_no = sim_no;
			this.ship_name = ship_name;
			this.voyage_no = voyage_no;
			this.occurrence_time = occurrence_time;
			this.last_area_time = last_area_time;
			this.way = way;
			this.lat = lat;
			this.lng = lng;
			this.cmd_text = cmd_text;
			this.mft_status = mft_status;
			this.start_port = start_port;
			this.end_port = end_port;
			this.start_voyage_time = start_voyage_time;
			this.create_time = create_time;
			this.batchNo = batchNo;
			this.ie_flag = ie_flag;
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
		private String sim_no;

		public String Sim_no
		{
			get { return sim_no; }
			set { sim_no = value; }
		}
		private String ship_name;

		public String Ship_name
		{
			get { return ship_name; }
			set { ship_name = value; }
		}
		private String voyage_no;

		public String Voyage_no
		{
			get { return voyage_no; }
			set { voyage_no = value; }
		}
		private DateTime? occurrence_time;

		public DateTime? Occurrence_time
		{
			get { return occurrence_time; }
			set { occurrence_time = value; }
		}
		private DateTime? last_area_time;

		public DateTime? Last_area_time
		{
			get { return last_area_time; }
			set { last_area_time = value; }
		}
		private String way;

		public String Way
		{
			get { return way; }
			set { way = value; }
		}
		private Double lat;

		public Double Lat
		{
			get { return lat; }
			set { lat = value; }
		}
		private Double lng;

		public Double Lng
		{
			get { return lng; }
			set { lng = value; }
		}
		private String cmd_text;

		public String Cmd_text
		{
			get { return cmd_text; }
			set { cmd_text = value; }
		}
		private String mft_status;

		public String Mft_status
		{
			get { return mft_status; }
			set { mft_status = value; }
		}
		private String start_port;

		public String Start_port
		{
			get { return start_port; }
			set { start_port = value; }
		}
		private String end_port;

		public String End_port
		{
			get { return end_port; }
			set { end_port = value; }
		}
		private DateTime? start_voyage_time;

		public DateTime? Start_voyage_time
		{
			get { return start_voyage_time; }
			set { start_voyage_time = value; }
		}
		private DateTime? create_time;

		public DateTime? Create_time
		{
			get { return create_time; }
			set { create_time = value; }
		}
		private String batchNo;

		public String BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
		}
		private String ie_flag;

		public String Ie_flag
		{
			get { return ie_flag; }
			set { ie_flag = value; }
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
			if (this.Sim_no != null && 50 < this.Sim_no.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Sim_no should not be greater then 50!");
			}
			if (this.Ship_name != null && 50 < this.Ship_name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Ship_name should not be greater then 50!");
			}
			if (this.Voyage_no != null && 50 < this.Voyage_no.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Voyage_no should not be greater then 50!");
			}
			if (this.Way != null && 50 < this.Way.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Way should not be greater then 50!");
			}
			if (this.Cmd_text != null && 50 < this.Cmd_text.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Cmd_text should not be greater then 50!");
			}
			if (this.Mft_status != null && 50 < this.Mft_status.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Mft_status should not be greater then 50!");
			}
			if (this.Start_port != null && 500 < this.Start_port.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Start_port should not be greater then 500!");
			}
			if (this.End_port != null && 500 < this.End_port.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of End_port should not be greater then 500!");
			}
			if (this.BatchNo != null && 50 < this.BatchNo.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of BatchNo should not be greater then 50!");
			}
			if (this.Ie_flag != null && 50 < this.Ie_flag.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Ie_flag should not be greater then 50!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
