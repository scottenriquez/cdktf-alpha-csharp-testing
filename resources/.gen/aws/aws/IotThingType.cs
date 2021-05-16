using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.IotThingType), fullyQualifiedName: "aws.IotThingType", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.IotThingTypeConfig\"}}]")]
    public class IotThingType : HashiCorp.Cdktf.TerraformResource
    {
        public IotThingType(Constructs.Construct scope, string id, aws.IIotThingTypeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingType(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDeprecated")]
        public virtual void ResetDeprecated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProperties")]
        public virtual void ResetProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deprecatedInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? DeprecatedInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotThingTypeProperties\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotThingTypeProperties[]? PropertiesInput
        {
            get => GetInstanceProperty<aws.IIotThingTypeProperties[]?>();
        }

        [JsiiProperty(name: "deprecated", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Deprecated
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotThingTypeProperties\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotThingTypeProperties[] Properties
        {
            get => GetInstanceProperty<aws.IIotThingTypeProperties[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
