using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElastictranscoderPipelineNotifications")]
    public class ElastictranscoderPipelineNotifications : aws.IElastictranscoderPipelineNotifications
    {
        [JsiiOptional]
        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Completed
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Error
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Progressing
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Warning
        {
            get;
            set;
        }
    }
}
