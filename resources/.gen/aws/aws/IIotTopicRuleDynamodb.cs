using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleDynamodb), fullyQualifiedName: "aws.IotTopicRuleDynamodb")]
    public interface IIotTopicRuleDynamodb
    {
        [JsiiProperty(name: "hashKeyField", typeJson: "{\"primitive\":\"string\"}")]
        string HashKeyField
        {
            get;
        }

        [JsiiProperty(name: "hashKeyValue", typeJson: "{\"primitive\":\"string\"}")]
        string HashKeyValue
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        [JsiiProperty(name: "hashKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HashKeyType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operation
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "payloadField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayloadField
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rangeKeyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKeyField
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rangeKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKeyType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rangeKeyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKeyValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleDynamodb), fullyQualifiedName: "aws.IotTopicRuleDynamodb")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleDynamodb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "hashKeyField", typeJson: "{\"primitive\":\"string\"}")]
            public string HashKeyField
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "hashKeyValue", typeJson: "{\"primitive\":\"string\"}")]
            public string HashKeyValue
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "hashKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HashKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operation
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "payloadField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayloadField
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rangeKeyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKeyField
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rangeKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rangeKeyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKeyValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
