using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSubSpecification : DynamicData
	{
		protected string _name;
		protected DateTime _createdTime;
		protected sbyte[] _data;
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
		public DateTime CreatedTime
		{
			get
			{
				return this._createdTime;
			}
			set
			{
				this._createdTime = value;
			}
		}
		public sbyte[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}
