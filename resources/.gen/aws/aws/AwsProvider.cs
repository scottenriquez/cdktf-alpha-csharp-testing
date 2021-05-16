using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AwsProvider), fullyQualifiedName: "aws.AwsProvider", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AwsProviderConfig\"}}]")]
    public class AwsProvider : HashiCorp.Cdktf.TerraformProvider
    {
        public AwsProvider(Constructs.Construct scope, string id, aws.IAwsProviderConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AwsProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AwsProvider(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessKey")]
        public virtual void ResetAccessKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedAccountIds")]
        public virtual void ResetAllowedAccountIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAssumeRole")]
        public virtual void ResetAssumeRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpoints")]
        public virtual void ResetEndpoints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForbiddenAccountIds")]
        public virtual void ResetForbiddenAccountIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreTags")]
        public virtual void ResetIgnoreTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInsecure")]
        public virtual void ResetInsecure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxRetries")]
        public virtual void ResetMaxRetries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfile")]
        public virtual void ResetProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3ForcePathStyle")]
        public virtual void ResetS3ForcePathStyle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretKey")]
        public virtual void ResetSecretKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharedCredentialsFile")]
        public virtual void ResetSharedCredentialsFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipCredentialsValidation")]
        public virtual void ResetSkipCredentialsValidation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipGetEc2Platforms")]
        public virtual void ResetSkipGetEc2Platforms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipMetadataApiCheck")]
        public virtual void ResetSkipMetadataApiCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipRegionValidation")]
        public virtual void ResetSkipRegionValidation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipRequestingAccountId")]
        public virtual void ResetSkipRequestingAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToken")]
        public virtual void ResetToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedAccountIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedAccountIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assumeRoleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderAssumeRole\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAwsProviderAssumeRole[]? AssumeRoleInput
        {
            get => GetInstanceProperty<aws.IAwsProviderAssumeRole[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderEndpoints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAwsProviderEndpoints[]? EndpointsInput
        {
            get => GetInstanceProperty<aws.IAwsProviderEndpoints[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forbiddenAccountIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ForbiddenAccountIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderIgnoreTags\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAwsProviderIgnoreTags[]? IgnoreTagsInput
        {
            get => GetInstanceProperty<aws.IAwsProviderIgnoreTags[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "insecureInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? InsecureInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ForcePathStyleInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? S3ForcePathStyleInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedCredentialsFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SharedCredentialsFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipCredentialsValidationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipCredentialsValidationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipGetEc2PlatformsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipGetEc2PlatformsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipMetadataApiCheckInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipMetadataApiCheckInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipRegionValidationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipRegionValidationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipRequestingAccountIdInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipRequestingAccountIdInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessKey
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public override string? Alias
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedAccountIds
        {
            get => GetInstanceProperty<string[]?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "assumeRole", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderAssumeRole\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAwsProviderAssumeRole[]? AssumeRole
        {
            get => GetInstanceProperty<aws.IAwsProviderAssumeRole[]?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderEndpoints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAwsProviderEndpoints[]? Endpoints
        {
            get => GetInstanceProperty<aws.IAwsProviderEndpoints[]?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ForbiddenAccountIds
        {
            get => GetInstanceProperty<string[]?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreTags", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderIgnoreTags\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAwsProviderIgnoreTags[]? IgnoreTags
        {
            get => GetInstanceProperty<aws.IAwsProviderIgnoreTags[]?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "insecure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? Insecure
        {
            get => GetInstanceProperty<bool?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRetries
        {
            get => GetInstanceProperty<double?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Profile
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ForcePathStyle", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? S3ForcePathStyle
        {
            get => GetInstanceProperty<bool?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretKey
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedCredentialsFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SharedCredentialsFile
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipCredentialsValidation
        {
            get => GetInstanceProperty<bool?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipGetEc2Platforms", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipGetEc2Platforms
        {
            get => GetInstanceProperty<bool?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipMetadataApiCheck
        {
            get => GetInstanceProperty<bool?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipRegionValidation
        {
            get => GetInstanceProperty<bool?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SkipRequestingAccountId
        {
            get => GetInstanceProperty<bool?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Token
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }
    }
}
