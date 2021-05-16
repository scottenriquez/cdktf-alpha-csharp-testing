using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.InstanceEphemeralBlockDevice")]
    public class InstanceEphemeralBlockDevice : aws.IInstanceEphemeralBlockDevice
    {
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DeviceName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? NoDevice
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
