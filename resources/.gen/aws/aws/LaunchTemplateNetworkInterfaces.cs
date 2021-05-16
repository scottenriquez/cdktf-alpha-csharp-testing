using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateNetworkInterfaces")]
    public class LaunchTemplateNetworkInterfaces : aws.ILaunchTemplateNetworkInterfaces
    {
        [JsiiOptional]
        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AssociatePublicIpAddress
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
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DeviceIndex
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv4AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Ipv4AddressCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv4Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Ipv4Addresses
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Ipv6AddressCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Ipv6Addresses
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NetworkInterfaceId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
