using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VpcEndpointSubnetAssociation), fullyQualifiedName: "aws.VpcEndpointSubnetAssociation", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VpcEndpointSubnetAssociationConfig\"}}]")]
    public class VpcEndpointSubnetAssociation : HashiCorp.Cdktf.TerraformResource
    {
        public VpcEndpointSubnetAssociation(Constructs.Construct scope, string id, aws.IVpcEndpointSubnetAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcEndpointSubnetAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcEndpointSubnetAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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

        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcEndpointIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcEndpointIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.VpcEndpointSubnetAssociationTimeouts\"}", isOptional: true)]
        public virtual aws.IVpcEndpointSubnetAssociationTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IVpcEndpointSubnetAssociationTimeouts?>();
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.VpcEndpointSubnetAssociationTimeouts\"}")]
        public virtual aws.IVpcEndpointSubnetAssociationTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IVpcEndpointSubnetAssociationTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
