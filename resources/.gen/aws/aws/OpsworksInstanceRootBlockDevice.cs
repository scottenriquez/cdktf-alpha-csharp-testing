using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.OpsworksInstanceRootBlockDevice")]
    public class OpsworksInstanceRootBlockDevice : aws.IOpsworksInstanceRootBlockDevice
    {
        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeleteOnTermination
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Iops
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? VolumeSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VolumeType
        {
            get;
            set;
        }
    }
}
