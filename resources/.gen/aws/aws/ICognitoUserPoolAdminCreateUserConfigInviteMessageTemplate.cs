using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate), fullyQualifiedName: "aws.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate")]
    public interface ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate
    {
        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailMessage
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

        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate), fullyQualifiedName: "aws.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailMessage
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
            [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsMessage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
