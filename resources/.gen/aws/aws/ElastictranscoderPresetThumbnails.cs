using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElastictranscoderPresetThumbnails")]
    public class ElastictranscoderPresetThumbnails : aws.IElastictranscoderPresetThumbnails
    {
        [JsiiOptional]
        [JsiiProperty(name: "aspectRatio", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AspectRatio
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Format
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Interval
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxHeight
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxWidth
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "paddingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PaddingPolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Resolution
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SizingPolicy
        {
            get;
            set;
        }
    }
}
