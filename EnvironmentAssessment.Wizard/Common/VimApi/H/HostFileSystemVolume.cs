namespace EnvironmentAssessment.Common.VimApi
{
	public class HostFileSystemVolume : DynamicData
	{
		protected string _type;
		protected string _name;
		protected long _capacity;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public long Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
	}
}
