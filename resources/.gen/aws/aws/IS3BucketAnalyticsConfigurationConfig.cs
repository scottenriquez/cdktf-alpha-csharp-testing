using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationConfig), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationConfig")]
    public interface IS3BucketAnalyticsConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>filter block.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketAnalyticsConfigurationFilter[]? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_class_analysis block.</summary>
        [JsiiProperty(name: "storageClassAnalysis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysis\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis[]? StorageClassAnalysis
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationConfig), fullyQualifiedName: "aws.S3BucketAnalyticsConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketAnalyticsConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketAnalyticsConfigurationFilter[]? Filter
            {
                get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationFilter[]?>();
            }

            /// <summary>storage_class_analysis block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageClassAnalysis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysis\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis[]? StorageClassAnalysis
            {
                get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis[]?>();
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
