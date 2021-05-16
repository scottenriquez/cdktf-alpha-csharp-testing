using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetAudio), fullyQualifiedName: "aws.ElastictranscoderPresetAudio")]
    public interface IElastictranscoderPresetAudio
    {
        [JsiiProperty(name: "audioPackingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AudioPackingMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BitRate
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Channels
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Codec
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SampleRate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetAudio), fullyQualifiedName: "aws.ElastictranscoderPresetAudio")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPresetAudio
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "audioPackingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AudioPackingMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BitRate
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Channels
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Codec
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SampleRate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
