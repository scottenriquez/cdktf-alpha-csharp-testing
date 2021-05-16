using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.NetworkInterfaceAttachment")]
    public class NetworkInterfaceAttachment : aws.INetworkInterfaceAttachment
    {
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double DeviceIndex
        {
            get;
            set;
        }

        [JsiiProperty(name: "instance", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Instance
        {
            get;
            set;
        }
    }
}
