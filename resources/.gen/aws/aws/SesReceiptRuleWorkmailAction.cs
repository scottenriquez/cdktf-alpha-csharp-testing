using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesReceiptRuleWorkmailAction")]
    public class SesReceiptRuleWorkmailAction : aws.ISesReceiptRuleWorkmailAction
    {
        [JsiiProperty(name: "organizationArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string OrganizationArn
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

        [JsiiOptional]
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TopicArn
        {
            get;
            set;
        }
    }
}
