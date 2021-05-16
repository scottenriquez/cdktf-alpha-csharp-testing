using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetNotification), fullyQualifiedName: "aws.BudgetsBudgetNotification")]
    public interface IBudgetsBudgetNotification
    {
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
        string NotificationType
        {
            get;
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        double Threshold
        {
            get;
        }

        [JsiiProperty(name: "thresholdType", typeJson: "{\"primitive\":\"string\"}")]
        string ThresholdType
        {
            get;
        }

        [JsiiProperty(name: "subscriberEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubscriberEmailAddresses
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "subscriberSnsTopicArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubscriberSnsTopicArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetNotification), fullyQualifiedName: "aws.BudgetsBudgetNotification")]
        internal sealed class _Proxy : DeputyBase, aws.IBudgetsBudgetNotification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
            public string NotificationType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
            public double Threshold
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "thresholdType", typeJson: "{\"primitive\":\"string\"}")]
            public string ThresholdType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "subscriberEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubscriberEmailAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "subscriberSnsTopicArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubscriberSnsTopicArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
