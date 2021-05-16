using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetAudioCodecOptions), fullyQualifiedName: "aws.ElastictranscoderPresetAudioCodecOptions")]
    public interface IElastictranscoderPresetAudioCodecOptions
    {
        [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BitDepth
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BitOrder
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Profile
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Signed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetAudioCodecOptions), fullyQualifiedName: "aws.ElastictranscoderPresetAudioCodecOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPresetAudioCodecOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BitDepth
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BitOrder
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Profile
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Signed
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
