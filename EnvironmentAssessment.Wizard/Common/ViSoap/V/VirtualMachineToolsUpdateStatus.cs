namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineToolsUpdateStatus : DynamicData
	{
		protected bool? _updateRequireReboot;
		protected string[] _updateRequireRebootComponent;
		public bool? UpdateRequireReboot
		{
			get
			{
				return this._updateRequireReboot;
			}
			set
			{
				this._updateRequireReboot = value;
			}
		}
		public string[] UpdateRequireRebootComponent
		{
			get
			{
				return this._updateRequireRebootComponent;
			}
			set
			{
				this._updateRequireRebootComponent = value;
			}
		}
	}
}
