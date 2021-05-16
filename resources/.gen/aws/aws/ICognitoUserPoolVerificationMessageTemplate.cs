using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolVerificationMessageTemplate), fullyQualifiedName: "aws.CognitoUserPoolVerificationMessageTemplate")]
    public interface ICognitoUserPoolVerificationMessageTemplate
    {
        [JsiiProperty(name: "defaultEmailOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultEmailOption
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emailMessageByLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailMessageByLink
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailSubject
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emailSubjectByLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailSubjectByLink
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolVerificationMessageTemplate), fullyQualifiedName: "aws.CognitoUserPoolVerificationMessageTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolVerificationMessageTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultEmailOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultEmailOption
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailMessage
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailMessageByLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailMessageByLink
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailSubject
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailSubjectByLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailSubjectByLink
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsMessage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
