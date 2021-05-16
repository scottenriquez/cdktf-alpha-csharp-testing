using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate")]
    public class CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate : aws.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate
    {
        [JsiiOptional]
        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailMessage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailSubject
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SmsMessage
        {
            get;
            set;
        }
    }
}
