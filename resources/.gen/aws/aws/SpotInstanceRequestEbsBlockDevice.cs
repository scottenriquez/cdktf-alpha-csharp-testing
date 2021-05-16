using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SpotInstanceRequestEbsBlockDevice")]
    public class SpotInstanceRequestEbsBlockDevice : aws.ISpotInstanceRequestEbsBlockDevice
    {
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DeviceName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeleteOnTermination
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Encrypted
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
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SnapshotId
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
