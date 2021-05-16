using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerCatalogTarget), fullyQualifiedName: "aws.GlueCrawlerCatalogTarget")]
    public interface IGlueCrawlerCatalogTarget
    {
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        [JsiiProperty(name: "tables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Tables
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerCatalogTarget), fullyQualifiedName: "aws.GlueCrawlerCatalogTarget")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueCrawlerCatalogTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "tables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Tables
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
