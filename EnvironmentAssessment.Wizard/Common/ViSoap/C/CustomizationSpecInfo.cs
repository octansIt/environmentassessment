using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class CustomizationSpecInfo : DynamicData
	{
		protected string _name;
		protected string _description;
		protected string _type;
		protected string _changeVersion;
		protected DateTime? _lastUpdateTime;
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
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
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
		public string ChangeVersion
		{
			get
			{
				return this._changeVersion;
			}
			set
			{
				this._changeVersion = value;
			}
		}
		public DateTime? LastUpdateTime
		{
			get
			{
				return this._lastUpdateTime;
			}
			set
			{
				this._lastUpdateTime = value;
			}
		}
	}
}
