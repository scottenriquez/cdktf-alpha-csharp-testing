using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryConfig), fullyQualifiedName: "aws.S3BucketInventoryConfig")]
    public interface IS3BucketInventoryConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>destination block.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestination\"},\"kind\":\"array\"}}")]
        aws.IS3BucketInventoryDestination[] Destination
        {
            get;
        }

        [JsiiProperty(name: "includedObjectVersions", typeJson: "{\"primitive\":\"string\"}")]
        string IncludedObjectVersions
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schedule block.</summary>
        [JsiiProperty(name: "schedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventorySchedule\"},\"kind\":\"array\"}}")]
        aws.IS3BucketInventorySchedule[] Schedule
        {
            get;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketInventoryFilter[]? Filter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "optionalFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OptionalFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryConfig), fullyQualifiedName: "aws.S3BucketInventoryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketInventoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination block.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestination\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketInventoryDestination[] Destination
            {
                get => GetInstanceProperty<aws.IS3BucketInventoryDestination[]>()!;
            }

            [JsiiProperty(name: "includedObjectVersions", typeJson: "{\"primitive\":\"string\"}")]
            public string IncludedObjectVersions
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schedule block.</summary>
            [JsiiProperty(name: "schedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventorySchedule\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketInventorySchedule[] Schedule
            {
                get => GetInstanceProperty<aws.IS3BucketInventorySchedule[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketInventoryFilter[]? Filter
            {
                get => GetInstanceProperty<aws.IS3BucketInventoryFilter[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "optionalFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OptionalFields
            {
                get => GetInstanceProperty<string[]?>();
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
