using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskTaskInvocationParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParameters : aws.ISsmMaintenanceWindowTaskTaskInvocationParameters
    {
        /// <summary>automation_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automationParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters[]? AutomationParameters
        {
            get;
            set;
        }

        /// <summary>lambda_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters[]? LambdaParameters
        {
            get;
            set;
        }

        /// <summary>run_command_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runCommandParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters[]? RunCommandParameters
        {
            get;
            set;
        }

        /// <summary>step_functions_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters[]? StepFunctionsParameters
        {
            get;
            set;
        }
    }
}
