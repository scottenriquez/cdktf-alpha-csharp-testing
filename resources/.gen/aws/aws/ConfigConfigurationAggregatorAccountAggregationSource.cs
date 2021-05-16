using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ConfigConfigurationAggregatorAccountAggregationSource")]
    public class ConfigConfigurationAggregatorAccountAggregationSource : aws.IConfigConfigurationAggregatorAccountAggregationSource
    {
        [JsiiProperty(name: "accountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] AccountIds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allRegions", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllRegions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Regions
        {
            get;
            set;
        }
    }
}
