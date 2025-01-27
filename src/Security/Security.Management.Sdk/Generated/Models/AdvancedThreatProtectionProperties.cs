// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// The Advanced Threat Protection settings.
    /// </summary>
    public partial class AdvancedThreatProtectionProperties
    {
        /// <summary>
        /// Initializes a new instance of the AdvancedThreatProtectionProperties class.
        /// </summary>
        public AdvancedThreatProtectionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdvancedThreatProtectionProperties class.
        /// </summary>

        /// <param name="isEnabled">Indicates whether Advanced Threat Protection is enabled.
        /// </param>
        public AdvancedThreatProtectionProperties(bool? isEnabled = default(bool?))

        {
            this.IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates whether Advanced Threat Protection is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled {get; set; }
    }
}