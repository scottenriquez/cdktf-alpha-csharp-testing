using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueClassifierConfig")]
    public class GlueClassifierConfig : aws.IGlueClassifierConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>csv_classifier block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "csvClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierCsvClassifier\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueClassifierCsvClassifier[]? CsvClassifier
        {
            get;
            set;
        }

        /// <summary>grok_classifier block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grokClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierGrokClassifier\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueClassifierGrokClassifier[]? GrokClassifier
        {
            get;
            set;
        }

        /// <summary>json_classifier block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierJsonClassifier\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueClassifierJsonClassifier[]? JsonClassifier
        {
            get;
            set;
        }

        /// <summary>xml_classifier block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueClassifierXmlClassifier\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueClassifierXmlClassifier[]? XmlClassifier
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
