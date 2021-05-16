using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElastictranscoderPipelineThumbnailConfig")]
    public class ElastictranscoderPipelineThumbnailConfig : aws.IElastictranscoderPipelineThumbnailConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StorageClass
        {
            get;
            set;
        }
    }
}
