using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class ClusterRecommendation : DynamicData
	{
		protected string _key;
		protected string _type;
		protected DateTime _time;
		protected int _rating;
		protected string _reason;
		protected string _reasonText;
		protected string _warningText;
		protected string[] _prerequisite;
		protected ClusterAction[] _action;
		protected ManagedObjectReference _target;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
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
		public DateTime Time
		{
			get
			{
				return this._time;
			}
			set
			{
				this._time = value;
			}
		}
		public int Rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				this._rating = value;
			}
		}
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public string ReasonText
		{
			get
			{
				return this._reasonText;
			}
			set
			{
				this._reasonText = value;
			}
		}
		public string WarningText
		{
			get
			{
				return this._warningText;
			}
			set
			{
				this._warningText = value;
			}
		}
		public string[] Prerequisite
		{
			get
			{
				return this._prerequisite;
			}
			set
			{
				this._prerequisite = value;
			}
		}
		public ClusterAction[] Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}
		public ManagedObjectReference Target
		{
			get
			{
				return this._target;
			}
			set
			{
				this._target = value;
			}
		}
	}
}
