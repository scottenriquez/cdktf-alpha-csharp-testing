using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.RdsClusterS3Import")]
    public class RdsClusterS3Import : aws.IRdsClusterS3Import
    {
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketName
        {
            get;
            set;
        }

        [JsiiProperty(name: "ingestionRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IngestionRole
        {
            get;
            set;
        }

        [JsiiProperty(name: "sourceEngine", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceEngine
        {
            get;
            set;
        }

        [JsiiProperty(name: "sourceEngineVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceEngineVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BucketPrefix
        {
            get;
            set;
        }
    }
}
