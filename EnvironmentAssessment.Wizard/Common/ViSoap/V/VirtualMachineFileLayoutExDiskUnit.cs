namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineFileLayoutExDiskUnit : DynamicData
	{
		protected int[] _fileKey;
		public int[] FileKey
		{
			get
			{
				return this._fileKey;
			}
			set
			{
				this._fileKey = value;
			}
		}
	}
}
