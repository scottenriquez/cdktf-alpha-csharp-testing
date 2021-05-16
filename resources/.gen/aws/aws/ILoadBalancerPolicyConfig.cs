using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPolicyConfig), fullyQualifiedName: "aws.LoadBalancerPolicyConfig")]
    public interface ILoadBalancerPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "loadBalancerName", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerName
        {
            get;
        }

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyName
        {
            get;
        }

        [JsiiProperty(name: "policyTypeName", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyTypeName
        {
            get;
        }

        /// <summary>policy_attribute block.</summary>
        [JsiiProperty(name: "policyAttribute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LoadBalancerPolicyPolicyAttribute\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILoadBalancerPolicyPolicyAttribute[]? PolicyAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPolicyConfig), fullyQualifiedName: "aws.LoadBalancerPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILoadBalancerPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "loadBalancerName", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "policyTypeName", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyTypeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>policy_attribute block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyAttribute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LoadBalancerPolicyPolicyAttribute\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILoadBalancerPolicyPolicyAttribute[]? PolicyAttribute
            {
                get => GetInstanceProperty<aws.ILoadBalancerPolicyPolicyAttribute[]?>();
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
