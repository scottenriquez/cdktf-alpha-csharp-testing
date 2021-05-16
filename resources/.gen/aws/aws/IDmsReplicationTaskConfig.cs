using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDmsReplicationTaskConfig), fullyQualifiedName: "aws.DmsReplicationTaskConfig")]
    public interface IDmsReplicationTaskConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "migrationType", typeJson: "{\"primitive\":\"string\"}")]
        string MigrationType
        {
            get;
        }

        [JsiiProperty(name: "replicationInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationInstanceArn
        {
            get;
        }

        [JsiiProperty(name: "replicationTaskId", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationTaskId
        {
            get;
        }

        [JsiiProperty(name: "sourceEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        string SourceEndpointArn
        {
            get;
        }

        [JsiiProperty(name: "tableMappings", typeJson: "{\"primitive\":\"string\"}")]
        string TableMappings
        {
            get;
        }

        [JsiiProperty(name: "targetEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetEndpointArn
        {
            get;
        }

        [JsiiProperty(name: "cdcStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CdcStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "replicationTaskSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationTaskSettings
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

        [JsiiTypeProxy(nativeType: typeof(IDmsReplicationTaskConfig), fullyQualifiedName: "aws.DmsReplicationTaskConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDmsReplicationTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "migrationType", typeJson: "{\"primitive\":\"string\"}")]
            public string MigrationType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "replicationInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationInstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "replicationTaskId", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationTaskId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sourceEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceEndpointArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "tableMappings", typeJson: "{\"primitive\":\"string\"}")]
            public string TableMappings
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "targetEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetEndpointArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "cdcStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CdcStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "replicationTaskSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationTaskSettings
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
