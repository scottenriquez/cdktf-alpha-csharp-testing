using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorAcceleratorAttributes), fullyQualifiedName: "aws.GlobalacceleratorAcceleratorAttributes")]
    public interface IGlobalacceleratorAcceleratorAttributes
    {
        [JsiiProperty(name: "flowLogsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? FlowLogsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "flowLogsS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlowLogsS3Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "flowLogsS3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlowLogsS3Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorAcceleratorAttributes), fullyQualifiedName: "aws.GlobalacceleratorAcceleratorAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.IGlobalacceleratorAcceleratorAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "flowLogsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? FlowLogsEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "flowLogsS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlowLogsS3Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "flowLogsS3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlowLogsS3Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
