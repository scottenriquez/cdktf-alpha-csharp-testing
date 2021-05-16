using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetVideoWatermarks), fullyQualifiedName: "aws.ElastictranscoderPresetVideoWatermarks")]
    public interface IElastictranscoderPresetVideoWatermarks
    {
        [JsiiProperty(name: "horizontalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HorizontalAlign
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "horizontalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HorizontalOffset
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
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

        [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Opacity
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

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "verticalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerticalAlign
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "verticalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerticalOffset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetVideoWatermarks), fullyQualifiedName: "aws.ElastictranscoderPresetVideoWatermarks")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPresetVideoWatermarks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "horizontalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HorizontalAlign
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "horizontalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HorizontalOffset
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
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
            [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Opacity
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SizingPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "verticalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerticalAlign
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "verticalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerticalOffset
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
