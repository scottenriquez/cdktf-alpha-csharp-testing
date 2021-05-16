using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOpsworksApplicationConfig), fullyQualifiedName: "aws.OpsworksApplicationConfig")]
    public interface IOpsworksApplicationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        string StackId
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>app_source block.</summary>
        [JsiiProperty(name: "appSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IOpsworksApplicationAppSource[]? AppSource
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoBundleOnDeploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoBundleOnDeploy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "awsFlowRubySettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsFlowRubySettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dataSourceDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceDatabaseName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dataSourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentRoot
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Domains
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enableSsl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnableSsl
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment block.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IOpsworksApplicationEnvironment[]? Environment
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "railsEnv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RailsEnv
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShortName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_configuration block.</summary>
        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IOpsworksApplicationSslConfiguration[]? SslConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksApplicationConfig), fullyQualifiedName: "aws.OpsworksApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IOpsworksApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
            public string StackId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>app_source block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IOpsworksApplicationAppSource[]? AppSource
            {
                get => GetInstanceProperty<aws.IOpsworksApplicationAppSource[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoBundleOnDeploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoBundleOnDeploy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "awsFlowRubySettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsFlowRubySettings
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dataSourceDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dataSourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentRoot
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Domains
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enableSsl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnableSsl
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>environment block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IOpsworksApplicationEnvironment[]? Environment
            {
                get => GetInstanceProperty<aws.IOpsworksApplicationEnvironment[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "railsEnv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RailsEnv
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShortName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ssl_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IOpsworksApplicationSslConfiguration[]? SslConfiguration
            {
                get => GetInstanceProperty<aws.IOpsworksApplicationSslConfiguration[]?>();
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
