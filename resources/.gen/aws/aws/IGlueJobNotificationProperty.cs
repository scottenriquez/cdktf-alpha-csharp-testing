using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueJobNotificationProperty), fullyQualifiedName: "aws.GlueJobNotificationProperty")]
    public interface IGlueJobNotificationProperty
    {
        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NotifyDelayAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobNotificationProperty), fullyQualifiedName: "aws.GlueJobNotificationProperty")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueJobNotificationProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NotifyDelayAfter
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
