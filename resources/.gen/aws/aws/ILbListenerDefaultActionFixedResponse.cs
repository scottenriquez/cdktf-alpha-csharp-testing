using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerDefaultActionFixedResponse), fullyQualifiedName: "aws.LbListenerDefaultActionFixedResponse")]
    public interface ILbListenerDefaultActionFixedResponse
    {
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        string ContentType
        {
            get;
        }

        [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageBody
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerDefaultActionFixedResponse), fullyQualifiedName: "aws.LbListenerDefaultActionFixedResponse")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerDefaultActionFixedResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageBody
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatusCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
