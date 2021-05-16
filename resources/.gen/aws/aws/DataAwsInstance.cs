using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsInstance), fullyQualifiedName: "aws.DataAwsInstance", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DataAwsInstanceConfig\"}}]")]
    public class DataAwsInstance : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsInstance(Constructs.Construct scope, string id, aws.IDataAwsInstanceConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "creditSpecification", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsInstanceCreditSpecification\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsInstanceCreditSpecification CreditSpecification(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsInstanceCreditSpecification>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "ebsBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsInstanceEbsBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsInstanceEbsBlockDevice EbsBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsInstanceEbsBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "ephemeralBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsInstanceEphemeralBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsInstanceEphemeralBlockDevice EphemeralBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsInstanceEphemeralBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "metadataOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsInstanceMetadataOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsInstanceMetadataOptions MetadataOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsInstanceMetadataOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetFetchPasswordData")]
        public virtual void ResetFetchPasswordData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFetchUserData")]
        public virtual void ResetFetchUserData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceId")]
        public virtual void ResetInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceTags")]
        public virtual void ResetInstanceTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "rootBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsInstanceRootBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsInstanceRootBlockDevice RootBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsInstanceRootBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ami
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DisableApiTermination
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EbsOptimized
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "instanceState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceState
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

        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Monitoring
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outpostArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutpostArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool SourceDestCheck
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tenancy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserDataBase64
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fetchPasswordDataInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? FetchPasswordDataInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fetchUserDataInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? FetchUserDataInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsInstanceFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDataAwsInstanceFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.IDataAwsInstanceFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? InstanceTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool FetchPasswordData
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fetchUserData", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool FetchUserData
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsInstanceFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsInstanceFilter[] Filter
        {
            get => GetInstanceProperty<aws.IDataAwsInstanceFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> InstanceTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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
