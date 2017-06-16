namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualAppImportSpec : ImportSpec
	{
		protected string _name;
		protected VAppConfigSpec _vAppConfigSpec;
		protected ResourceConfigSpec _resourcePoolSpec;
		protected ImportSpec[] _child;
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
		public VAppConfigSpec VAppConfigSpec
		{
			get
			{
				return this._vAppConfigSpec;
			}
			set
			{
				this._vAppConfigSpec = value;
			}
		}
		public ResourceConfigSpec ResourcePoolSpec
		{
			get
			{
				return this._resourcePoolSpec;
			}
			set
			{
				this._resourcePoolSpec = value;
			}
		}
		public ImportSpec[] Child
		{
			get
			{
				return this._child;
			}
			set
			{
				this._child = value;
			}
		}
	}
}
