using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleWorkmailAction), fullyQualifiedName: "aws.SesReceiptRuleWorkmailAction")]
    public interface ISesReceiptRuleWorkmailAction
    {
        [JsiiProperty(name: "organizationArn", typeJson: "{\"primitive\":\"string\"}")]
        string OrganizationArn
        {
            get;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
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

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleWorkmailAction), fullyQualifiedName: "aws.SesReceiptRuleWorkmailAction")]
        internal sealed class _Proxy : DeputyBase, aws.ISesReceiptRuleWorkmailAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "organizationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string OrganizationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
            public double Position
            {
                get => GetInstanceProperty<double>()!;
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
