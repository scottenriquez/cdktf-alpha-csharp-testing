using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionTracingConfig), fullyQualifiedName: "aws.LambdaFunctionTracingConfig")]
    public interface ILambdaFunctionTracingConfig
    {
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionTracingConfig), fullyQualifiedName: "aws.LambdaFunctionTracingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaFunctionTracingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
