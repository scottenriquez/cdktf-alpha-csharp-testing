using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule), fullyQualifiedName: "aws.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule")]
    public interface IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule
    {
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        double Interval
        {
            get;
        }

        [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntervalUnit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "times", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Times
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule), fullyQualifiedName: "aws.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule")]
        internal sealed class _Proxy : DeputyBase, aws.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
            public double Interval
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntervalUnit
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "times", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Times
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
