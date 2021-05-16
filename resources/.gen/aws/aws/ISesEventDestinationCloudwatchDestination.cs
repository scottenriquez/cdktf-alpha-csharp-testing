using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISesEventDestinationCloudwatchDestination), fullyQualifiedName: "aws.SesEventDestinationCloudwatchDestination")]
    public interface ISesEventDestinationCloudwatchDestination
    {
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultValue
        {
            get;
        }

        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionName
        {
            get;
        }

        [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}")]
        string ValueSource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationCloudwatchDestination), fullyQualifiedName: "aws.SesEventDestinationCloudwatchDestination")]
        internal sealed class _Proxy : DeputyBase, aws.ISesEventDestinationCloudwatchDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultValue
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueSource
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
