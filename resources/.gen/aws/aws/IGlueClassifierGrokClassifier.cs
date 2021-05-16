using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierGrokClassifier), fullyQualifiedName: "aws.GlueClassifierGrokClassifier")]
    public interface IGlueClassifierGrokClassifier
    {
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        string Classification
        {
            get;
        }

        [JsiiProperty(name: "grokPattern", typeJson: "{\"primitive\":\"string\"}")]
        string GrokPattern
        {
            get;
        }

        [JsiiProperty(name: "customPatterns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomPatterns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierGrokClassifier), fullyQualifiedName: "aws.GlueClassifierGrokClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueClassifierGrokClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
            public string Classification
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "grokPattern", typeJson: "{\"primitive\":\"string\"}")]
            public string GrokPattern
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "customPatterns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomPatterns
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
