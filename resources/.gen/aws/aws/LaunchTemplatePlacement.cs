using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplatePlacement")]
    public class LaunchTemplatePlacement : aws.ILaunchTemplatePlacement
    {
        [JsiiOptional]
        [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Affinity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HostId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PartitionNumber
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpreadDomain
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Tenancy
        {
            get;
            set;
        }
    }
}
