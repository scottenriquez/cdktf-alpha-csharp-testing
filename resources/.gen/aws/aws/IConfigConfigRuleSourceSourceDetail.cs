using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleSourceSourceDetail), fullyQualifiedName: "aws.ConfigConfigRuleSourceSourceDetail")]
    public interface IConfigConfigRuleSourceSourceDetail
    {
        [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventSource
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumExecutionFrequency
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "messageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleSourceSourceDetail), fullyQualifiedName: "aws.ConfigConfigRuleSourceSourceDetail")]
        internal sealed class _Proxy : DeputyBase, aws.IConfigConfigRuleSourceSourceDetail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventSource
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumExecutionFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "messageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
