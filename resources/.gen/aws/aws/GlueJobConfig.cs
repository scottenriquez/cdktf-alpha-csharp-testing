using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueJobConfig")]
    public class GlueJobConfig : aws.IGlueJobConfig
    {
        /// <summary>command block.</summary>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobCommand\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IGlueJobCommand[] Command
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocatedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AllocatedCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Connections
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefaultArguments
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>execution_property block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionProperty", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobExecutionProperty\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueJobExecutionProperty[]? ExecutionProperty
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "glueVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GlueVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxRetries
        {
            get;
            set;
        }

        /// <summary>notification_property block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationProperty", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobNotificationProperty\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueJobNotificationProperty[]? NotificationProperty
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? NumberOfWorkers
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SecurityConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Timeout
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WorkerType
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
