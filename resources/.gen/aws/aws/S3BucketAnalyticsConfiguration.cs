using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.S3BucketAnalyticsConfiguration), fullyQualifiedName: "aws.S3BucketAnalyticsConfiguration", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationConfig\"}}]")]
    public class S3BucketAnalyticsConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        public S3BucketAnalyticsConfiguration(Constructs.Construct scope, string id, aws.IS3BucketAnalyticsConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageClassAnalysis")]
        public virtual void ResetStorageClassAnalysis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketAnalyticsConfigurationFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassAnalysisInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysis\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis[]? StorageClassAnalysisInput
        {
            get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis[]?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketAnalyticsConfigurationFilter[] Filter
        {
            get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageClassAnalysis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketAnalyticsConfigurationStorageClassAnalysis\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis[] StorageClassAnalysis
        {
            get => GetInstanceProperty<aws.IS3BucketAnalyticsConfigurationStorageClassAnalysis[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
