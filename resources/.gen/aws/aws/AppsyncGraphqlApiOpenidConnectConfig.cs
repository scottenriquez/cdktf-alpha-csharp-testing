using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncGraphqlApiOpenidConnectConfig")]
    public class AppsyncGraphqlApiOpenidConnectConfig : aws.IAppsyncGraphqlApiOpenidConnectConfig
    {
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Issuer
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AuthTtl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClientId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? IatTtl
        {
            get;
            set;
        }
    }
}
