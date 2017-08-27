namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualSwitchConfig : DynamicData
	{
		protected string _changeOperation;
		protected string _name;
		protected HostVirtualSwitchSpec _spec;
		public string ChangeOperation
		{
			get
			{
				return this._changeOperation;
			}
			set
			{
				this._changeOperation = value;
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
		public HostVirtualSwitchSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}
