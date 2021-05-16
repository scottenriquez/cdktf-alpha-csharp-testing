using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IPinpointAppLimits), fullyQualifiedName: "aws.PinpointAppLimits")]
    public interface IPinpointAppLimits
    {
        [JsiiProperty(name: "daily", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Daily
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "messagesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MessagesPerSecond
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Total
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointAppLimits), fullyQualifiedName: "aws.PinpointAppLimits")]
        internal sealed class _Proxy : DeputyBase, aws.IPinpointAppLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "daily", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Daily
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumDuration
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "messagesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessagesPerSecond
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Total
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
