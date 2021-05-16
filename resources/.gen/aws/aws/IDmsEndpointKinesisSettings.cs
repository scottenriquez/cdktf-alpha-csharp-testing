using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointKinesisSettings), fullyQualifiedName: "aws.DmsEndpointKinesisSettings")]
    public interface IDmsEndpointKinesisSettings
    {
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointKinesisSettings), fullyQualifiedName: "aws.DmsEndpointKinesisSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IDmsEndpointKinesisSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageFormat
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
