using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.GlueClassifier), fullyQualifiedName: "aws.GlueClassifier", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.GlueClassifierConfig\"}}]")]
    public class GlueClassifier : HashiCorp.Cdktf.TerraformResource
    {
        public GlueClassifier(Constructs.Construct scope, string id, aws.IGlueClassifierConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifier(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifier(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCsvClassifier")]
        public virtual void ResetCsvClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrokClassifier")]
        public virtual void ResetGrokClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJsonClassifier")]
        public virtual void ResetJsonClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXmlClassifier")]
        public virtual void ResetXmlClassifier()
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

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvClassifierInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierCsvClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueClassifierCsvClassifier[]? CsvClassifierInput
        {
            get => GetInstanceProperty<aws.IGlueClassifierCsvClassifier[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grokClassifierInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierGrokClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueClassifierGrokClassifier[]? GrokClassifierInput
        {
            get => GetInstanceProperty<aws.IGlueClassifierGrokClassifier[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsonClassifierInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierJsonClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueClassifierJsonClassifier[]? JsonClassifierInput
        {
            get => GetInstanceProperty<aws.IGlueClassifierJsonClassifier[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xmlClassifierInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierXmlClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueClassifierXmlClassifier[]? XmlClassifierInput
        {
            get => GetInstanceProperty<aws.IGlueClassifierXmlClassifier[]?>();
        }

        [JsiiProperty(name: "csvClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierCsvClassifier\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueClassifierCsvClassifier[] CsvClassifier
        {
            get => GetInstanceProperty<aws.IGlueClassifierCsvClassifier[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grokClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierGrokClassifier\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueClassifierGrokClassifier[] GrokClassifier
        {
            get => GetInstanceProperty<aws.IGlueClassifierGrokClassifier[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierJsonClassifier\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueClassifierJsonClassifier[] JsonClassifier
        {
            get => GetInstanceProperty<aws.IGlueClassifierJsonClassifier[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierXmlClassifier\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueClassifierXmlClassifier[] XmlClassifier
        {
            get => GetInstanceProperty<aws.IGlueClassifierXmlClassifier[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
