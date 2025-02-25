// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Azure VM managed disk input details.</summary>
    [System.ComponentModel.TypeConverter(typeof(A2AProtectionIntentManagedDiskInputDetailsTypeConverter))]
    public partial class A2AProtectionIntentManagedDiskInputDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.A2AProtectionIntentManagedDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal A2AProtectionIntentManagedDiskInputDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PrimaryStagingStorageAccountCustomInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IStorageAccountCustomDetails) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryResourceGroupCustomInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IRecoveryResourceGroupCustomDetails) content.GetValueForProperty("RecoveryResourceGroupCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.RecoveryResourceGroupCustomDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.DiskEncryptionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryReplicaDiskAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryReplicaDiskAccountType = (string) content.GetValueForProperty("RecoveryReplicaDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryReplicaDiskAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryTargetDiskAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryTargetDiskAccountType = (string) content.GetValueForProperty("RecoveryTargetDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryTargetDiskAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryDiskEncryptionSetId = (string) content.GetValueForProperty("RecoveryDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryDiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryStagingStorageAccountCustomInputResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType = (string) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryResourceGroupCustomInputResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInputResourceType = (string) content.GetValueForProperty("RecoveryResourceGroupCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInputResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionInfoDiskEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionInfoKeyEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionKeyInfoSecretIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.A2AProtectionIntentManagedDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal A2AProtectionIntentManagedDiskInputDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PrimaryStagingStorageAccountCustomInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IStorageAccountCustomDetails) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryResourceGroupCustomInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IRecoveryResourceGroupCustomDetails) content.GetValueForProperty("RecoveryResourceGroupCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.RecoveryResourceGroupCustomDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.DiskEncryptionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryReplicaDiskAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryReplicaDiskAccountType = (string) content.GetValueForProperty("RecoveryReplicaDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryReplicaDiskAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryTargetDiskAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryTargetDiskAccountType = (string) content.GetValueForProperty("RecoveryTargetDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryTargetDiskAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryDiskEncryptionSetId = (string) content.GetValueForProperty("RecoveryDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryDiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryStagingStorageAccountCustomInputResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType = (string) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryResourceGroupCustomInputResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInputResourceType = (string) content.GetValueForProperty("RecoveryResourceGroupCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).RecoveryResourceGroupCustomInputResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionInfoDiskEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionInfoKeyEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionKeyInfoSecretIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.A2AProtectionIntentManagedDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new A2AProtectionIntentManagedDiskInputDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.A2AProtectionIntentManagedDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new A2AProtectionIntentManagedDiskInputDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="A2AProtectionIntentManagedDiskInputDetails" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="A2AProtectionIntentManagedDiskInputDetails" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AProtectionIntentManagedDiskInputDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Azure VM managed disk input details.
    [System.ComponentModel.TypeConverter(typeof(A2AProtectionIntentManagedDiskInputDetailsTypeConverter))]
    public partial interface IA2AProtectionIntentManagedDiskInputDetails

    {

    }
}