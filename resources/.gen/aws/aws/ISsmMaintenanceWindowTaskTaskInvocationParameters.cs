using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParameters
    {
        /// <summary>automation_parameters block.</summary>
        [JsiiProperty(name: "automationParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters[]? AutomationParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_parameters block.</summary>
        [JsiiProperty(name: "lambdaParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters[]? LambdaParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_command_parameters block.</summary>
        [JsiiProperty(name: "runCommandParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters[]? RunCommandParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions_parameters block.</summary>
        [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters[]? StepFunctionsParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskTaskInvocationParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>automation_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automationParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters[]? AutomationParameters
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters[]?>();
            }

            /// <summary>lambda_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters[]? LambdaParameters
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters[]?>();
            }

            /// <summary>run_command_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runCommandParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters[]? RunCommandParameters
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters[]?>();
            }

            /// <summary>step_functions_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters[]? StepFunctionsParameters
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters[]?>();
            }
        }
    }
}
