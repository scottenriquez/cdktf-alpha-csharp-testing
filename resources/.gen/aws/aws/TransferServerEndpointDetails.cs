using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.TransferServerEndpointDetails")]
    public class TransferServerEndpointDetails : aws.ITransferServerEndpointDetails
    {
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VpcEndpointId
        {
            get;
            set;
        }
    }
}
