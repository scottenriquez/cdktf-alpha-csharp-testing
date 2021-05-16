using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.OpsworksApplication), fullyQualifiedName: "aws.OpsworksApplication", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.OpsworksApplicationConfig\"}}]")]
    public class OpsworksApplication : HashiCorp.Cdktf.TerraformResource
    {
        public OpsworksApplication(Constructs.Construct scope, string id, aws.IOpsworksApplicationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksApplication(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAppSource")]
        public virtual void ResetAppSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoBundleOnDeploy")]
        public virtual void ResetAutoBundleOnDeploy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAwsFlowRubySettings")]
        public virtual void ResetAwsFlowRubySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataSourceArn")]
        public virtual void ResetDataSourceArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataSourceDatabaseName")]
        public virtual void ResetDataSourceDatabaseName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataSourceType")]
        public virtual void ResetDataSourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentRoot")]
        public virtual void ResetDocumentRoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomains")]
        public virtual void ResetDomains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableSsl")]
        public virtual void ResetEnableSsl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRailsEnv")]
        public virtual void ResetRailsEnv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShortName")]
        public virtual void ResetShortName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslConfiguration")]
        public virtual void ResetSslConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
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

        [JsiiProperty(name: "stackIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appSourceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IOpsworksApplicationAppSource[]? AppSourceInput
        {
            get => GetInstanceProperty<aws.IOpsworksApplicationAppSource[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoBundleOnDeployInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoBundleOnDeployInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsFlowRubySettingsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsFlowRubySettingsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceDatabaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceDatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceTypeInput
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
        [JsiiProperty(name: "documentRootInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentRootInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DomainsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSslInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableSslInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IOpsworksApplicationEnvironment[]? EnvironmentInput
        {
            get => GetInstanceProperty<aws.IOpsworksApplicationEnvironment[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "railsEnvInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RailsEnvInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShortNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IOpsworksApplicationSslConfiguration[]? SslConfigurationInput
        {
            get => GetInstanceProperty<aws.IOpsworksApplicationSslConfiguration[]?>();
        }

        [JsiiProperty(name: "appSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}")]
        public virtual aws.IOpsworksApplicationAppSource[] AppSource
        {
            get => GetInstanceProperty<aws.IOpsworksApplicationAppSource[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoBundleOnDeploy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoBundleOnDeploy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "awsFlowRubySettings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsFlowRubySettings
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSourceDatabaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceDatabaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceType
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

        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentRoot
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Domains
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableSsl", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableSsl
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}")]
        public virtual aws.IOpsworksApplicationEnvironment[] Environment
        {
            get => GetInstanceProperty<aws.IOpsworksApplicationEnvironment[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "railsEnv", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RailsEnv
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IOpsworksApplicationSslConfiguration[] SslConfiguration
        {
            get => GetInstanceProperty<aws.IOpsworksApplicationSslConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
