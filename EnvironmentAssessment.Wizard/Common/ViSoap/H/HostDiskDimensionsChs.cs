namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiskDimensionsChs : DynamicData
	{
		protected long _cylinder;
		protected int _head;
		protected int _sector;
		public long Cylinder
		{
			get
			{
				return this._cylinder;
			}
			set
			{
				this._cylinder = value;
			}
		}
		public int Head
		{
			get
			{
				return this._head;
			}
			set
			{
				this._head = value;
			}
		}
		public int Sector
		{
			get
			{
				return this._sector;
			}
			set
			{
				this._sector = value;
			}
		}
	}
}
