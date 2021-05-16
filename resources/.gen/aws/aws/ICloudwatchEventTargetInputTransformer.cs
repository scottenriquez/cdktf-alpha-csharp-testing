using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetInputTransformer), fullyQualifiedName: "aws.CloudwatchEventTargetInputTransformer")]
    public interface ICloudwatchEventTargetInputTransformer
    {
        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string InputTemplate
        {
            get;
        }

        [JsiiProperty(name: "inputPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? InputPaths
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetInputTransformer), fullyQualifiedName: "aws.CloudwatchEventTargetInputTransformer")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchEventTargetInputTransformer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string InputTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "inputPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? InputPaths
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
