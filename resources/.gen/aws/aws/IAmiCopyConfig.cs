using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAmiCopyConfig), fullyQualifiedName: "aws.AmiCopyConfig")]
    public interface IAmiCopyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "sourceAmiId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAmiId
        {
            get;
        }

        [JsiiProperty(name: "sourceAmiRegion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceAmiRegion
        {
            get;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_block_device block.</summary>
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAmiCopyEbsBlockDevice[]? EbsBlockDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Encrypted
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_block_device block.</summary>
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAmiCopyEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AmiCopyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAmiCopyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAmiCopyConfig), fullyQualifiedName: "aws.AmiCopyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAmiCopyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sourceAmiId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceAmiId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sourceAmiRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceAmiRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAmiCopyEbsBlockDevice[]? EbsBlockDevice
            {
                get => GetInstanceProperty<aws.IAmiCopyEbsBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Encrypted
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>ephemeral_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAmiCopyEphemeralBlockDevice[]? EphemeralBlockDevice
            {
                get => GetInstanceProperty<aws.IAmiCopyEphemeralBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
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
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AmiCopyTimeouts\"}", isOptional: true)]
            public aws.IAmiCopyTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IAmiCopyTimeouts?>();
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
