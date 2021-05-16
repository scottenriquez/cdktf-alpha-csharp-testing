using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginCustomOriginConfig), fullyQualifiedName: "aws.CloudfrontDistributionOriginCustomOriginConfig")]
    public interface ICloudfrontDistributionOriginCustomOriginConfig
    {
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        double HttpPort
        {
            get;
        }

        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
        double HttpsPort
        {
            get;
        }

        [JsiiProperty(name: "originProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string OriginProtocolPolicy
        {
            get;
        }

        [JsiiProperty(name: "originSslProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] OriginSslProtocols
        {
            get;
        }

        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginKeepaliveTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginReadTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginCustomOriginConfig), fullyQualifiedName: "aws.CloudfrontDistributionOriginCustomOriginConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionOriginCustomOriginConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
            public double HttpPort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
            public double HttpsPort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "originProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginProtocolPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "originSslProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] OriginSslProtocols
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginKeepaliveTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginReadTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
