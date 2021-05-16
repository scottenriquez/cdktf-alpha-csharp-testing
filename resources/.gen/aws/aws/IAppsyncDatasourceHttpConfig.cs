using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceHttpConfig), fullyQualifiedName: "aws.AppsyncDatasourceHttpConfig")]
    public interface IAppsyncDatasourceHttpConfig
    {
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceHttpConfig), fullyQualifiedName: "aws.AppsyncDatasourceHttpConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncDatasourceHttpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
