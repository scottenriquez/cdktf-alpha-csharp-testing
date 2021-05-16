using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointElasticsearchSettings), fullyQualifiedName: "aws.DmsEndpointElasticsearchSettings")]
    public interface IDmsEndpointElasticsearchSettings
    {
        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointUri
        {
            get;
        }

        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccessRoleArn
        {
            get;
        }

        [JsiiProperty(name: "errorRetryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ErrorRetryDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "fullLoadErrorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FullLoadErrorPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointElasticsearchSettings), fullyQualifiedName: "aws.DmsEndpointElasticsearchSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IDmsEndpointElasticsearchSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointUri
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccessRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "errorRetryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ErrorRetryDuration
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "fullLoadErrorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FullLoadErrorPercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
