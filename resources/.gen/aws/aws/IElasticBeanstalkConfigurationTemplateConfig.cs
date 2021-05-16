using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticBeanstalkConfigurationTemplateConfig), fullyQualifiedName: "aws.ElasticBeanstalkConfigurationTemplateConfig")]
    public interface IElasticBeanstalkConfigurationTemplateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnvironmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>setting block.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticBeanstalkConfigurationTemplateSetting\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticBeanstalkConfigurationTemplateSetting[]? Setting
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

        [JsiiTypeProxy(nativeType: typeof(IElasticBeanstalkConfigurationTemplateConfig), fullyQualifiedName: "aws.ElasticBeanstalkConfigurationTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticBeanstalkConfigurationTemplateConfig
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
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnvironmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>setting block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticBeanstalkConfigurationTemplateSetting\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticBeanstalkConfigurationTemplateSetting[]? Setting
            {
                get => GetInstanceProperty<aws.IElasticBeanstalkConfigurationTemplateSetting[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SolutionStackName
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
