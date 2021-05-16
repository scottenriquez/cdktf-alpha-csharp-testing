using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerJdbcTarget), fullyQualifiedName: "aws.GlueCrawlerJdbcTarget")]
    public interface IGlueCrawlerJdbcTarget
    {
        [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionName
        {
            get;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Exclusions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerJdbcTarget), fullyQualifiedName: "aws.GlueCrawlerJdbcTarget")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueCrawlerJdbcTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Exclusions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
