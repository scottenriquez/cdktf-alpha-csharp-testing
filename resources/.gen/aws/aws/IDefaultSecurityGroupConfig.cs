using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDefaultSecurityGroupConfig), fullyQualifiedName: "aws.DefaultSecurityGroupConfig")]
    public interface IDefaultSecurityGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "egress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupEgress\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDefaultSecurityGroupEgress[]? Egress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ingress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupIngress\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDefaultSecurityGroupIngress[]? Ingress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "revokeRulesOnDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RevokeRulesOnDelete
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

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DefaultSecurityGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDefaultSecurityGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDefaultSecurityGroupConfig), fullyQualifiedName: "aws.DefaultSecurityGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDefaultSecurityGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "egress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupEgress\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDefaultSecurityGroupEgress[]? Egress
            {
                get => GetInstanceProperty<aws.IDefaultSecurityGroupEgress[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ingress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupIngress\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDefaultSecurityGroupIngress[]? Ingress
            {
                get => GetInstanceProperty<aws.IDefaultSecurityGroupIngress[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "revokeRulesOnDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RevokeRulesOnDelete
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DefaultSecurityGroupTimeouts\"}", isOptional: true)]
            public aws.IDefaultSecurityGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IDefaultSecurityGroupTimeouts?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcId
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
