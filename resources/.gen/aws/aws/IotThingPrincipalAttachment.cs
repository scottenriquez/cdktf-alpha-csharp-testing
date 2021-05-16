using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.IotThingPrincipalAttachment), fullyQualifiedName: "aws.IotThingPrincipalAttachment", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.IotThingPrincipalAttachmentConfig\"}}]")]
    public class IotThingPrincipalAttachment : HashiCorp.Cdktf.TerraformResource
    {
        public IotThingPrincipalAttachment(Constructs.Construct scope, string id, aws.IIotThingPrincipalAttachmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingPrincipalAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingPrincipalAttachment(DeputyProps props): base(props)
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

        [JsiiProperty(name: "principalInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thingInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThingInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Principal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Thing
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
