using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRdsClusterScalingConfiguration), fullyQualifiedName: "aws.RdsClusterScalingConfiguration")]
    public interface IRdsClusterScalingConfiguration
    {
        [JsiiProperty(name: "autoPause", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutoPause
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SecondsUntilAutoPause
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdsClusterScalingConfiguration), fullyQualifiedName: "aws.RdsClusterScalingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IRdsClusterScalingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoPause", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AutoPause
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SecondsUntilAutoPause
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
