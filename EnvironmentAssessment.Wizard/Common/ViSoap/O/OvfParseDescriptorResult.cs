namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfParseDescriptorResult : DynamicData
	{
		protected string[] _eula;
		protected OvfNetworkInfo[] _network;
		protected string[] _ipAllocationScheme;
		protected string[] _ipProtocols;
		protected VAppPropertyInfo[] _property;
		protected VAppProductInfo _productInfo;
		protected string _annotation;
		protected long? _approximateDownloadSize;
		protected long? _approximateFlatDeploymentSize;
		protected long? _approximateSparseDeploymentSize;
		protected string _defaultEntityName;
		protected bool _virtualApp;
		protected OvfDeploymentOption[] _deploymentOption;
		protected string _defaultDeploymentOption;
		protected KeyValue[] _entityName;
		protected OvfConsumerOstNode _annotatedOst;
		protected LocalizedMethodFault[] _error;
		protected LocalizedMethodFault[] _warning;
		public string[] Eula
		{
			get
			{
				return this._eula;
			}
			set
			{
				this._eula = value;
			}
		}
		public OvfNetworkInfo[] Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public string[] IpAllocationScheme
		{
			get
			{
				return this._ipAllocationScheme;
			}
			set
			{
				this._ipAllocationScheme = value;
			}
		}
		public string[] IpProtocols
		{
			get
			{
				return this._ipProtocols;
			}
			set
			{
				this._ipProtocols = value;
			}
		}
		public VAppPropertyInfo[] Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
			}
		}
		public VAppProductInfo ProductInfo
		{
			get
			{
				return this._productInfo;
			}
			set
			{
				this._productInfo = value;
			}
		}
		public string Annotation
		{
			get
			{
				return this._annotation;
			}
			set
			{
				this._annotation = value;
			}
		}
		public long? ApproximateDownloadSize
		{
			get
			{
				return this._approximateDownloadSize;
			}
			set
			{
				this._approximateDownloadSize = value;
			}
		}
		public long? ApproximateFlatDeploymentSize
		{
			get
			{
				return this._approximateFlatDeploymentSize;
			}
			set
			{
				this._approximateFlatDeploymentSize = value;
			}
		}
		public long? ApproximateSparseDeploymentSize
		{
			get
			{
				return this._approximateSparseDeploymentSize;
			}
			set
			{
				this._approximateSparseDeploymentSize = value;
			}
		}
		public string DefaultEntityName
		{
			get
			{
				return this._defaultEntityName;
			}
			set
			{
				this._defaultEntityName = value;
			}
		}
		public bool VirtualApp
		{
			get
			{
				return this._virtualApp;
			}
			set
			{
				this._virtualApp = value;
			}
		}
		public OvfDeploymentOption[] DeploymentOption
		{
			get
			{
				return this._deploymentOption;
			}
			set
			{
				this._deploymentOption = value;
			}
		}
		public string DefaultDeploymentOption
		{
			get
			{
				return this._defaultDeploymentOption;
			}
			set
			{
				this._defaultDeploymentOption = value;
			}
		}
		public KeyValue[] EntityName
		{
			get
			{
				return this._entityName;
			}
			set
			{
				this._entityName = value;
			}
		}
		public OvfConsumerOstNode AnnotatedOst
		{
			get
			{
				return this._annotatedOst;
			}
			set
			{
				this._annotatedOst = value;
			}
		}
		public LocalizedMethodFault[] Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public LocalizedMethodFault[] Warning
		{
			get
			{
				return this._warning;
			}
			set
			{
				this._warning = value;
			}
		}
	}
}
