using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetThumbnails), fullyQualifiedName: "aws.ElastictranscoderPresetThumbnails")]
    public interface IElastictranscoderPresetThumbnails
    {
        [JsiiProperty(name: "aspectRatio", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AspectRatio
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Format
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Interval
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxHeight
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxWidth
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "paddingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaddingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Resolution
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SizingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetThumbnails), fullyQualifiedName: "aws.ElastictranscoderPresetThumbnails")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPresetThumbnails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "aspectRatio", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AspectRatio
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Format
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Interval
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxHeight
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxWidth
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "paddingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaddingPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Resolution
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SizingPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
