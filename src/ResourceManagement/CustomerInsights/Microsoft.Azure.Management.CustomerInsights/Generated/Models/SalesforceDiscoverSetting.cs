// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Salesforce discover setting.
    /// </summary>
    public partial class SalesforceDiscoverSetting
    {
        /// <summary>
        /// Initializes a new instance of the SalesforceDiscoverSetting class.
        /// </summary>
        public SalesforceDiscoverSetting() { }

        /// <summary>
        /// Initializes a new instance of the SalesforceDiscoverSetting class.
        /// </summary>
        /// <param name="salesforceConnectionStringSecretUrl">The salesforce
        /// connection string secret URL.</param>
        public SalesforceDiscoverSetting(string salesforceConnectionStringSecretUrl)
        {
            SalesforceConnectionStringSecretUrl = salesforceConnectionStringSecretUrl;
        }

        /// <summary>
        /// Gets or sets the salesforce connection string secret URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "salesforceConnectionStringSecretUrl")]
        public string SalesforceConnectionStringSecretUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SalesforceConnectionStringSecretUrl == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SalesforceConnectionStringSecretUrl");
            }
        }
    }
}
