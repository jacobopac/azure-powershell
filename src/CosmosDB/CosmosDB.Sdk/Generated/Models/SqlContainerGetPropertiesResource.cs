// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    public partial class SqlContainerGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlContainerGetPropertiesResource class.
        /// </summary>
        public SqlContainerGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlContainerGetPropertiesResource class.
        /// </summary>

        /// <param name="id">Name of the Cosmos DB SQL container
        /// </param>

        /// <param name="indexingPolicy">The configuration of the indexing policy. By default, the indexing is
        /// automatic for all document paths within the container
        /// </param>

        /// <param name="partitionKey">The configuration of the partition key to be used for partitioning data
        /// into multiple partitions
        /// </param>

        /// <param name="defaultTtl">Default time to live
        /// </param>

        /// <param name="uniqueKeyPolicy">The unique key policy configuration for specifying uniqueness constraints
        /// on documents in the collection in the Azure Cosmos DB service.
        /// </param>

        /// <param name="conflictResolutionPolicy">The conflict resolution policy for the container.
        /// </param>

        /// <param name="clientEncryptionPolicy">The client encryption policy for the container.
        /// </param>

        /// <param name="analyticalStorageTtl">Analytical TTL.
        /// </param>

        /// <param name="rid">A system generated property. A unique identifier.
        /// </param>

        /// <param name="ts">A system generated property that denotes the last updated timestamp of the
        /// resource.
        /// </param>

        /// <param name="etag">A system generated property representing the resource etag required for
        /// optimistic concurrency control.
        /// </param>
        public SqlContainerGetPropertiesResource(string id, IndexingPolicy indexingPolicy = default(IndexingPolicy), ContainerPartitionKey partitionKey = default(ContainerPartitionKey), int? defaultTtl = default(int?), UniqueKeyPolicy uniqueKeyPolicy = default(UniqueKeyPolicy), ConflictResolutionPolicy conflictResolutionPolicy = default(ConflictResolutionPolicy), ClientEncryptionPolicy clientEncryptionPolicy = default(ClientEncryptionPolicy), long? analyticalStorageTtl = default(long?), string rid = default(string), double? ts = default(double?), string etag = default(string))

        {
            this.Id = id;
            this.IndexingPolicy = indexingPolicy;
            this.PartitionKey = partitionKey;
            this.DefaultTtl = defaultTtl;
            this.UniqueKeyPolicy = uniqueKeyPolicy;
            this.ConflictResolutionPolicy = conflictResolutionPolicy;
            this.ClientEncryptionPolicy = clientEncryptionPolicy;
            this.AnalyticalStorageTtl = analyticalStorageTtl;
            this.Rid = rid;
            this.Ts = ts;
            this.Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the Cosmos DB SQL container
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }

        /// <summary>
        /// Gets or sets the configuration of the indexing policy. By default, the
        /// indexing is automatic for all document paths within the container
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "indexingPolicy")]
        public IndexingPolicy IndexingPolicy {get; set; }

        /// <summary>
        /// Gets or sets the configuration of the partition key to be used for
        /// partitioning data into multiple partitions
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "partitionKey")]
        public ContainerPartitionKey PartitionKey {get; set; }

        /// <summary>
        /// Gets or sets default time to live
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultTtl")]
        public int? DefaultTtl {get; set; }

        /// <summary>
        /// Gets or sets the unique key policy configuration for specifying uniqueness
        /// constraints on documents in the collection in the Azure Cosmos DB service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uniqueKeyPolicy")]
        public UniqueKeyPolicy UniqueKeyPolicy {get; set; }

        /// <summary>
        /// Gets or sets the conflict resolution policy for the container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "conflictResolutionPolicy")]
        public ConflictResolutionPolicy ConflictResolutionPolicy {get; set; }

        /// <summary>
        /// Gets or sets the client encryption policy for the container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clientEncryptionPolicy")]
        public ClientEncryptionPolicy ClientEncryptionPolicy {get; set; }

        /// <summary>
        /// Gets or sets analytical TTL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "analyticalStorageTtl")]
        public long? AnalyticalStorageTtl {get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "_rid")]
        public string Rid {get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated timestamp of
        /// the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "_ts")]
        public double? Ts {get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag required
        /// for optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "_etag")]
        public string Etag {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }


            if (this.PartitionKey != null)
            {
                this.PartitionKey.Validate();
            }


            if (this.ClientEncryptionPolicy != null)
            {
                this.ClientEncryptionPolicy.Validate();
            }


        }
    }
}