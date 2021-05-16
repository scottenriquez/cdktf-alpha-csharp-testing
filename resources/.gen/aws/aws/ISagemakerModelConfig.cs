using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelConfig), fullyQualifiedName: "aws.SagemakerModelConfig")]
    public interface ISagemakerModelConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRoleArn
        {
            get;
        }

        /// <summary>container block.</summary>
        [JsiiProperty(name: "container", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelContainer\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISagemakerModelContainer[]? Container
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnableNetworkIsolation
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>primary_container block.</summary>
        [JsiiProperty(name: "primaryContainer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelPrimaryContainer\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISagemakerModelPrimaryContainer[]? PrimaryContainer
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

        /// <summary>vpc_config block.</summary>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISagemakerModelVpcConfig[]? VpcConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelConfig), fullyQualifiedName: "aws.SagemakerModelConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISagemakerModelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>container block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "container", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelContainer\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISagemakerModelContainer[]? Container
            {
                get => GetInstanceProperty<aws.ISagemakerModelContainer[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnableNetworkIsolation
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>primary_container block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryContainer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelPrimaryContainer\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISagemakerModelPrimaryContainer[]? PrimaryContainer
            {
                get => GetInstanceProperty<aws.ISagemakerModelPrimaryContainer[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>vpc_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISagemakerModelVpcConfig[]? VpcConfig
            {
                get => GetInstanceProperty<aws.ISagemakerModelVpcConfig[]?>();
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
