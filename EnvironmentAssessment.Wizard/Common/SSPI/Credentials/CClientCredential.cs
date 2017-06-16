namespace EnvironmentAssessment.Common.SSPI.Credentials
{
    /// <summary>
    /// Represents the credentials of the user running the current process, for use as an SSPI client.
    /// </summary>
    public class CClientCredential : CCurrentCredential
    {
        /// <summary>
        /// Initializes a new instance of the ClientCredential class.
        /// </summary>
        /// <param name="package">The security package to acquire the credential handle from.</param>
        public CClientCredential( string package )
            : base( package, CCredentialUse.Outbound )
        {
        }
    }
}
