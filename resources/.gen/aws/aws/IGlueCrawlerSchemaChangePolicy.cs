using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerSchemaChangePolicy), fullyQualifiedName: "aws.GlueCrawlerSchemaChangePolicy")]
    public interface IGlueCrawlerSchemaChangePolicy
    {
        [JsiiProperty(name: "deleteBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeleteBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "updateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerSchemaChangePolicy), fullyQualifiedName: "aws.GlueCrawlerSchemaChangePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueCrawlerSchemaChangePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "deleteBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeleteBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "updateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
