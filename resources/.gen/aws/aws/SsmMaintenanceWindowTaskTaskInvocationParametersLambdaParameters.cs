using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters : aws.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters
    {
        [JsiiOptional]
        [JsiiProperty(name: "clientContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClientContext
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Payload
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Qualifier
        {
            get;
            set;
        }
    }
}
