using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppautoscalingScheduledActionConfig")]
    public class AppautoscalingScheduledActionConfig : aws.IAppautoscalingScheduledActionConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ResourceId
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceNamespace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EndTime
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ScalableDimension
        {
            get;
            set;
        }

        /// <summary>scalable_target_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalableTargetAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppautoscalingScheduledActionScalableTargetAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppautoscalingScheduledActionScalableTargetAction[]? ScalableTargetAction
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Schedule
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StartTime
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
