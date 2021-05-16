using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2InstanceTypeOffering), fullyQualifiedName: "aws.DataAwsEc2InstanceTypeOffering", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DataAwsEc2InstanceTypeOfferingConfig\"}}]")]
    public class DataAwsEc2InstanceTypeOffering : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsEc2InstanceTypeOffering(Constructs.Construct scope, string id, aws.IDataAwsEc2InstanceTypeOfferingConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceTypeOffering(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceTypeOffering(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocationType")]
        public virtual void ResetLocationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredInstanceTypes")]
        public virtual void ResetPreferredInstanceTypes()
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

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsEc2InstanceTypeOfferingFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDataAwsEc2InstanceTypeOfferingFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.IDataAwsEc2InstanceTypeOfferingFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredInstanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreferredInstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsEc2InstanceTypeOfferingFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsEc2InstanceTypeOfferingFilter[] Filter
        {
            get => GetInstanceProperty<aws.IDataAwsEc2InstanceTypeOfferingFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
