using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionCustomErrorResponse), fullyQualifiedName: "aws.CloudfrontDistributionCustomErrorResponse")]
    public interface ICloudfrontDistributionCustomErrorResponse
    {
        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
        double ErrorCode
        {
            get;
        }

        [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ErrorCachingMinTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ResponseCode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponsePagePath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionCustomErrorResponse), fullyQualifiedName: "aws.CloudfrontDistributionCustomErrorResponse")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionCustomErrorResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
            public double ErrorCode
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ErrorCachingMinTtl
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ResponseCode
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponsePagePath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
