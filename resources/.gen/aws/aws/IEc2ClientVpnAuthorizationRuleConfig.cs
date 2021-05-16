using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2ClientVpnAuthorizationRuleConfig), fullyQualifiedName: "aws.Ec2ClientVpnAuthorizationRuleConfig")]
    public interface IEc2ClientVpnAuthorizationRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "clientVpnEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientVpnEndpointId
        {
            get;
        }

        [JsiiProperty(name: "targetNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        string TargetNetworkCidr
        {
            get;
        }

        [JsiiProperty(name: "accessGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "authorizeAllGroups", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AuthorizeAllGroups
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

        [JsiiTypeProxy(nativeType: typeof(IEc2ClientVpnAuthorizationRuleConfig), fullyQualifiedName: "aws.Ec2ClientVpnAuthorizationRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2ClientVpnAuthorizationRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "clientVpnEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientVpnEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "targetNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetNetworkCidr
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "accessGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "authorizeAllGroups", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AuthorizeAllGroups
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
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
