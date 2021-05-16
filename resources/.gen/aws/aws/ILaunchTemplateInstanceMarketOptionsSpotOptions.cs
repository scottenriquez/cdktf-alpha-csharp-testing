using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateInstanceMarketOptionsSpotOptions), fullyQualifiedName: "aws.LaunchTemplateInstanceMarketOptionsSpotOptions")]
    public interface ILaunchTemplateInstanceMarketOptionsSpotOptions
    {
        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockDurationMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInterruptionBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxPrice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotInstanceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidUntil
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateInstanceMarketOptionsSpotOptions), fullyQualifiedName: "aws.LaunchTemplateInstanceMarketOptionsSpotOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateInstanceMarketOptionsSpotOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockDurationMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInterruptionBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxPrice
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotInstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidUntil
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
