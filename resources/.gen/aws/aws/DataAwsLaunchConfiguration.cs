using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLaunchConfiguration), fullyQualifiedName: "aws.DataAwsLaunchConfiguration", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsLaunchConfigurationConfig\"}}]")]
    public class DataAwsLaunchConfiguration : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsLaunchConfiguration(Constructs.Construct scope, string id, aws.IDataAwsLaunchConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "ebsBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchConfigurationEbsBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchConfigurationEbsBlockDevice EbsBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchConfigurationEbsBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "ephemeralBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchConfigurationEphemeralBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchConfigurationEphemeralBlockDevice EphemeralBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchConfigurationEphemeralBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "rootBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchConfigurationRootBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchConfigurationRootBlockDevice RootBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchConfigurationRootBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
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

        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AssociatePublicIpAddress
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EbsOptimized
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "enableMonitoring", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableMonitoring
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamInstanceProfile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementTenancy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotPrice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcClassicLinkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcClassicLinkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcClassicLinkSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcClassicLinkSecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
