// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Task properties of the software update configuration.
    /// </summary>
    public partial class SoftwareUpdateConfigurationTasks
    {
        /// <summary>
        /// Initializes a new instance of the SoftwareUpdateConfigurationTasks class.
        /// </summary>
        public SoftwareUpdateConfigurationTasks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SoftwareUpdateConfigurationTasks class.
        /// </summary>

        /// <param name="preTask">Pre task properties.
        /// </param>

        /// <param name="postTask">Post task properties.
        /// </param>
        public SoftwareUpdateConfigurationTasks(TaskProperties preTask = default(TaskProperties), TaskProperties postTask = default(TaskProperties))

        {
            this.PreTask = preTask;
            this.PostTask = postTask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets pre task properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "preTask")]
        public TaskProperties PreTask {get; set; }

        /// <summary>
        /// Gets or sets post task properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "postTask")]
        public TaskProperties PostTask {get; set; }
    }
}