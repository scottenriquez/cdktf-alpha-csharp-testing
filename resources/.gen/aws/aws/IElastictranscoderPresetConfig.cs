using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetConfig), fullyQualifiedName: "aws.ElastictranscoderPresetConfig")]
    public interface IElastictranscoderPresetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
        string Container
        {
            get;
        }

        /// <summary>audio block.</summary>
        [JsiiProperty(name: "audio", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudio\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPresetAudio[]? Audio
        {
            get
            {
                return null;
            }
        }

        /// <summary>audio_codec_options block.</summary>
        [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudioCodecOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPresetAudioCodecOptions[]? AudioCodecOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>thumbnails block.</summary>
        [JsiiProperty(name: "thumbnails", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetThumbnails\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPresetThumbnails[]? Thumbnails
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>video block.</summary>
        [JsiiProperty(name: "video", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPresetVideo[]? Video
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? VideoCodecOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>video_watermarks block.</summary>
        [JsiiProperty(name: "videoWatermarks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPresetVideoWatermarks[]? VideoWatermarks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetConfig), fullyQualifiedName: "aws.ElastictranscoderPresetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPresetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
            public string Container
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>audio block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audio", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudio\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPresetAudio[]? Audio
            {
                get => GetInstanceProperty<aws.IElastictranscoderPresetAudio[]?>();
            }

            /// <summary>audio_codec_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudioCodecOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPresetAudioCodecOptions[]? AudioCodecOptions
            {
                get => GetInstanceProperty<aws.IElastictranscoderPresetAudioCodecOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>thumbnails block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thumbnails", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetThumbnails\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPresetThumbnails[]? Thumbnails
            {
                get => GetInstanceProperty<aws.IElastictranscoderPresetThumbnails[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>video block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "video", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPresetVideo[]? Video
            {
                get => GetInstanceProperty<aws.IElastictranscoderPresetVideo[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? VideoCodecOptions
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>video_watermarks block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "videoWatermarks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPresetVideoWatermarks[]? VideoWatermarks
            {
                get => GetInstanceProperty<aws.IElastictranscoderPresetVideoWatermarks[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
