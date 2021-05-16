using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SesEventDestination), fullyQualifiedName: "aws.SesEventDestination", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SesEventDestinationConfig\"}}]")]
    public class SesEventDestination : HashiCorp.Cdktf.TerraformResource
    {
        public SesEventDestination(Constructs.Construct scope, string id, aws.ISesEventDestinationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesEventDestination(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesEventDestination(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCloudwatchDestination")]
        public virtual void ResetCloudwatchDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisDestination")]
        public virtual void ResetKinesisDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnsDestination")]
        public virtual void ResetSnsDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "configurationSetNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationSetNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "matchingTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MatchingTypesInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchDestinationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesEventDestinationCloudwatchDestination[]? CloudwatchDestinationInput
        {
            get => GetInstanceProperty<aws.ISesEventDestinationCloudwatchDestination[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisDestinationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationKinesisDestination\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesEventDestinationKinesisDestination[]? KinesisDestinationInput
        {
            get => GetInstanceProperty<aws.ISesEventDestinationKinesisDestination[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsDestinationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationSnsDestination\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISesEventDestinationSnsDestination[]? SnsDestinationInput
        {
            get => GetInstanceProperty<aws.ISesEventDestinationSnsDestination[]?>();
        }

        [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesEventDestinationCloudwatchDestination[] CloudwatchDestination
        {
            get => GetInstanceProperty<aws.ISesEventDestinationCloudwatchDestination[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationSetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Enabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kinesisDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationKinesisDestination\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesEventDestinationKinesisDestination[] KinesisDestination
        {
            get => GetInstanceProperty<aws.ISesEventDestinationKinesisDestination[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MatchingTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snsDestination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesEventDestinationSnsDestination\"},\"kind\":\"array\"}}")]
        public virtual aws.ISesEventDestinationSnsDestination[] SnsDestination
        {
            get => GetInstanceProperty<aws.ISesEventDestinationSnsDestination[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
