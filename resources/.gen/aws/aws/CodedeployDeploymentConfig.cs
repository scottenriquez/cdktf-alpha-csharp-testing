using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CodedeployDeploymentConfig), fullyQualifiedName: "aws.CodedeployDeploymentConfig", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CodedeployDeploymentConfigConfig\"}}]")]
    public class CodedeployDeploymentConfig : HashiCorp.Cdktf.TerraformResource
    {
        public CodedeployDeploymentConfig(Constructs.Construct scope, string id, aws.ICodedeployDeploymentConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfig(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetComputePlatform")]
        public virtual void ResetComputePlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumHealthyHosts")]
        public virtual void ResetMinimumHealthyHosts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrafficRoutingConfig")]
        public virtual void ResetTrafficRoutingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "deploymentConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentConfigNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computePlatformInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputePlatformInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyHostsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigMinimumHealthyHosts\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentConfigMinimumHealthyHosts[]? MinimumHealthyHostsInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentConfigMinimumHealthyHosts[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficRoutingConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentConfigTrafficRoutingConfig[]? TrafficRoutingConfigInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentConfigTrafficRoutingConfig[]?>();
        }

        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputePlatform
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigMinimumHealthyHosts\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentConfigMinimumHealthyHosts[] MinimumHealthyHosts
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentConfigMinimumHealthyHosts[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentConfigTrafficRoutingConfig[] TrafficRoutingConfig
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentConfigTrafficRoutingConfig[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
