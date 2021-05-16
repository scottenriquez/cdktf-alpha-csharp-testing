using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPipelineNotifications), fullyQualifiedName: "aws.ElastictranscoderPipelineNotifications")]
    public interface IElastictranscoderPipelineNotifications
    {
        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Completed
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Error
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Progressing
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Warning
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPipelineNotifications), fullyQualifiedName: "aws.ElastictranscoderPipelineNotifications")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPipelineNotifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Completed
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Error
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Progressing
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Warning
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
