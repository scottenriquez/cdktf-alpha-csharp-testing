using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.BudgetsBudgetNotification")]
    public class BudgetsBudgetNotification : aws.IBudgetsBudgetNotification
    {
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ComparisonOperator
        {
            get;
            set;
        }

        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NotificationType
        {
            get;
            set;
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Threshold
        {
            get;
            set;
        }

        [JsiiProperty(name: "thresholdType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ThresholdType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriberEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SubscriberEmailAddresses
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriberSnsTopicArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SubscriberSnsTopicArns
        {
            get;
            set;
        }
    }
}
