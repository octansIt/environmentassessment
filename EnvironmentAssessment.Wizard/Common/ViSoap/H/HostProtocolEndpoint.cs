namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProtocolEndpoint : DynamicData
    {
        private string peTypeField;

        private string uuidField;

        private ManagedObjectReference[] hostKeyField;

        private string storageArrayField;

        private string nfsServerField;

        private string nfsDirField;

        private string deviceIdField;

        public string peType
        {
            get
            {
                return this.peTypeField;
            }
            set
            {
                this.peTypeField = value;
            }
        }

        public string uuid
        {
            get
            {
                return this.uuidField;
            }
            set
            {
                this.uuidField = value;
            }
        }

        public ManagedObjectReference[] hostKey
        {
            get
            {
                return this.hostKeyField;
            }
            set
            {
                this.hostKeyField = value;
            }
        }

        public string storageArray
        {
            get
            {
                return this.storageArrayField;
            }
            set
            {
                this.storageArrayField = value;
            }
        }

        public string nfsServer
        {
            get
            {
                return this.nfsServerField;
            }
            set
            {
                this.nfsServerField = value;
            }
        }

        public string nfsDir
        {
            get
            {
                return this.nfsDirField;
            }
            set
            {
                this.nfsDirField = value;
            }
        }

        public string deviceId
        {
            get
            {
                return this.deviceIdField;
            }
            set
            {
                this.deviceIdField = value;
            }
        }
    }
}
