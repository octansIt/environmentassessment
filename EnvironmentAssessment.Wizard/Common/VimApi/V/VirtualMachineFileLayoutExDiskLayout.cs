namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineFileLayoutExDiskLayout : DynamicData
	{
		protected int _key;
		protected VirtualMachineFileLayoutExDiskUnit[] _chain;
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
		public VirtualMachineFileLayoutExDiskUnit[] Chain
		{
			get
			{
				return this._chain;
			}
			set
			{
				this._chain = value;
			}
		}
	}
}
