using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayNfsFileShareConfig), fullyQualifiedName: "aws.StoragegatewayNfsFileShareConfig")]
    public interface IStoragegatewayNfsFileShareConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "clientList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ClientList
        {
            get;
        }

        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayArn
        {
            get;
        }

        [JsiiProperty(name: "locationArn", typeJson: "{\"primitive\":\"string\"}")]
        string LocationArn
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "defaultStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultStorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "guessMimeTypeEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? GuessMimeTypeEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kmsEncrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? KmsEncrypted
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>nfs_file_share_defaults block.</summary>
        [JsiiProperty(name: "nfsFileShareDefaults", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayNfsFileShareNfsFileShareDefaults\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[]? NfsFileShareDefaults
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "objectAcl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectAcl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReadOnly
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requesterPays", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequesterPays
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "squash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Squash
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayNfsFileShareTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IStoragegatewayNfsFileShareTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayNfsFileShareConfig), fullyQualifiedName: "aws.StoragegatewayNfsFileShareConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IStoragegatewayNfsFileShareConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "clientList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ClientList
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "locationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LocationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultStorageClass
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "guessMimeTypeEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? GuessMimeTypeEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsEncrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? KmsEncrypted
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>nfs_file_share_defaults block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nfsFileShareDefaults", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayNfsFileShareNfsFileShareDefaults\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[]? NfsFileShareDefaults
            {
                get => GetInstanceProperty<aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "objectAcl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectAcl
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requesterPays", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequesterPays
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "squash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Squash
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
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayNfsFileShareTimeouts\"}", isOptional: true)]
            public aws.IStoragegatewayNfsFileShareTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IStoragegatewayNfsFileShareTimeouts?>();
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
