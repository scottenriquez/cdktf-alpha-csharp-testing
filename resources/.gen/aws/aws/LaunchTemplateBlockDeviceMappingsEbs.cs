using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateBlockDeviceMappingsEbs")]
    public class LaunchTemplateBlockDeviceMappingsEbs : aws.ILaunchTemplateBlockDeviceMappingsEbs
    {
        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeleteOnTermination
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Encrypted
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
