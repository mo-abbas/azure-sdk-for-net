// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// BEK is bitlocker encrpytion key.
    /// </summary>
    public partial class BEKDetails
    {
        /// <summary>
        /// Initializes a new instance of the BEKDetails class.
        /// </summary>
        public BEKDetails() { }

        /// <summary>
        /// Initializes a new instance of the BEKDetails class.
        /// </summary>
        /// <param name="secretUrl">Secret is BEK.</param>
        /// <param name="secretVaultId">ID of the Key Vault where this Secret
        /// is stored.</param>
        /// <param name="secretData">BEK data.</param>
        public BEKDetails(string secretUrl = default(string), string secretVaultId = default(string), string secretData = default(string))
        {
            SecretUrl = secretUrl;
            SecretVaultId = secretVaultId;
            SecretData = secretData;
        }

        /// <summary>
        /// Gets or sets secret is BEK.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secretUrl")]
        public string SecretUrl { get; set; }

        /// <summary>
        /// Gets or sets ID of the Key Vault where this Secret is stored.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secretVaultId")]
        public string SecretVaultId { get; set; }

        /// <summary>
        /// Gets or sets BEK data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secretData")]
        public string SecretData { get; set; }

    }
}