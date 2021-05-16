using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationCloudwatchLoggingOptions), fullyQualifiedName: "aws.KinesisAnalyticsApplicationCloudwatchLoggingOptions")]
    public interface IKinesisAnalyticsApplicationCloudwatchLoggingOptions
    {
        [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogStreamArn
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationCloudwatchLoggingOptions), fullyQualifiedName: "aws.KinesisAnalyticsApplicationCloudwatchLoggingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationCloudwatchLoggingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "logStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
