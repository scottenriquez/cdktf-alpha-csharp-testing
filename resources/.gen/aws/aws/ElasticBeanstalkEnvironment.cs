using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ElasticBeanstalkEnvironment), fullyQualifiedName: "aws.ElasticBeanstalkEnvironment", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ElasticBeanstalkEnvironmentConfig\"}}]")]
    public class ElasticBeanstalkEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        public ElasticBeanstalkEnvironment(Constructs.Construct scope, string id, aws.IElasticBeanstalkEnvironmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticBeanstalkEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticBeanstalkEnvironment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "allSettings", returnsJson: "{\"type\":{\"fqn\":\"aws.ElasticBeanstalkEnvironmentAllSettings\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.ElasticBeanstalkEnvironmentAllSettings AllSettings(string index)
        {
            return InvokeInstanceMethod<aws.ElasticBeanstalkEnvironmentAllSettings>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetCnamePrefix")]
        public virtual void ResetCnamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformArn")]
        public virtual void ResetPlatformArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPollInterval")]
        public virtual void ResetPollInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetting")]
        public virtual void ResetSetting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSolutionStackName")]
        public virtual void ResetSolutionStackName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemplateName")]
        public virtual void ResetTemplateName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTier")]
        public virtual void ResetTier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionLabel")]
        public virtual void ResetVersionLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForReadyTimeout")]
        public virtual void ResetWaitForReadyTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "applicationInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoscalingGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Instances
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "launchConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LaunchConfigurations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoadBalancers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Queues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Triggers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cnamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CnamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pollIntervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PollIntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "settingInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticBeanstalkEnvironmentSetting\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticBeanstalkEnvironmentSetting[]? SettingInput
        {
            get => GetInstanceProperty<aws.IElasticBeanstalkEnvironmentSetting[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "solutionStackNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SolutionStackNameInput
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
        [JsiiProperty(name: "templateNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemplateNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForReadyTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WaitForReadyTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cnamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CnamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "platformArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pollInterval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PollInterval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticBeanstalkEnvironmentSetting\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticBeanstalkEnvironmentSetting[] Setting
        {
            get => GetInstanceProperty<aws.IElasticBeanstalkEnvironmentSetting[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SolutionStackName
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

        [JsiiProperty(name: "templateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForReadyTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WaitForReadyTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
