using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters : aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters
    {
        [JsiiOptional]
        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DocumentVersion
        {
            get;
            set;
        }

        /// <summary>parameter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[]? Parameter
        {
            get;
            set;
        }
    }
}
