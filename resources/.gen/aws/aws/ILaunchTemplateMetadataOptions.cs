using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateMetadataOptions), fullyQualifiedName: "aws.LaunchTemplateMetadataOptions")]
    public interface ILaunchTemplateMetadataOptions
    {
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPutResponseHopLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpTokens
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateMetadataOptions), fullyQualifiedName: "aws.LaunchTemplateMetadataOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateMetadataOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPutResponseHopLimit
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpTokens
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
