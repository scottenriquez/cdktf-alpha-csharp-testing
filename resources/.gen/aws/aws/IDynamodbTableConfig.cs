using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableConfig), fullyQualifiedName: "aws.DynamodbTableConfig")]
    public interface IDynamodbTableConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>attribute block.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableAttribute\"},\"kind\":\"array\"}}")]
        aws.IDynamodbTableAttribute[] Attribute
        {
            get;
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        string HashKey
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>global_secondary_index block.</summary>
        [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDynamodbTableGlobalSecondaryIndex[]? GlobalSecondaryIndex
        {
            get
            {
                return null;
            }
        }

        /// <summary>local_secondary_index block.</summary>
        [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDynamodbTableLocalSecondaryIndex[]? LocalSecondaryIndex
        {
            get
            {
                return null;
            }
        }

        /// <summary>point_in_time_recovery block.</summary>
        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTablePointInTimeRecovery\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDynamodbTablePointInTimeRecovery[]? PointInTimeRecovery
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKey
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>replica block.</summary>
        [JsiiProperty(name: "replica", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableReplica\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDynamodbTableReplica[]? Replica
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_side_encryption block.</summary>
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDynamodbTableServerSideEncryption[]? ServerSideEncryption
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "streamEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? StreamEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamViewType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DynamodbTableTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDynamodbTableTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>ttl block.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableTtl\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDynamodbTableTtl[]? Ttl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableConfig), fullyQualifiedName: "aws.DynamodbTableConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDynamodbTableConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>attribute block.</summary>
            [JsiiProperty(name: "attribute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableAttribute\"},\"kind\":\"array\"}}")]
            public aws.IDynamodbTableAttribute[] Attribute
            {
                get => GetInstanceProperty<aws.IDynamodbTableAttribute[]>()!;
            }

            [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
            public string HashKey
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>global_secondary_index block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDynamodbTableGlobalSecondaryIndex[]? GlobalSecondaryIndex
            {
                get => GetInstanceProperty<aws.IDynamodbTableGlobalSecondaryIndex[]?>();
            }

            /// <summary>local_secondary_index block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDynamodbTableLocalSecondaryIndex[]? LocalSecondaryIndex
            {
                get => GetInstanceProperty<aws.IDynamodbTableLocalSecondaryIndex[]?>();
            }

            /// <summary>point_in_time_recovery block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTablePointInTimeRecovery\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDynamodbTablePointInTimeRecovery[]? PointInTimeRecovery
            {
                get => GetInstanceProperty<aws.IDynamodbTablePointInTimeRecovery[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKey
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>replica block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replica", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableReplica\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDynamodbTableReplica[]? Replica
            {
                get => GetInstanceProperty<aws.IDynamodbTableReplica[]?>();
            }

            /// <summary>server_side_encryption block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDynamodbTableServerSideEncryption[]? ServerSideEncryption
            {
                get => GetInstanceProperty<aws.IDynamodbTableServerSideEncryption[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "streamEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? StreamEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamViewType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DynamodbTableTimeouts\"}", isOptional: true)]
            public aws.IDynamodbTableTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IDynamodbTableTimeouts?>();
            }

            /// <summary>ttl block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableTtl\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDynamodbTableTtl[]? Ttl
            {
                get => GetInstanceProperty<aws.IDynamodbTableTtl[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
