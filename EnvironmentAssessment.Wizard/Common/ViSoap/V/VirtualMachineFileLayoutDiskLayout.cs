namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineFileLayoutDiskLayout : DynamicData
	{
		protected int _key;
		protected string[] _diskFile;
		public int Key
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
		public string[] DiskFile
		{
			get
			{
				return this._diskFile;
			}
			set
			{
				this._diskFile = value;
			}
		}
	}
}
