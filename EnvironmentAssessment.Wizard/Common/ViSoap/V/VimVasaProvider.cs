namespace EnvironmentAssessment.Common.VISoap
{
    public class VimVasaProvider : DynamicData
    {
        private string urlField;

        private string nameField;

        private string selfSignedCertificateField;

        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

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

        public string selfSignedCertificate
        {
            get
            {
                return this.selfSignedCertificateField;
            }
            set
            {
                this.selfSignedCertificateField = value;
            }
        }
    }
}
