using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class BaseConfigInfo : DynamicData
	{
		protected ID _id;
		protected string _name;
		protected DateTime _createTime;
		protected BaseConfigInfoBackingInfo _backing;
		public ID Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
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
		public DateTime CreateTime
		{
			get
			{
				return this._createTime;
			}
			set
			{
				this._createTime = value;
			}
		}
		public BaseConfigInfoBackingInfo Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
	}
}
