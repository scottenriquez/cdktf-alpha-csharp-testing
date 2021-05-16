using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElastictranscoderPresetVideo")]
    public class ElastictranscoderPresetVideo : aws.IElastictranscoderPresetVideo
    {
        [JsiiOptional]
        [JsiiProperty(name: "aspectRatio", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AspectRatio
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BitRate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Codec
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayAspectRatio", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DisplayAspectRatio
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedGop", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FixedGop
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "frameRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FrameRate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyframesMaxDist", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KeyframesMaxDist
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxFrameRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxFrameRate
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
