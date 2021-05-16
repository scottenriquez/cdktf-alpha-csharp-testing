using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleScope), fullyQualifiedName: "aws.ConfigConfigRuleScope")]
    public interface IConfigConfigRuleScope
    {
        [JsiiProperty(name: "complianceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComplianceResourceId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "complianceResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ComplianceResourceTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagKey
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleScope), fullyQualifiedName: "aws.ConfigConfigRuleScope")]
        internal sealed class _Proxy : DeputyBase, aws.IConfigConfigRuleScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "complianceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComplianceResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "complianceResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ComplianceResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagKey
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
