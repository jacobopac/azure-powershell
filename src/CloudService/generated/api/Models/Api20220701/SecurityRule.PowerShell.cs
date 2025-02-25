// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.PowerShell;

    /// <summary>Network security rule.</summary>
    [System.ComponentModel.TypeConverter(typeof(SecurityRuleTypeConverter))]
    public partial class SecurityRule
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SecurityRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecurityRule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SecurityRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecurityRule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecurityRule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecurityRule" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRule FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SecurityRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SecurityRule(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRulePropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SecurityRulePropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Protocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Protocol = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol) content.GetValueForProperty("Protocol",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Protocol, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol.CreateFrom);
            }
            if (content.Contains("SourcePortRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourcePortRange = (string) content.GetValueForProperty("SourcePortRange",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourcePortRange, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationPortRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationPortRange = (string) content.GetValueForProperty("DestinationPortRange",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationPortRange, global::System.Convert.ToString);
            }
            if (content.Contains("SourceAddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceAddressPrefix = (string) content.GetValueForProperty("SourceAddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceAddressPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("PropertiesSourceAddressPrefixes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourceAddressPrefixes = (string[]) content.GetValueForProperty("PropertiesSourceAddressPrefixes",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourceAddressPrefixes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SourceApplicationSecurityGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceApplicationSecurityGroup = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[]) content.GetValueForProperty("SourceApplicationSecurityGroup",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceApplicationSecurityGroup, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ApplicationSecurityGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("DestinationAddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationAddressPrefix = (string) content.GetValueForProperty("DestinationAddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationAddressPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("PropertiesDestinationAddressPrefixes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationAddressPrefixes = (string[]) content.GetValueForProperty("PropertiesDestinationAddressPrefixes",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationAddressPrefixes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DestinationApplicationSecurityGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationApplicationSecurityGroup = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[]) content.GetValueForProperty("DestinationApplicationSecurityGroup",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationApplicationSecurityGroup, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ApplicationSecurityGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertiesSourcePortRanges"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourcePortRanges = (string[]) content.GetValueForProperty("PropertiesSourcePortRanges",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourcePortRanges, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PropertiesDestinationPortRanges"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationPortRanges = (string[]) content.GetValueForProperty("PropertiesDestinationPortRanges",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationPortRanges, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Access"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Access = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess) content.GetValueForProperty("Access",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Access, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess.CreateFrom);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Priority = (int?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Priority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Direction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Direction = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Direction, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SecurityRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SecurityRule(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRulePropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SecurityRulePropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Protocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Protocol = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol) content.GetValueForProperty("Protocol",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Protocol, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol.CreateFrom);
            }
            if (content.Contains("SourcePortRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourcePortRange = (string) content.GetValueForProperty("SourcePortRange",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourcePortRange, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationPortRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationPortRange = (string) content.GetValueForProperty("DestinationPortRange",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationPortRange, global::System.Convert.ToString);
            }
            if (content.Contains("SourceAddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceAddressPrefix = (string) content.GetValueForProperty("SourceAddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceAddressPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("PropertiesSourceAddressPrefixes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourceAddressPrefixes = (string[]) content.GetValueForProperty("PropertiesSourceAddressPrefixes",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourceAddressPrefixes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SourceApplicationSecurityGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceApplicationSecurityGroup = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[]) content.GetValueForProperty("SourceApplicationSecurityGroup",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).SourceApplicationSecurityGroup, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ApplicationSecurityGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("DestinationAddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationAddressPrefix = (string) content.GetValueForProperty("DestinationAddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationAddressPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("PropertiesDestinationAddressPrefixes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationAddressPrefixes = (string[]) content.GetValueForProperty("PropertiesDestinationAddressPrefixes",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationAddressPrefixes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DestinationApplicationSecurityGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationApplicationSecurityGroup = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[]) content.GetValueForProperty("DestinationApplicationSecurityGroup",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).DestinationApplicationSecurityGroup, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ApplicationSecurityGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertiesSourcePortRanges"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourcePortRanges = (string[]) content.GetValueForProperty("PropertiesSourcePortRanges",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesSourcePortRanges, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PropertiesDestinationPortRanges"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationPortRanges = (string[]) content.GetValueForProperty("PropertiesDestinationPortRanges",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).PropertiesDestinationPortRanges, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Access"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Access = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess) content.GetValueForProperty("Access",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Access, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess.CreateFrom);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Priority = (int?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Priority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Direction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Direction = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISecurityRuleInternal)this).Direction, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Network security rule.
    [System.ComponentModel.TypeConverter(typeof(SecurityRuleTypeConverter))]
    public partial interface ISecurityRule

    {

    }
}