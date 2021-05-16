using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure), fullyQualifiedName: "aws.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure")]
    public interface ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure
    {
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure), fullyQualifiedName: "aws.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure
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
