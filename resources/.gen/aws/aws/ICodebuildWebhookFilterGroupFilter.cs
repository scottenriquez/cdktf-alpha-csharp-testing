using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildWebhookFilterGroupFilter), fullyQualifiedName: "aws.CodebuildWebhookFilterGroupFilter")]
    public interface ICodebuildWebhookFilterGroupFilter
    {
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        string Pattern
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "excludeMatchedPattern", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ExcludeMatchedPattern
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildWebhookFilterGroupFilter), fullyQualifiedName: "aws.CodebuildWebhookFilterGroupFilter")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildWebhookFilterGroupFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
            public string Pattern
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "excludeMatchedPattern", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ExcludeMatchedPattern
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
