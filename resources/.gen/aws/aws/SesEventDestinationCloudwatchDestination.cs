using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesEventDestinationCloudwatchDestination")]
    public class SesEventDestinationCloudwatchDestination : aws.ISesEventDestinationCloudwatchDestination
    {
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DefaultValue
        {
            get;
            set;
        }

        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DimensionName
        {
            get;
            set;
        }

        [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ValueSource
        {
            get;
            set;
        }
    }
}
