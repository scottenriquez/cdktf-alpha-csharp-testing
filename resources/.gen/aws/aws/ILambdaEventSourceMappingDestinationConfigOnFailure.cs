using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingDestinationConfigOnFailure), fullyQualifiedName: "aws.LambdaEventSourceMappingDestinationConfigOnFailure")]
    public interface ILambdaEventSourceMappingDestinationConfigOnFailure
    {
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingDestinationConfigOnFailure), fullyQualifiedName: "aws.LambdaEventSourceMappingDestinationConfigOnFailure")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaEventSourceMappingDestinationConfigOnFailure
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
