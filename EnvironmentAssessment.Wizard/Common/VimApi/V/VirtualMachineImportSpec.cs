namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineImportSpec : ImportSpec
	{
		protected VirtualMachineConfigSpec _configSpec;
		protected ManagedObjectReference _resPoolEntity;
		protected VirtualMachineImportSpec_LinkedView _linkedView;
		public VirtualMachineConfigSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
		public ManagedObjectReference ResPoolEntity
		{
			get
			{
				return this._resPoolEntity;
			}
			set
			{
				this._resPoolEntity = value;
			}
		}
		public VirtualMachineImportSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
