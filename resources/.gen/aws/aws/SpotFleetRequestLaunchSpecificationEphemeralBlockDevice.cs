using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice")]
    public class SpotFleetRequestLaunchSpecificationEphemeralBlockDevice : aws.ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice
    {
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DeviceName
        {
            get;
            set;
        }

        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VirtualName
        {
            get;
            set;
        }
    }
}
