using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOrigin), fullyQualifiedName: "aws.CloudfrontDistributionOrigin")]
    public interface ICloudfrontDistributionOrigin
    {
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        /// <summary>custom_header block.</summary>
        [JsiiProperty(name: "customHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionOriginCustomHeader[]? CustomHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_origin_config block.</summary>
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginCustomOriginConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionOriginCustomOriginConfig[]? CustomOriginConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_origin_config block.</summary>
        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginS3OriginConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionOriginS3OriginConfig[]? S3OriginConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOrigin), fullyQualifiedName: "aws.CloudfrontDistributionOrigin")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionOrigin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_header block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionOriginCustomHeader[]? CustomHeader
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOriginCustomHeader[]?>();
            }

            /// <summary>custom_origin_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customOriginConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginCustomOriginConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionOriginCustomOriginConfig[]? CustomOriginConfig
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOriginCustomOriginConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>s3_origin_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginS3OriginConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionOriginS3OriginConfig[]? S3OriginConfig
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOriginS3OriginConfig[]?>();
            }
        }
    }
}
