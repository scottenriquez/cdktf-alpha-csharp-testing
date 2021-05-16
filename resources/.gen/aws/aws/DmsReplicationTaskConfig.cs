using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DmsReplicationTaskConfig")]
    public class DmsReplicationTaskConfig : aws.IDmsReplicationTaskConfig
    {
        [JsiiProperty(name: "migrationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MigrationType
        {
            get;
            set;
        }

        [JsiiProperty(name: "replicationInstanceArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReplicationInstanceArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "replicationTaskId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReplicationTaskId
        {
            get;
            set;
        }

        [JsiiProperty(name: "sourceEndpointArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceEndpointArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "tableMappings", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TableMappings
        {
            get;
            set;
        }

        [JsiiProperty(name: "targetEndpointArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TargetEndpointArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdcStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CdcStartTime
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationTaskSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplicationTaskSettings
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
