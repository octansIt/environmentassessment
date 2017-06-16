namespace EnvironmentAssessment.Common.VISoap
{
    public class DatastoreOption : DynamicData
	{
		protected VirtualMachineDatastoreVolumeOption[] _unsupportedVolumes;
		public VirtualMachineDatastoreVolumeOption[] UnsupportedVolumes
		{
			get
			{
				return this._unsupportedVolumes;
			}
			set
			{
				this._unsupportedVolumes = value;
			}
		}
	}
}
