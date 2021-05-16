using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleBounceAction), fullyQualifiedName: "aws.SesReceiptRuleBounceAction")]
    public interface ISesReceiptRuleBounceAction
    {
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        string Message
        {
            get;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
        {
            get;
        }

        [JsiiProperty(name: "sender", typeJson: "{\"primitive\":\"string\"}")]
        string Sender
        {
            get;
        }

        [JsiiProperty(name: "smtpReplyCode", typeJson: "{\"primitive\":\"string\"}")]
        string SmtpReplyCode
        {
            get;
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

        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleBounceAction), fullyQualifiedName: "aws.SesReceiptRuleBounceAction")]
        internal sealed class _Proxy : DeputyBase, aws.ISesReceiptRuleBounceAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
            public string Message
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
            public double Position
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "sender", typeJson: "{\"primitive\":\"string\"}")]
            public string Sender
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "smtpReplyCode", typeJson: "{\"primitive\":\"string\"}")]
            public string SmtpReplyCode
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatusCode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TopicArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
