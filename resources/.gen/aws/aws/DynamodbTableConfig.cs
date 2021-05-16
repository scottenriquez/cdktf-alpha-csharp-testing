using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DynamodbTableConfig")]
    public class DynamodbTableConfig : aws.IDynamodbTableConfig
    {
        /// <summary>attribute block.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableAttribute\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IDynamodbTableAttribute[] Attribute
        {
            get;
            set;
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HashKey
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

        [JsiiOptional]
        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BillingMode
        {
            get;
            set;
        }

        /// <summary>global_secondary_index block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDynamodbTableGlobalSecondaryIndex[]? GlobalSecondaryIndex
        {
            get;
            set;
        }

        /// <summary>local_secondary_index block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDynamodbTableLocalSecondaryIndex[]? LocalSecondaryIndex
        {
            get;
            set;
        }

        /// <summary>point_in_time_recovery block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTablePointInTimeRecovery\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDynamodbTablePointInTimeRecovery[]? PointInTimeRecovery
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RangeKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ReadCapacity
        {
            get;
            set;
        }

        /// <summary>replica block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replica", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableReplica\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDynamodbTableReplica[]? Replica
        {
            get;
            set;
        }

        /// <summary>server_side_encryption block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDynamodbTableServerSideEncryption[]? ServerSideEncryption
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? StreamEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StreamViewType
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

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DynamodbTableTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IDynamodbTableTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>ttl block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableTtl\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDynamodbTableTtl[]? Ttl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? WriteCapacity
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
