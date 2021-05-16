using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IConfigDeliveryChannelConfig), fullyQualifiedName: "aws.ConfigDeliveryChannelConfig")]
    public interface IConfigDeliveryChannelConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3KeyPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>snapshot_delivery_properties block.</summary>
        [JsiiProperty(name: "snapshotDeliveryProperties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigDeliveryChannelSnapshotDeliveryProperties\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IConfigDeliveryChannelSnapshotDeliveryProperties[]? SnapshotDeliveryProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnsTopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigDeliveryChannelConfig), fullyQualifiedName: "aws.ConfigDeliveryChannelConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IConfigDeliveryChannelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>snapshot_delivery_properties block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotDeliveryProperties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigDeliveryChannelSnapshotDeliveryProperties\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IConfigDeliveryChannelSnapshotDeliveryProperties[]? SnapshotDeliveryProperties
            {
                get => GetInstanceProperty<aws.IConfigDeliveryChannelSnapshotDeliveryProperties[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnsTopicArn
            {
                get => GetInstanceProperty<string?>();
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
