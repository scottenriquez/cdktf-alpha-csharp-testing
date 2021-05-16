using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateBlockDeviceMappings")]
    public class LaunchTemplateBlockDeviceMappings : aws.ILaunchTemplateBlockDeviceMappings
    {
        [JsiiOptional]
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceName
        {
            get;
            set;
        }

        /// <summary>ebs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappingsEbs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateBlockDeviceMappingsEbs[]? Ebs
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NoDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VirtualName
        {
            get;
            set;
        }
    }
}
