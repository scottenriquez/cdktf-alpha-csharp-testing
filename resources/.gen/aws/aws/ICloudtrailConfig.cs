using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudtrailConfig), fullyQualifiedName: "aws.CloudtrailConfig")]
    public interface ICloudtrailConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        [JsiiProperty(name: "cloudWatchLogsGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudWatchLogsGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cloudWatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudWatchLogsRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enableLogFileValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnableLogFileValidation
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enableLogging", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnableLogging
        {
            get
            {
                return null;
            }
        }

        /// <summary>event_selector block.</summary>
        [JsiiProperty(name: "eventSelector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudtrailEventSelector\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudtrailEventSelector[]? EventSelector
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeGlobalServiceEvents", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeGlobalServiceEvents
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "isMultiRegionTrail", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IsMultiRegionTrail
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "isOrganizationTrail", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IsOrganizationTrail
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

        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3KeyPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "snsTopicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnsTopicName
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

        [JsiiTypeProxy(nativeType: typeof(ICloudtrailConfig), fullyQualifiedName: "aws.CloudtrailConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudtrailConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "cloudWatchLogsGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudWatchLogsGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cloudWatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudWatchLogsRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enableLogFileValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnableLogFileValidation
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enableLogging", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnableLogging
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>event_selector block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventSelector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudtrailEventSelector\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudtrailEventSelector[]? EventSelector
            {
                get => GetInstanceProperty<aws.ICloudtrailEventSelector[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeGlobalServiceEvents", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeGlobalServiceEvents
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "isMultiRegionTrail", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IsMultiRegionTrail
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "isOrganizationTrail", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IsOrganizationTrail
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "snsTopicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnsTopicName
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
