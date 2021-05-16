using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesReceiptRuleBounceAction")]
    public class SesReceiptRuleBounceAction : aws.ISesReceiptRuleBounceAction
    {
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Message
        {
            get;
            set;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Position
        {
            get;
            set;
        }

        [JsiiProperty(name: "sender", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Sender
        {
            get;
            set;
        }

        [JsiiProperty(name: "smtpReplyCode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SmtpReplyCode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StatusCode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TopicArn
        {
            get;
            set;
        }
    }
}
