using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AutoscalingScheduleConfig")]
    public class AutoscalingScheduleConfig : aws.IAutoscalingScheduleConfig
    {
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AutoscalingGroupName
        {
            get;
            set;
        }

        [JsiiProperty(name: "scheduledActionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScheduledActionName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DesiredCapacity
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
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Recurrence
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
