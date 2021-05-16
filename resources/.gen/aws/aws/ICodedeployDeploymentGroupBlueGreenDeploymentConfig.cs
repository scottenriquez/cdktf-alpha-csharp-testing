using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfig), fullyQualifiedName: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig")]
    public interface ICodedeployDeploymentGroupBlueGreenDeploymentConfig
    {
        /// <summary>deployment_ready_option block.</summary>
        [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption[]? DeploymentReadyOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>green_fleet_provisioning_option block.</summary>
        [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption[]? GreenFleetProvisioningOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>terminate_blue_instances_on_deployment_success block.</summary>
        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess[]? TerminateBlueInstancesOnDeploymentSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfig), fullyQualifiedName: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>deployment_ready_option block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption[]? DeploymentReadyOption
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption[]?>();
            }

            /// <summary>green_fleet_provisioning_option block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption[]? GreenFleetProvisioningOption
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption[]?>();
            }

            /// <summary>terminate_blue_instances_on_deployment_success block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess[]? TerminateBlueInstancesOnDeploymentSuccess
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess[]?>();
            }
        }
    }
}
