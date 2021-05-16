using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAutoscalingGroup), fullyQualifiedName: "aws.DataAwsAutoscalingGroup", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsAutoscalingGroupConfig\"}}]")]
    public class DataAwsAutoscalingGroup : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsAutoscalingGroup(Constructs.Construct scope, string id, aws.IDataAwsAutoscalingGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAutoscalingGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAutoscalingGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultCooldown
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriod
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoadBalancers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "newInstancesProtectedFromScaleIn", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool NewInstancesProtectedFromScaleIn
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLinkedRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupArns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TerminationPolicies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcZoneIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
