using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters : aws.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters
    {
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Input
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
    }
}
