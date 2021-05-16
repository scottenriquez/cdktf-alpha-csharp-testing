using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleSnsAction), fullyQualifiedName: "aws.SesReceiptRuleSnsAction")]
    public interface ISesReceiptRuleSnsAction
    {
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
        {
            get;
        }

        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleSnsAction), fullyQualifiedName: "aws.SesReceiptRuleSnsAction")]
        internal sealed class _Proxy : DeputyBase, aws.ISesReceiptRuleSnsAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
            public double Position
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
