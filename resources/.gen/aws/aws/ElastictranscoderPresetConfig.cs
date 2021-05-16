using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElastictranscoderPresetConfig")]
    public class ElastictranscoderPresetConfig : aws.IElastictranscoderPresetConfig
    {
        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Container
        {
            get;
            set;
        }

        /// <summary>audio block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audio", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudio\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPresetAudio[]? Audio
        {
            get;
            set;
        }

        /// <summary>audio_codec_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudioCodecOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPresetAudioCodecOptions[]? AudioCodecOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>thumbnails block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thumbnails", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetThumbnails\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPresetThumbnails[]? Thumbnails
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>video block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "video", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPresetVideo[]? Video
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? VideoCodecOptions
        {
            get;
            set;
        }

        /// <summary>video_watermarks block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "videoWatermarks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPresetVideoWatermarks[]? VideoWatermarks
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
