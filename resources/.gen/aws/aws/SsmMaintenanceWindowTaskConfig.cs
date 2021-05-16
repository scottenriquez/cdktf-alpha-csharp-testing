using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskConfig")]
    public class SsmMaintenanceWindowTaskConfig : aws.ISsmMaintenanceWindowTaskConfig
    {
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MaxConcurrency
        {
            get;
            set;
        }

        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MaxErrors
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRoleArn
        {
            get;
            set;
        }

        /// <summary>targets block.</summary>
        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTargets[] Targets
        {
            get;
            set;
        }

        [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TaskArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TaskType
        {
            get;
            set;
        }

        [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string WindowId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>logging_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskLoggingInfo[]? LoggingInfo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>task_invocation_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[]? TaskInvocationParameters
        {
            get;
            set;
        }

        /// <summary>task_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskParameters[]? TaskParameters
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
