using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.MacieS3BucketAssociation), fullyQualifiedName: "aws.MacieS3BucketAssociation", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.MacieS3BucketAssociationConfig\"}}]")]
    public class MacieS3BucketAssociation : HashiCorp.Cdktf.TerraformResource
    {
        public MacieS3BucketAssociation(Constructs.Construct scope, string id, aws.IMacieS3BucketAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MacieS3BucketAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MacieS3BucketAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClassificationType")]
        public virtual void ResetClassificationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemberAccountId")]
        public virtual void ResetMemberAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "classificationTypeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MacieS3BucketAssociationClassificationType\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMacieS3BucketAssociationClassificationType[]? ClassificationTypeInput
        {
            get => GetInstanceProperty<aws.IMacieS3BucketAssociationClassificationType[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memberAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemberAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "classificationType", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MacieS3BucketAssociationClassificationType\"},\"kind\":\"array\"}}")]
        public virtual aws.IMacieS3BucketAssociationClassificationType[] ClassificationType
        {
            get => GetInstanceProperty<aws.IMacieS3BucketAssociationClassificationType[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memberAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
