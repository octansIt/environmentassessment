namespace EnvironmentAssessment.Common.VISoap
{
    public class VVolHostPE : DynamicData
    {
        private ManagedObjectReference keyField;

        private HostProtocolEndpoint[] protocolEndpointField;

        public ManagedObjectReference key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        public HostProtocolEndpoint[] protocolEndpoint
        {
            get
            {
                return this.protocolEndpointField;
            }
            set
            {
                this.protocolEndpointField = value;
            }
        }
    }
}
