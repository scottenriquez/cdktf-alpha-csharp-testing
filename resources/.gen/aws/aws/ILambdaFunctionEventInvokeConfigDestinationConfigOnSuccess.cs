using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess), fullyQualifiedName: "aws.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess")]
    public interface ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess
    {
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess), fullyQualifiedName: "aws.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
