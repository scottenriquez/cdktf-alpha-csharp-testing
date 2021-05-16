using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesEventDestinationKinesisDestination), fullyQualifiedName: "aws.SesEventDestinationKinesisDestination")]
    public interface ISesEventDestinationKinesisDestination
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        string StreamArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationKinesisDestination), fullyQualifiedName: "aws.SesEventDestinationKinesisDestination")]
        internal sealed class _Proxy : DeputyBase, aws.ISesEventDestinationKinesisDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
