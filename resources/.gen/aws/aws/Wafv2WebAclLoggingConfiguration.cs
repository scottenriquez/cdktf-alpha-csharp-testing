using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAclLoggingConfiguration), fullyQualifiedName: "aws.Wafv2WebAclLoggingConfiguration", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationConfig\"}}]")]
    public class Wafv2WebAclLoggingConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        public Wafv2WebAclLoggingConfiguration(Constructs.Construct scope, string id, aws.IWafv2WebAclLoggingConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclLoggingConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclLoggingConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRedactedFields")]
        public virtual void ResetRedactedFields()
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

        [JsiiProperty(name: "logDestinationConfigsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogDestinationConfigsInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "resourceArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "redactedFieldsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafv2WebAclLoggingConfigurationRedactedFields[]? RedactedFieldsInput
        {
            get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFields[]?>();
        }

        [JsiiProperty(name: "logDestinationConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogDestinationConfigs
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redactedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclLoggingConfigurationRedactedFields\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafv2WebAclLoggingConfigurationRedactedFields[] RedactedFields
        {
            get => GetInstanceProperty<aws.IWafv2WebAclLoggingConfigurationRedactedFields[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
