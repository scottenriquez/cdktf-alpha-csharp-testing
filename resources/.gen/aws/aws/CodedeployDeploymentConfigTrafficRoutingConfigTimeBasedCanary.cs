using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary")]
    public class CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary : aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary
    {
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Interval
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Percentage
        {
            get;
            set;
        }
    }
}
