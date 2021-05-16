using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CodebuildProject), fullyQualifiedName: "aws.CodebuildProject", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CodebuildProjectConfig\"}}]")]
    public class CodebuildProject : HashiCorp.Cdktf.TerraformResource
    {
        public CodebuildProject(Constructs.Construct scope, string id, aws.ICodebuildProjectConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProject(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBadgeEnabled")]
        public virtual void ResetBadgeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildTimeout")]
        public virtual void ResetBuildTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCache")]
        public virtual void ResetCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionKey")]
        public virtual void ResetEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogsConfig")]
        public virtual void ResetLogsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueuedTimeout")]
        public virtual void ResetQueuedTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryArtifacts")]
        public virtual void ResetSecondaryArtifacts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondarySources")]
        public virtual void ResetSecondarySources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceVersion")]
        public virtual void ResetSourceVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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

        [JsiiProperty(name: "artifactsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectArtifacts\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectArtifacts[] ArtifactsInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectArtifacts[]>()!;
        }

        [JsiiProperty(name: "badgeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BadgeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environmentInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironment\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectEnvironment[] EnvironmentInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectEnvironment[]>()!;
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

        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSource\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectSource[] SourceInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectSource[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "badgeEnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? BadgeEnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BuildTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectCache\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodebuildProjectCache[]? CacheInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectCache[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodebuildProjectLogsConfig[]? LogsConfigInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectLogsConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queuedTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueuedTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryArtifactsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodebuildProjectSecondaryArtifacts[]? SecondaryArtifactsInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectSecondaryArtifacts[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondarySourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodebuildProjectSecondarySources[]? SecondarySourcesInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectSecondarySources[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodebuildProjectVpcConfig[]? VpcConfigInput
        {
            get => GetInstanceProperty<aws.ICodebuildProjectVpcConfig[]?>();
        }

        [JsiiProperty(name: "artifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectArtifacts\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectArtifacts[] Artifacts
        {
            get => GetInstanceProperty<aws.ICodebuildProjectArtifacts[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool BadgeEnabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BuildTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cache", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectCache\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectCache[] Cache
        {
            get => GetInstanceProperty<aws.ICodebuildProjectCache[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironment\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectEnvironment[] Environment
        {
            get => GetInstanceProperty<aws.ICodebuildProjectEnvironment[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectLogsConfig[] LogsConfig
        {
            get => GetInstanceProperty<aws.ICodebuildProjectLogsConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueuedTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectSecondaryArtifacts[] SecondaryArtifacts
        {
            get => GetInstanceProperty<aws.ICodebuildProjectSecondaryArtifacts[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondarySources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectSecondarySources[] SecondarySources
        {
            get => GetInstanceProperty<aws.ICodebuildProjectSecondarySources[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSource\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectSource[] Source
        {
            get => GetInstanceProperty<aws.ICodebuildProjectSource[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceVersion
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

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectVpcConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildProjectVpcConfig[] VpcConfig
        {
            get => GetInstanceProperty<aws.ICodebuildProjectVpcConfig[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
