namespace EnvironmentAssessment.Common.VISoap
{
    public class VimVasaProviderInfo : DynamicData
    {
        private VimVasaProvider providerField;

        private VimVasaProviderStatePerArray[] arrayStateField;

        public VimVasaProvider provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }
        
        public VimVasaProviderStatePerArray[] arrayState
        {
            get
            {
                return this.arrayStateField;
            }
            set
            {
                this.arrayStateField = value;
            }
        }
    }
}
