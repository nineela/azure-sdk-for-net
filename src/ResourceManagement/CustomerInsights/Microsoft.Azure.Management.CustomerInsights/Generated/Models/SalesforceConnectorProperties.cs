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
    /// The Salesforce connector properties.
    /// </summary>
    public partial class SalesforceConnectorProperties
    {
        /// <summary>
        /// Initializes a new instance of the SalesforceConnectorProperties
        /// class.
        /// </summary>
        public SalesforceConnectorProperties() { }

        /// <summary>
        /// Initializes a new instance of the SalesforceConnectorProperties
        /// class.
        /// </summary>
        /// <param name="salesforcetables">The Salesforce tables.</param>
        public SalesforceConnectorProperties(SalesforceDiscoverSetting usersetting, System.Collections.Generic.IList<SalesforceTable> salesforcetables)
        {
            Usersetting = usersetting;
            Salesforcetables = salesforcetables;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usersetting")]
        public SalesforceDiscoverSetting Usersetting { get; set; }

        /// <summary>
        /// Gets or sets the Salesforce tables.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "salesforcetables")]
        public System.Collections.Generic.IList<SalesforceTable> Salesforcetables { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Usersetting == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Usersetting");
            }
            if (Salesforcetables == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Salesforcetables");
            }
            if (this.Usersetting != null)
            {
                this.Usersetting.Validate();
            }
            if (this.Salesforcetables != null)
            {
                foreach (var element in this.Salesforcetables)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
