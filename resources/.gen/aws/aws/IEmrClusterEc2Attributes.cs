using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterEc2Attributes), fullyQualifiedName: "aws.EmrClusterEc2Attributes")]
    public interface IEmrClusterEc2Attributes
    {
        [JsiiProperty(name: "instanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceProfile
        {
            get;
        }

        [JsiiProperty(name: "additionalMasterSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdditionalMasterSecurityGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "additionalSlaveSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdditionalSlaveSecurityGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emrManagedMasterSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmrManagedMasterSecurityGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "emrManagedSlaveSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmrManagedSlaveSecurityGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serviceAccessSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessSecurityGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterEc2Attributes), fullyQualifiedName: "aws.EmrClusterEc2Attributes")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterEc2Attributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "instanceProfile", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceProfile
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "additionalMasterSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdditionalMasterSecurityGroups
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "additionalSlaveSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdditionalSlaveSecurityGroups
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emrManagedMasterSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmrManagedMasterSecurityGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "emrManagedSlaveSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmrManagedSlaveSecurityGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessSecurityGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
