using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticBeanstalkEnvironmentConfig), fullyQualifiedName: "aws.ElasticBeanstalkEnvironmentConfig")]
    public interface IElasticBeanstalkEnvironmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        string Application
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "cnamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CnamePrefix
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

        [JsiiProperty(name: "platformArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "pollInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PollInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>setting block.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticBeanstalkEnvironmentSetting\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticBeanstalkEnvironmentSetting[]? Setting
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SolutionStackName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "templateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemplateName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tier
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "waitForReadyTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WaitForReadyTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticBeanstalkEnvironmentConfig), fullyQualifiedName: "aws.ElasticBeanstalkEnvironmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticBeanstalkEnvironmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
            public string Application
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "cnamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CnamePrefix
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
            [JsiiProperty(name: "platformArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "pollInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PollInterval
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>setting block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticBeanstalkEnvironmentSetting\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticBeanstalkEnvironmentSetting[]? Setting
            {
                get => GetInstanceProperty<aws.IElasticBeanstalkEnvironmentSetting[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SolutionStackName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "templateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemplateName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tier
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionLabel
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "waitForReadyTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WaitForReadyTimeout
            {
                get => GetInstanceProperty<string?>();
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
