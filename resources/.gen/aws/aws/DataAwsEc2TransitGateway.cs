using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2TransitGateway), fullyQualifiedName: "aws.DataAwsEc2TransitGateway", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DataAwsEc2TransitGatewayConfig\"}}]")]
    public class DataAwsEc2TransitGateway : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsEc2TransitGateway(Constructs.Construct scope, string id, aws.IDataAwsEc2TransitGatewayConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2TransitGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2TransitGateway(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "amazonSideAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmazonSideAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associationDefaultRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationDefaultRouteTableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoAcceptSharedAttachments", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoAcceptSharedAttachments
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRouteTableAssociation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRouteTableAssociation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRouteTablePropagation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRouteTablePropagation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "propagationDefaultRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagationDefaultRouteTableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpnEcmpSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnEcmpSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsEc2TransitGatewayFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDataAwsEc2TransitGatewayFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.IDataAwsEc2TransitGatewayFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsEc2TransitGatewayFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsEc2TransitGatewayFilter[] Filter
        {
            get => GetInstanceProperty<aws.IDataAwsEc2TransitGatewayFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
