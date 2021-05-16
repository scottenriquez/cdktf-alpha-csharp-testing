using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.OpsworksApplicationSslConfiguration")]
    public class OpsworksApplicationSslConfiguration : aws.IOpsworksApplicationSslConfiguration
    {
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Certificate
        {
            get;
            set;
        }

        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PrivateKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Chain
        {
            get;
            set;
        }
    }
}
