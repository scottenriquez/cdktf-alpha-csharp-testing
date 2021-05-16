using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CognitoUserPoolEmailConfiguration")]
    public class CognitoUserPoolEmailConfiguration : aws.ICognitoUserPoolEmailConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "emailSendingAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailSendingAccount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FromEmailAddress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replyToEmailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplyToEmailAddress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceArn
        {
            get;
            set;
        }
    }
}
