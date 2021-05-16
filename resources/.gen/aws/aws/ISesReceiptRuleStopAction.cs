using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleStopAction), fullyQualifiedName: "aws.SesReceiptRuleStopAction")]
    public interface ISesReceiptRuleStopAction
    {
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
        {
            get;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
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

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleStopAction), fullyQualifiedName: "aws.SesReceiptRuleStopAction")]
        internal sealed class _Proxy : DeputyBase, aws.ISesReceiptRuleStopAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
            public double Position
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
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
