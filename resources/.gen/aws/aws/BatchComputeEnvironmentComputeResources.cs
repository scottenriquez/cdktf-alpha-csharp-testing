using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.BatchComputeEnvironmentComputeResources")]
    public class BatchComputeEnvironmentComputeResources : aws.IBatchComputeEnvironmentComputeResources
    {
        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceRole
        {
            get;
            set;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] InstanceType
        {
            get;
            set;
        }

        [JsiiProperty(name: "maxVcpus", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxVcpus
        {
            get;
            set;
        }

        [JsiiProperty(name: "minVcpus", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MinVcpus
        {
            get;
            set;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Subnets
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AllocationStrategy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bidPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BidPercentage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredVcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DesiredVcpus
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2KeyPair", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Ec2KeyPair
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ImageId
        {
            get;
            set;
        }

        /// <summary>launch_template block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IBatchComputeEnvironmentComputeResourcesLaunchTemplate[]? LaunchTemplate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotIamFleetRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotIamFleetRole
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
