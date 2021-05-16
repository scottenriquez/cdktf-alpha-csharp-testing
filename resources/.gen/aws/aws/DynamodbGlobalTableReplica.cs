using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DynamodbGlobalTableReplica")]
    public class DynamodbGlobalTableReplica : aws.IDynamodbGlobalTableReplica
    {
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RegionName
        {
            get;
            set;
        }
    }
}
