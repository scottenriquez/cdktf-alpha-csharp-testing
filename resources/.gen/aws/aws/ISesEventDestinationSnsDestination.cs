using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesEventDestinationSnsDestination), fullyQualifiedName: "aws.SesEventDestinationSnsDestination")]
    public interface ISesEventDestinationSnsDestination
    {
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationSnsDestination), fullyQualifiedName: "aws.SesEventDestinationSnsDestination")]
        internal sealed class _Proxy : DeputyBase, aws.ISesEventDestinationSnsDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
