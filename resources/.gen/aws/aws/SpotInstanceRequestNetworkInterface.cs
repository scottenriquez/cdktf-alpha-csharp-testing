using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SpotInstanceRequestNetworkInterface")]
    public class SpotInstanceRequestNetworkInterface : aws.ISpotInstanceRequestNetworkInterface
    {
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double DeviceIndex
        {
            get;
            set;
        }

        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NetworkInterfaceId
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
    }
}
