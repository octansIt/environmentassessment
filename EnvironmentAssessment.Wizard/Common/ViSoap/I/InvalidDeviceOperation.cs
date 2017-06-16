namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidDeviceOperation : InvalidDeviceSpec
	{
		protected VirtualDeviceConfigSpecOperation? _badOp;
		protected VirtualDeviceConfigSpecFileOperation? _badFileOp;
		public VirtualDeviceConfigSpecOperation? BadOp
		{
			get
			{
				return this._badOp;
			}
			set
			{
				this._badOp = value;
			}
		}
		public VirtualDeviceConfigSpecFileOperation? BadFileOp
		{
			get
			{
				return this._badFileOp;
			}
			set
			{
				this._badFileOp = value;
			}
		}
	}
}
