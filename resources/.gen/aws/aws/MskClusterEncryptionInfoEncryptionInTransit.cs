using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MskClusterEncryptionInfoEncryptionInTransit")]
    public class MskClusterEncryptionInfoEncryptionInTransit : aws.IMskClusterEncryptionInfoEncryptionInTransit
    {
        [JsiiOptional]
        [JsiiProperty(name: "clientBroker", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClientBroker
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inCluster", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? InCluster
        {
            get;
            set;
        }
    }
}
