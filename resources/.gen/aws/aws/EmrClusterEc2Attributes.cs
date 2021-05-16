using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EmrClusterEc2Attributes")]
    public class EmrClusterEc2Attributes : aws.IEmrClusterEc2Attributes
    {
        [JsiiProperty(name: "instanceProfile", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceProfile
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalMasterSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdditionalMasterSecurityGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalSlaveSecurityGroups", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdditionalSlaveSecurityGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emrManagedMasterSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmrManagedMasterSecurityGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emrManagedSlaveSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmrManagedSlaveSecurityGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KeyName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceAccessSecurityGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
