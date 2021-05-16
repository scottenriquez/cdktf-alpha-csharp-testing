using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceLambdaConfig), fullyQualifiedName: "aws.AppsyncDatasourceLambdaConfig")]
    public interface IAppsyncDatasourceLambdaConfig
    {
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceLambdaConfig), fullyQualifiedName: "aws.AppsyncDatasourceLambdaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncDatasourceLambdaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
