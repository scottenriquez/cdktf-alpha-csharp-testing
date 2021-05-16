using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DatasyncLocationSmbMountOptions")]
    public class DatasyncLocationSmbMountOptions : aws.IDatasyncLocationSmbMountOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
