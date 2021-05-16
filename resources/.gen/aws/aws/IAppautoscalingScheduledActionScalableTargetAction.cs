using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingScheduledActionScalableTargetAction), fullyQualifiedName: "aws.AppautoscalingScheduledActionScalableTargetAction")]
    public interface IAppautoscalingScheduledActionScalableTargetAction
    {
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

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingScheduledActionScalableTargetAction), fullyQualifiedName: "aws.AppautoscalingScheduledActionScalableTargetAction")]
        internal sealed class _Proxy : DeputyBase, aws.IAppautoscalingScheduledActionScalableTargetAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
        }
    }
}
