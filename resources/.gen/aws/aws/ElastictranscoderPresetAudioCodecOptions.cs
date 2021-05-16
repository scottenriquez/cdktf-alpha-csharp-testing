using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElastictranscoderPresetAudioCodecOptions")]
    public class ElastictranscoderPresetAudioCodecOptions : aws.IElastictranscoderPresetAudioCodecOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BitDepth
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BitOrder
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Profile
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Signed
        {
            get;
            set;
        }
    }
}
