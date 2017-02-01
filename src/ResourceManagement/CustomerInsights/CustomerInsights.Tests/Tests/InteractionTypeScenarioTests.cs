﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace CustomerInsights.Tests.Tests
{
    using System;
    using System.Linq;
    using System.Threading;

    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Models;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

    using Xunit;

    public class InteractionTypeScenarioTests
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        static InteractionTypeScenarioTests()
        {
            HubName = AppSettings.HubName;
            ResourceGroupName = AppSettings.ResourceGroupName;
        }

        /// <summary>
        ///     Hub Name
        /// </summary>
        private static readonly string HubName;

        /// <summary>
        ///     Reosurce Group Name
        /// </summary>
        private static readonly string ResourceGroupName;

        [Fact]
        public void CreateAndReadInteractionType()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                var aciClient = context.GetServiceClient<CustomerInsightsManagementClient>();
                var interactionName = TestUtilities.GenerateName("TestInteractionType");
                var interactionResourceFormat = new InteractionResourceFormat
                                                    {
                                                        ApiEntitySetName = interactionName,
                                                        PrimaryParticipantProfilePropertyName = "profile1",
                                                        IdPropertyNames = new[] { interactionName },
                                                        Fields =
                                                            new[]
                                                                {
                                                                    new PropertyDefinition
                                                                        {
                                                                            FieldName = interactionName,
                                                                            FieldType = "Edm.String",
                                                                            IsArray = false,
                                                                            IsRequired = true
                                                                        },
                                                                    new PropertyDefinition
                                                                        {
                                                                            FieldName = "profile1",
                                                                            FieldType = "Edm.String"
                                                                        }
                                                                },
                                                        SmallImage = "\\Images\\smallImage",
                                                        MediumImage = "\\Images\\MediumImage",
                                                        LargeImage = "\\Images\\LargeImage"
                                                    };

                //Create interaction and verify
                var interactionResult = aciClient.Interactions.CreateOrUpdate(
                    ResourceGroupName,
                    HubName,
                    interactionName,
                    interactionResourceFormat);

                Assert.Equal(interactionName, interactionResult.TypeName);
                Assert.Equal(interactionResult.Name, HubName + "/" + interactionName);
                Assert.Equal(interactionResult.Type, "Microsoft.CustomerInsights/hubs/interactions");

                //Get interaction and verify
                var interactionGetResult = aciClient.Interactions.Get(
                    ResourceGroupName,
                    HubName,
                    interactionName,
                    "en-us");

                Assert.Equal(interactionName, interactionGetResult.TypeName);
                Assert.Equal(
                    interactionGetResult.Name,
                    HubName + "/" + interactionName,
                    StringComparer.OrdinalIgnoreCase);
                Assert.Equal(
                    interactionGetResult.Type,
                    "Microsoft.CustomerInsights/hubs/interactions",
                    StringComparer.OrdinalIgnoreCase);
            }
        }

        [Fact]
        public void ListInteractionTypesInHub()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                var aciClient = context.GetServiceClient<CustomerInsightsManagementClient>();
                var interactionName1 = TestUtilities.GenerateName("TestInteractionType1");
                var interactionResourceFormat1 = new InteractionResourceFormat
                                                     {
                                                         //EntityType = "Interaction",
                                                         ApiEntitySetName = interactionName1,
                                                         PrimaryParticipantProfilePropertyName = "profile1",
                                                         IdPropertyNames = new[] { interactionName1 },
                                                         Fields =
                                                             new[]
                                                                 {
                                                                     new PropertyDefinition
                                                                         {
                                                                             FieldName = interactionName1,
                                                                             FieldType = "Edm.String",
                                                                             IsArray = false,
                                                                             IsRequired = true
                                                                         },
                                                                     new PropertyDefinition
                                                                         {
                                                                             FieldName = "profile1",
                                                                             FieldType = "Edm.String"
                                                                         }
                                                                 },
                                                         SmallImage = "\\Images\\smallImage",
                                                         MediumImage = "\\Images\\MediumImage",
                                                         LargeImage = "\\Images\\LargeImage"
                                                     };
                var interactionName2 = TestUtilities.GenerateName("TestInteractionType2");
                var interactionResourceFormat2 = new InteractionResourceFormat
                                                     {
                                                         //EntityType = "Interaction",
                                                         ApiEntitySetName = interactionName2,
                                                         PrimaryParticipantProfilePropertyName = "profile2",
                                                         IdPropertyNames = new[] { interactionName2 },
                                                         SchemaItemTypeLink = "",
                                                         Fields =
                                                             new[]
                                                                 {
                                                                     new PropertyDefinition
                                                                         {
                                                                             FieldName = interactionName2,
                                                                             FieldType = "Edm.String",
                                                                             IsArray = false,
                                                                             IsRequired = true
                                                                         },
                                                                     new PropertyDefinition
                                                                         {
                                                                             FieldName = "profile2",
                                                                             FieldType = "Edm.String"
                                                                         }
                                                                 },
                                                         SmallImage = "\\Images\\smallImage",
                                                         MediumImage = "\\Images\\MediumImage",
                                                         LargeImage = "\\Images\\LargeImage"
                                                     };

                //Create interaction and verify
                aciClient.Interactions.CreateOrUpdate(
                    ResourceGroupName,
                    HubName,
                    interactionName1,
                    interactionResourceFormat1);
                aciClient.Interactions.CreateOrUpdate(
                    ResourceGroupName,
                    HubName,
                    interactionName2,
                    interactionResourceFormat2);

                var interactionList = aciClient.Interactions.ListByHub(ResourceGroupName, HubName);

                Assert.True(interactionList.ToList().Count >= 2);
                Assert.True(
                    interactionList.ToList()
                        .Any(interactionReturned => interactionName1 == interactionReturned.TypeName)
                    && interactionList.ToList()
                        .Any(interactionReturned => interactionName1 == interactionReturned.TypeName));
            }
        }
    }
}