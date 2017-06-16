namespace EnvironmentAssessment.Common.VISoap
{
    public class InaccessibleDatastore : InvalidDatastore
	{
		protected string _detail;
		public string Detail
		{
			get
			{
				return this._detail;
			}
			set
			{
				this._detail = value;
			}
		}
		public new InaccessibleDatastore_LinkedView LinkedView
		{
			get
			{
				return (InaccessibleDatastore_LinkedView)this._linkedView;
			}
		}
	}
}
