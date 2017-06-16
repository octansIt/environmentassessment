namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualPCIControllerOption : VirtualControllerOption
	{
		protected IntOption _numSCSIControllers;
		protected IntOption _numEthernetCards;
		protected IntOption _numVideoCards;
		protected IntOption _numSoundCards;
		protected IntOption _numVmiRoms;
		protected IntOption _numVmciDevices;
		protected IntOption _numPCIPassthroughDevices;
		protected IntOption _numSasSCSIControllers;
		protected IntOption _numVmxnet3EthernetCards;
		protected IntOption _numParaVirtualSCSIControllers;
		protected IntOption _numSATAControllers;
		public IntOption NumSCSIControllers
		{
			get
			{
				return this._numSCSIControllers;
			}
			set
			{
				this._numSCSIControllers = value;
			}
		}
		public IntOption NumEthernetCards
		{
			get
			{
				return this._numEthernetCards;
			}
			set
			{
				this._numEthernetCards = value;
			}
		}
		public IntOption NumVideoCards
		{
			get
			{
				return this._numVideoCards;
			}
			set
			{
				this._numVideoCards = value;
			}
		}
		public IntOption NumSoundCards
		{
			get
			{
				return this._numSoundCards;
			}
			set
			{
				this._numSoundCards = value;
			}
		}
		public IntOption NumVmiRoms
		{
			get
			{
				return this._numVmiRoms;
			}
			set
			{
				this._numVmiRoms = value;
			}
		}
		public IntOption NumVmciDevices
		{
			get
			{
				return this._numVmciDevices;
			}
			set
			{
				this._numVmciDevices = value;
			}
		}
		public IntOption NumPCIPassthroughDevices
		{
			get
			{
				return this._numPCIPassthroughDevices;
			}
			set
			{
				this._numPCIPassthroughDevices = value;
			}
		}
		public IntOption NumSasSCSIControllers
		{
			get
			{
				return this._numSasSCSIControllers;
			}
			set
			{
				this._numSasSCSIControllers = value;
			}
		}
		public IntOption NumVmxnet3EthernetCards
		{
			get
			{
				return this._numVmxnet3EthernetCards;
			}
			set
			{
				this._numVmxnet3EthernetCards = value;
			}
		}
		public IntOption NumParaVirtualSCSIControllers
		{
			get
			{
				return this._numParaVirtualSCSIControllers;
			}
			set
			{
				this._numParaVirtualSCSIControllers = value;
			}
		}
		public IntOption NumSATAControllers
		{
			get
			{
				return this._numSATAControllers;
			}
			set
			{
				this._numSATAControllers = value;
			}
		}
	}
}
