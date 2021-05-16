using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateInstanceMarketOptions), fullyQualifiedName: "aws.LaunchTemplateInstanceMarketOptions")]
    public interface ILaunchTemplateInstanceMarketOptions
    {
        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MarketType
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_options block.</summary>
        [JsiiProperty(name: "spotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptionsSpotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateInstanceMarketOptionsSpotOptions[]? SpotOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateInstanceMarketOptions), fullyQualifiedName: "aws.LaunchTemplateInstanceMarketOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateInstanceMarketOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MarketType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>spot_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptionsSpotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateInstanceMarketOptionsSpotOptions[]? SpotOptions
            {
                get => GetInstanceProperty<aws.ILaunchTemplateInstanceMarketOptionsSpotOptions[]?>();
            }
        }
    }
}
