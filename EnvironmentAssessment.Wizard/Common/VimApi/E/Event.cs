using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class Event : DynamicData
	{
		protected int _key;
		protected int _chainId;
		protected DateTime _createdTime;
		protected string _userName;
		protected DatacenterEventArgument _datacenter;
		protected ComputeResourceEventArgument _computeResource;
		protected HostEventArgument _host;
		protected VmEventArgument _vm;
		protected DatastoreEventArgument _ds;
		protected NetworkEventArgument _net;
		protected DvsEventArgument _dvs;
		protected string _fullFormattedMessage;
		protected string _changeTag;
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
		public int ChainId
		{
			get
			{
				return this._chainId;
			}
			set
			{
				this._chainId = value;
			}
		}
		public DateTime CreatedTime
		{
			get
			{
				return this._createdTime;
			}
			set
			{
				this._createdTime = value;
			}
		}
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
		public DatacenterEventArgument Datacenter
		{
			get
			{
				return this._datacenter;
			}
			set
			{
				this._datacenter = value;
			}
		}
		public ComputeResourceEventArgument ComputeResource
		{
			get
			{
				return this._computeResource;
			}
			set
			{
				this._computeResource = value;
			}
		}
		public HostEventArgument Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public VmEventArgument Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public DatastoreEventArgument Ds
		{
			get
			{
				return this._ds;
			}
			set
			{
				this._ds = value;
			}
		}
		public NetworkEventArgument Net
		{
			get
			{
				return this._net;
			}
			set
			{
				this._net = value;
			}
		}
		public DvsEventArgument Dvs
		{
			get
			{
				return this._dvs;
			}
			set
			{
				this._dvs = value;
			}
		}
		public string FullFormattedMessage
		{
			get
			{
				return this._fullFormattedMessage;
			}
			set
			{
				this._fullFormattedMessage = value;
			}
		}
		public string ChangeTag
		{
			get
			{
				return this._changeTag;
			}
			set
			{
				this._changeTag = value;
			}
		}
	}
}
