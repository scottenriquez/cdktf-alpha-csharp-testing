using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentConfigTrafficRoutingConfig")]
    public class CodedeployDeploymentConfigTrafficRoutingConfig : aws.ICodedeployDeploymentConfigTrafficRoutingConfig
    {
        /// <summary>time_based_canary block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary[]? TimeBasedCanary
        {
            get;
            set;
        }

        /// <summary>time_based_linear block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear[]? TimeBasedLinear
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
