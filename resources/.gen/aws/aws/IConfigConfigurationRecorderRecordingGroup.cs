using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IConfigConfigurationRecorderRecordingGroup), fullyQualifiedName: "aws.ConfigConfigurationRecorderRecordingGroup")]
    public interface IConfigConfigurationRecorderRecordingGroup
    {
        [JsiiProperty(name: "allSupported", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllSupported
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeGlobalResourceTypes", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeGlobalResourceTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigurationRecorderRecordingGroup), fullyQualifiedName: "aws.ConfigConfigurationRecorderRecordingGroup")]
        internal sealed class _Proxy : DeputyBase, aws.IConfigConfigurationRecorderRecordingGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "allSupported", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllSupported
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeGlobalResourceTypes", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeGlobalResourceTypes
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
