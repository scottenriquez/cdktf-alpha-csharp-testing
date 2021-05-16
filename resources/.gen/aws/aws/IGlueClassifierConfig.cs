using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.GlueClassifierConfig")]
    public interface IGlueClassifierConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>csv_classifier block.</summary>
        [JsiiProperty(name: "csvClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierCsvClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueClassifierCsvClassifier[]? CsvClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>grok_classifier block.</summary>
        [JsiiProperty(name: "grokClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierGrokClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueClassifierGrokClassifier[]? GrokClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>json_classifier block.</summary>
        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierJsonClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueClassifierJsonClassifier[]? JsonClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>xml_classifier block.</summary>
        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierXmlClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueClassifierXmlClassifier[]? XmlClassifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.GlueClassifierConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueClassifierConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>csv_classifier block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "csvClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierCsvClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueClassifierCsvClassifier[]? CsvClassifier
            {
                get => GetInstanceProperty<aws.IGlueClassifierCsvClassifier[]?>();
            }

            /// <summary>grok_classifier block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grokClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierGrokClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueClassifierGrokClassifier[]? GrokClassifier
            {
                get => GetInstanceProperty<aws.IGlueClassifierGrokClassifier[]?>();
            }

            /// <summary>json_classifier block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jsonClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierJsonClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueClassifierJsonClassifier[]? JsonClassifier
            {
                get => GetInstanceProperty<aws.IGlueClassifierJsonClassifier[]?>();
            }

            /// <summary>xml_classifier block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xmlClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierXmlClassifier\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueClassifierXmlClassifier[]? XmlClassifier
            {
                get => GetInstanceProperty<aws.IGlueClassifierXmlClassifier[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
