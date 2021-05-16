using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.VpcPeeringConnectionAccepter")]
    public class VpcPeeringConnectionAccepter : aws.IVpcPeeringConnectionAccepter
    {
        [JsiiOptional]
        [JsiiProperty(name: "allowClassicLinkToRemoteVpc", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowClassicLinkToRemoteVpc
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowRemoteVpcDnsResolution
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowVpcToRemoteClassicLink", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowVpcToRemoteClassicLink
        {
            get;
            set;
        }
    }
}
