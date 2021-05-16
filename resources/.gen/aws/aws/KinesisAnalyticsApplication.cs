using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.KinesisAnalyticsApplication), fullyQualifiedName: "aws.KinesisAnalyticsApplication", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.KinesisAnalyticsApplicationConfig\"}}]")]
    public class KinesisAnalyticsApplication : HashiCorp.Cdktf.TerraformResource
    {
        public KinesisAnalyticsApplication(Constructs.Construct scope, string id, aws.IKinesisAnalyticsApplicationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplication(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCloudwatchLoggingOptions")]
        public virtual void ResetCloudwatchLoggingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCode")]
        public virtual void ResetCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputs")]
        public virtual void ResetInputs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputs")]
        public virtual void ResetOutputs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReferenceDataSources")]
        public virtual void ResetReferenceDataSources()
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

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdateTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdateTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisAnalyticsApplicationCloudwatchLoggingOptions[]? CloudwatchLoggingOptionsInput
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationCloudwatchLoggingOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisAnalyticsApplicationInputs[]? InputsInput
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisAnalyticsApplicationOutputs[]? OutputsInput
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationOutputs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceDataSourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSources\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisAnalyticsApplicationReferenceDataSources[]? ReferenceDataSourcesInput
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSources[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisAnalyticsApplicationCloudwatchLoggingOptions[] CloudwatchLoggingOptions
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationCloudwatchLoggingOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Code
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputs\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisAnalyticsApplicationInputs[] Inputs
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisAnalyticsApplicationOutputs[] Outputs
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationOutputs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "referenceDataSources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSources\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisAnalyticsApplicationReferenceDataSources[] ReferenceDataSources
        {
            get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSources[]>()!;
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
