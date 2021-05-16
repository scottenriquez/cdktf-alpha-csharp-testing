using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.RedshiftClusterSnapshotCopy")]
    public class RedshiftClusterSnapshotCopy : aws.IRedshiftClusterSnapshotCopy
    {
        [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DestinationRegion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GrantName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RetentionPeriod
        {
            get;
            set;
        }
    }
}
