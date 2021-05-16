using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElbListener")]
    public class ElbListener : aws.IElbListener
    {
        [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double InstancePort
        {
            get;
            set;
        }

        [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceProtocol
        {
            get;
            set;
        }

        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double LbPort
        {
            get;
            set;
        }

        [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LbProtocol
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SslCertificateId
        {
            get;
            set;
        }
    }
}
