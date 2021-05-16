using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolEmailConfiguration), fullyQualifiedName: "aws.CognitoUserPoolEmailConfiguration")]
    public interface ICognitoUserPoolEmailConfiguration
    {
        [JsiiProperty(name: "emailSendingAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailSendingAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FromEmailAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "replyToEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplyToEmailAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolEmailConfiguration), fullyQualifiedName: "aws.CognitoUserPoolEmailConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolEmailConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailSendingAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailSendingAccount
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FromEmailAddress
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "replyToEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplyToEmailAddress
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
