using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.S3AccessPoint), fullyQualifiedName: "aws.S3AccessPoint", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.S3AccessPointConfig\"}}]")]
    public class S3AccessPoint : HashiCorp.Cdktf.TerraformResource
    {
        public S3AccessPoint(Constructs.Construct scope, string id, aws.IS3AccessPointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3AccessPoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3AccessPoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicAccessBlockConfiguration")]
        public virtual void ResetPublicAccessBlockConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfiguration")]
        public virtual void ResetVpcConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hasPublicAccessPolicy", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool HasPublicAccessPolicy
        {
            get => GetInstanceProperty<bool>()!;
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

        [JsiiProperty(name: "networkOrigin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkOrigin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicAccessBlockConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointPublicAccessBlockConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3AccessPointPublicAccessBlockConfiguration[]? PublicAccessBlockConfigurationInput
        {
            get => GetInstanceProperty<aws.IS3AccessPointPublicAccessBlockConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointVpcConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3AccessPointVpcConfiguration[]? VpcConfigurationInput
        {
            get => GetInstanceProperty<aws.IS3AccessPointVpcConfiguration[]?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicAccessBlockConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointPublicAccessBlockConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3AccessPointPublicAccessBlockConfiguration[] PublicAccessBlockConfiguration
        {
            get => GetInstanceProperty<aws.IS3AccessPointPublicAccessBlockConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointVpcConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3AccessPointVpcConfiguration[] VpcConfiguration
        {
            get => GetInstanceProperty<aws.IS3AccessPointVpcConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
