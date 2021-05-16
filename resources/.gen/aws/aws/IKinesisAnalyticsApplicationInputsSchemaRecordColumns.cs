using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordColumns), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordColumns")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordColumns
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}")]
        string SqlType
        {
            get;
        }

        [JsiiProperty(name: "mapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mapping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordColumns), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordColumns")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputsSchemaRecordColumns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "mapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mapping
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
