using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierCsvClassifier), fullyQualifiedName: "aws.GlueClassifierCsvClassifier")]
    public interface IGlueClassifierCsvClassifier
    {
        [JsiiProperty(name: "allowSingleColumn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowSingleColumn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "containsHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainsHeader
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delimiter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "disableValueTrimming", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DisableValueTrimming
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Header
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "quoteSymbol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QuoteSymbol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierCsvClassifier), fullyQualifiedName: "aws.GlueClassifierCsvClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueClassifierCsvClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowSingleColumn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowSingleColumn
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "containsHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainsHeader
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delimiter
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "disableValueTrimming", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DisableValueTrimming
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Header
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "quoteSymbol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QuoteSymbol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
