using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfig : aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig
    {
        /// <summary>deployment_ready_option block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption[]? DeploymentReadyOption
        {
            get;
            set;
        }

        /// <summary>green_fleet_provisioning_option block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption[]? GreenFleetProvisioningOption
        {
            get;
            set;
        }

        /// <summary>terminate_blue_instances_on_deployment_success block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess[]? TerminateBlueInstancesOnDeploymentSuccess
        {
            get;
            set;
        }
    }
}
