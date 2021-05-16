using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IConfigConfigurationAggregatorAccountAggregationSource), fullyQualifiedName: "aws.ConfigConfigurationAggregatorAccountAggregationSource")]
    public interface IConfigConfigurationAggregatorAccountAggregationSource
    {
        [JsiiProperty(name: "accountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AccountIds
        {
            get;
        }

        [JsiiProperty(name: "allRegions", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllRegions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Regions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigurationAggregatorAccountAggregationSource), fullyQualifiedName: "aws.ConfigConfigurationAggregatorAccountAggregationSource")]
        internal sealed class _Proxy : DeputyBase, aws.IConfigConfigurationAggregatorAccountAggregationSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "accountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AccountIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "allRegions", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllRegions
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Regions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
