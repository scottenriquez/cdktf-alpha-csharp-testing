using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAmiFromInstanceConfig), fullyQualifiedName: "aws.AmiFromInstanceConfig")]
    public interface IAmiFromInstanceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "sourceInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceInstanceId
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
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiFromInstanceEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAmiFromInstanceEbsBlockDevice[]? EbsBlockDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_block_device block.</summary>
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiFromInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAmiFromInstanceEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "snapshotWithoutReboot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SnapshotWithoutReboot
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AmiFromInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAmiFromInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAmiFromInstanceConfig), fullyQualifiedName: "aws.AmiFromInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAmiFromInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sourceInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceInstanceId
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
            [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiFromInstanceEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAmiFromInstanceEbsBlockDevice[]? EbsBlockDevice
            {
                get => GetInstanceProperty<aws.IAmiFromInstanceEbsBlockDevice[]?>();
            }

            /// <summary>ephemeral_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiFromInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAmiFromInstanceEphemeralBlockDevice[]? EphemeralBlockDevice
            {
                get => GetInstanceProperty<aws.IAmiFromInstanceEphemeralBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "snapshotWithoutReboot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SnapshotWithoutReboot
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AmiFromInstanceTimeouts\"}", isOptional: true)]
            public aws.IAmiFromInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IAmiFromInstanceTimeouts?>();
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
