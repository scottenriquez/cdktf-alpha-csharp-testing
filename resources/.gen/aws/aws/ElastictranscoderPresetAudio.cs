using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElastictranscoderPresetAudio")]
    public class ElastictranscoderPresetAudio : aws.IElastictranscoderPresetAudio
    {
        [JsiiOptional]
        [JsiiProperty(name: "audioPackingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AudioPackingMode
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
        [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Channels
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
        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SampleRate
        {
            get;
            set;
        }
    }
}
