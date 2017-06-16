namespace EnvironmentAssessment.Common.VISoap
{
    public class VASAStorageArray : DynamicData
    {
        private string nameField;

        private string uuidField;

        private string vendorIdField;

        private string modelIdField;

        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
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

        public string vendorId
        {
            get
            {
                return this.vendorIdField;
            }
            set
            {
                this.vendorIdField = value;
            }
        }

        public string modelId
        {
            get
            {
                return this.modelIdField;
            }
            set
            {
                this.modelIdField = value;
            }
        }
    }
}
