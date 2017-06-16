namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSoverlayParameterPolicy : InheritablePolicy
	{
		protected DVPortOverlayParameter[] _keyValue;
		public DVPortOverlayParameter[] KeyValue
		{
			get
			{
				return this._keyValue;
			}
			set
			{
				this._keyValue = value;
			}
		}
	}
}
