using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.EksCluster), fullyQualifiedName: "aws.EksCluster", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.EksClusterConfig\"}}]")]
    public class EksCluster : HashiCorp.Cdktf.TerraformResource
    {
        public EksCluster(Constructs.Construct scope, string id, aws.IEksClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "certificateAuthority", returnsJson: "{\"type\":{\"fqn\":\"aws.EksClusterCertificateAuthority\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.EksClusterCertificateAuthority CertificateAuthority(string index)
        {
            return InvokeInstanceMethod<aws.EksClusterCertificateAuthority>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "identity", returnsJson: "{\"type\":{\"fqn\":\"aws.EksClusterIdentity\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.EksClusterIdentity Identity(string index)
        {
            return InvokeInstanceMethod<aws.EksClusterIdentity>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetEnabledClusterLogTypes")]
        public virtual void ResetEnabledClusterLogTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionConfig")]
        public virtual void ResetEncryptionConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
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

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
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

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksClusterVpcConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IEksClusterVpcConfig[] VpcConfigInput
        {
            get => GetInstanceProperty<aws.IEksClusterVpcConfig[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledClusterLogTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledClusterLogTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksClusterEncryptionConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEksClusterEncryptionConfig[]? EncryptionConfigInput
        {
            get => GetInstanceProperty<aws.IEksClusterEncryptionConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.EksClusterTimeouts\"}", isOptional: true)]
        public virtual aws.IEksClusterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IEksClusterTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enabledClusterLogTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledClusterLogTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksClusterEncryptionConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IEksClusterEncryptionConfig[] EncryptionConfig
        {
            get => GetInstanceProperty<aws.IEksClusterEncryptionConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EksClusterTimeouts\"}")]
        public virtual aws.IEksClusterTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IEksClusterTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksClusterVpcConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IEksClusterVpcConfig[] VpcConfig
        {
            get => GetInstanceProperty<aws.IEksClusterVpcConfig[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
