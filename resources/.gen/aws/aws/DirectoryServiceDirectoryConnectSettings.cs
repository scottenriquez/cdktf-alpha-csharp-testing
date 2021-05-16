using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DirectoryServiceDirectoryConnectSettings")]
    public class DirectoryServiceDirectoryConnectSettings : aws.IDirectoryServiceDirectoryConnectSettings
    {
        [JsiiProperty(name: "customerDnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CustomerDnsIps
        {
            get;
            set;
        }

        [JsiiProperty(name: "customerUsername", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CustomerUsername
        {
            get;
            set;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SubnetIds
        {
            get;
            set;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VpcId
        {
            get;
            set;
        }
    }
}
