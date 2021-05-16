using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetBatchTarget), fullyQualifiedName: "aws.CloudwatchEventTargetBatchTarget")]
    public interface ICloudwatchEventTargetBatchTarget
    {
        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
        string JobDefinition
        {
            get;
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        string JobName
        {
            get;
        }

        [JsiiProperty(name: "arraySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ArraySize
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "jobAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? JobAttempts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetBatchTarget), fullyQualifiedName: "aws.CloudwatchEventTargetBatchTarget")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchEventTargetBatchTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
            public string JobDefinition
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
            public string JobName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "arraySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ArraySize
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "jobAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? JobAttempts
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
