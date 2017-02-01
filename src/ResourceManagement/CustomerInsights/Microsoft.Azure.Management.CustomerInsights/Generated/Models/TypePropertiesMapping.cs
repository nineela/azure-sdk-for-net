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
    /// Metadata for a Link's property mapping.
    /// </summary>
    public partial class TypePropertiesMapping
    {
        /// <summary>
        /// Initializes a new instance of the TypePropertiesMapping class.
        /// </summary>
        public TypePropertiesMapping() { }

        /// <summary>
        /// Initializes a new instance of the TypePropertiesMapping class.
        /// </summary>
        /// <param name="interactionTypePropertyName"> Property name on the
        /// source Interaction Type.</param>
        /// <param name="profileTypePropertyName">Property name on the target
        /// Profile Type.</param>
        /// <param name="isProfileTypeId">Flag to indicate whether the Profile
        /// Type property is an id on the Profile Type.</param>
        /// <param name="linkType">Link type. Possible values include:
        /// 'UpdateAlways', 'CopyIfNull'</param>
        public TypePropertiesMapping(string interactionTypePropertyName, string profileTypePropertyName, bool? isProfileTypeId = default(bool?), LinkTypes? linkType = default(LinkTypes?))
        {
            InteractionTypePropertyName = interactionTypePropertyName;
            ProfileTypePropertyName = profileTypePropertyName;
            IsProfileTypeId = isProfileTypeId;
            LinkType = linkType;
        }

        /// <summary>
        /// Gets or sets  Property name on the source Interaction Type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "interactionTypePropertyName")]
        public string InteractionTypePropertyName { get; set; }

        /// <summary>
        /// Gets or sets property name on the target Profile Type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "profileTypePropertyName")]
        public string ProfileTypePropertyName { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate whether the Profile Type property is
        /// an id on the Profile Type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isProfileTypeId")]
        public bool? IsProfileTypeId { get; set; }

        /// <summary>
        /// Gets or sets link type. Possible values include: 'UpdateAlways',
        /// 'CopyIfNull'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "linkType")]
        public LinkTypes? LinkType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InteractionTypePropertyName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "InteractionTypePropertyName");
            }
            if (ProfileTypePropertyName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ProfileTypePropertyName");
            }
        }
    }
}
