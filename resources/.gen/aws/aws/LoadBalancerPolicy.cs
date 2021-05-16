using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LoadBalancerPolicy), fullyQualifiedName: "aws.LoadBalancerPolicy", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.LoadBalancerPolicyConfig\"}}]")]
    public class LoadBalancerPolicy : HashiCorp.Cdktf.TerraformResource
    {
        public LoadBalancerPolicy(Constructs.Construct scope, string id, aws.ILoadBalancerPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPolicyAttribute")]
        public virtual void ResetPolicyAttribute()
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

        [JsiiProperty(name: "loadBalancerNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyTypeNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyTypeNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyAttributeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LoadBalancerPolicyPolicyAttribute\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILoadBalancerPolicyPolicyAttribute[]? PolicyAttributeInput
        {
            get => GetInstanceProperty<aws.ILoadBalancerPolicyPolicyAttribute[]?>();
        }

        [JsiiProperty(name: "loadBalancerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyAttribute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LoadBalancerPolicyPolicyAttribute\"},\"kind\":\"array\"}}")]
        public virtual aws.ILoadBalancerPolicyPolicyAttribute[] PolicyAttribute
        {
            get => GetInstanceProperty<aws.ILoadBalancerPolicyPolicyAttribute[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyTypeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyTypeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
