using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.S3BucketPublicAccessBlock), fullyQualifiedName: "aws.S3BucketPublicAccessBlock", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.S3BucketPublicAccessBlockConfig\"}}]")]
    public class S3BucketPublicAccessBlock : HashiCorp.Cdktf.TerraformResource
    {
        public S3BucketPublicAccessBlock(Constructs.Construct scope, string id, aws.IS3BucketPublicAccessBlockConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketPublicAccessBlock(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketPublicAccessBlock(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBlockPublicAcls")]
        public virtual void ResetBlockPublicAcls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockPublicPolicy")]
        public virtual void ResetBlockPublicPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnorePublicAcls")]
        public virtual void ResetIgnorePublicAcls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestrictPublicBuckets")]
        public virtual void ResetRestrictPublicBuckets()
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

        [JsiiOptional]
        [JsiiProperty(name: "blockPublicAclsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? BlockPublicAclsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockPublicPolicyInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? BlockPublicPolicyInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignorePublicAclsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? IgnorePublicAclsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restrictPublicBucketsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RestrictPublicBucketsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "blockPublicAcls", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool BlockPublicAcls
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockPublicPolicy", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool BlockPublicPolicy
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ignorePublicAcls", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool IgnorePublicAcls
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restrictPublicBuckets", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RestrictPublicBuckets
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}
