using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VpcEndpointServiceAllowedPrincipal), fullyQualifiedName: "aws.VpcEndpointServiceAllowedPrincipal", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VpcEndpointServiceAllowedPrincipalConfig\"}}]")]
    public class VpcEndpointServiceAllowedPrincipal : HashiCorp.Cdktf.TerraformResource
    {
        public VpcEndpointServiceAllowedPrincipal(Constructs.Construct scope, string id, aws.IVpcEndpointServiceAllowedPrincipalConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcEndpointServiceAllowedPrincipal(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcEndpointServiceAllowedPrincipal(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "principalArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcEndpointServiceIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcEndpointServiceIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "principalArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcEndpointServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcEndpointServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
