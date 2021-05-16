using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueClassifierCsvClassifier")]
    public class GlueClassifierCsvClassifier : aws.IGlueClassifierCsvClassifier
    {
        [JsiiOptional]
        [JsiiProperty(name: "allowSingleColumn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowSingleColumn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containsHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContainsHeader
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Delimiter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableValueTrimming", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DisableValueTrimming
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Header
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "quoteSymbol", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? QuoteSymbol
        {
            get;
            set;
        }
    }
}
