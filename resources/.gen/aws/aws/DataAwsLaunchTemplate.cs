using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLaunchTemplate), fullyQualifiedName: "aws.DataAwsLaunchTemplate", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateConfig\"}}]")]
    public class DataAwsLaunchTemplate : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsLaunchTemplate(Constructs.Construct scope, string id, aws.IDataAwsLaunchTemplateConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "blockDeviceMappings", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateBlockDeviceMappings\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateBlockDeviceMappings BlockDeviceMappings(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateBlockDeviceMappings>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "creditSpecification", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateCreditSpecification\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateCreditSpecification CreditSpecification(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateCreditSpecification>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "elasticGpuSpecifications", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateElasticGpuSpecifications\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateElasticGpuSpecifications ElasticGpuSpecifications(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateElasticGpuSpecifications>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "hibernationOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateHibernationOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateHibernationOptions HibernationOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateHibernationOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "iamInstanceProfile", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateIamInstanceProfile\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateIamInstanceProfile IamInstanceProfile(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateIamInstanceProfile>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "instanceMarketOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateInstanceMarketOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateInstanceMarketOptions InstanceMarketOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateInstanceMarketOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "metadataOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateMetadataOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateMetadataOptions MetadataOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateMetadataOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "monitoring", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateMonitoring\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateMonitoring Monitoring(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateMonitoring>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "networkInterfaces", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateNetworkInterfaces\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateNetworkInterfaces NetworkInterfaces(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateNetworkInterfaces>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "placement", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplatePlacement\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplatePlacement Placement(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplatePlacement>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "tagSpecifications", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsLaunchTemplateTagSpecifications\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsLaunchTemplateTagSpecifications TagSpecifications(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsLaunchTemplateTagSpecifications>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DisableApiTermination
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimized
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

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInitiatedShutdownBehavior
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatestVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamDiskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDataAwsLaunchTemplateFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.IDataAwsLaunchTemplateFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsLaunchTemplateFilter[] Filter
        {
            get => GetInstanceProperty<aws.IDataAwsLaunchTemplateFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
