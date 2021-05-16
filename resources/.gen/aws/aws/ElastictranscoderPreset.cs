using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ElastictranscoderPreset), fullyQualifiedName: "aws.ElastictranscoderPreset", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ElastictranscoderPresetConfig\"}}]")]
    public class ElastictranscoderPreset : HashiCorp.Cdktf.TerraformResource
    {
        public ElastictranscoderPreset(Constructs.Construct scope, string id, aws.IElastictranscoderPresetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPreset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPreset(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAudio")]
        public virtual void ResetAudio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioCodecOptions")]
        public virtual void ResetAudioCodecOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnails")]
        public virtual void ResetThumbnails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideo")]
        public virtual void ResetVideo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoCodecOptions")]
        public virtual void ResetVideoCodecOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoWatermarks")]
        public virtual void ResetVideoWatermarks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioCodecOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudioCodecOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPresetAudioCodecOptions[]? AudioCodecOptionsInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetAudioCodecOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudio\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPresetAudio[]? AudioInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetAudio[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetThumbnails\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPresetThumbnails[]? ThumbnailsInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetThumbnails[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoCodecOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? VideoCodecOptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideo\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPresetVideo[]? VideoInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetVideo[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoWatermarksInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPresetVideoWatermarks[]? VideoWatermarksInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetVideoWatermarks[]?>();
        }

        [JsiiProperty(name: "audio", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudio\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPresetAudio[] Audio
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetAudio[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetAudioCodecOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPresetAudioCodecOptions[] AudioCodecOptions
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetAudioCodecOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Container
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thumbnails", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetThumbnails\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPresetThumbnails[] Thumbnails
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetThumbnails[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "video", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideo\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPresetVideo[] Video
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetVideo[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> VideoCodecOptions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "videoWatermarks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPresetVideoWatermarks[] VideoWatermarks
        {
            get => GetInstanceProperty<aws.IElastictranscoderPresetVideoWatermarks[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
