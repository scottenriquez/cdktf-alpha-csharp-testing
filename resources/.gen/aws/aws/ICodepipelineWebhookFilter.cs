using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodepipelineWebhookFilter), fullyQualifiedName: "aws.CodepipelineWebhookFilter")]
    public interface ICodepipelineWebhookFilter
    {
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        string JsonPath
        {
            get;
        }

        [JsiiProperty(name: "matchEquals", typeJson: "{\"primitive\":\"string\"}")]
        string MatchEquals
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineWebhookFilter), fullyQualifiedName: "aws.CodepipelineWebhookFilter")]
        internal sealed class _Proxy : DeputyBase, aws.ICodepipelineWebhookFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonPath
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "matchEquals", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchEquals
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
