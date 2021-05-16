using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbSubnetMapping")]
    public class AlbSubnetMapping : aws.IAlbSubnetMapping
    {
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SubnetId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AllocationId
        {
            get;
            set;
        }
    }
}
