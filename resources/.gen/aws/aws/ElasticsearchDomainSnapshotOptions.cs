using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticsearchDomainSnapshotOptions")]
    public class ElasticsearchDomainSnapshotOptions : aws.IElasticsearchDomainSnapshotOptions
    {
        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double AutomatedSnapshotStartHour
        {
            get;
            set;
        }
    }
}
