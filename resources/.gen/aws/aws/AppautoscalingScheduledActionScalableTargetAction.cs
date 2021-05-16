using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppautoscalingScheduledActionScalableTargetAction")]
    public class AppautoscalingScheduledActionScalableTargetAction : aws.IAppautoscalingScheduledActionScalableTargetAction
    {
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinCapacity
        {
            get;
            set;
        }
    }
}
