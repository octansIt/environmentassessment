namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileApplyProfileProperty : DynamicData
	{
		protected string _propertyName;
		protected bool _array;
		protected ApplyProfile[] _profile;
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				this._propertyName = value;
			}
		}
		public bool Array
		{
			get
			{
				return this._array;
			}
			set
			{
				this._array = value;
			}
		}
		public ApplyProfile[] Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
	}
}
