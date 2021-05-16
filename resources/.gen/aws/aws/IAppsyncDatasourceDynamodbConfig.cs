using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceDynamodbConfig), fullyQualifiedName: "aws.AppsyncDatasourceDynamodbConfig")]
    public interface IAppsyncDatasourceDynamodbConfig
    {
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "useCallerCredentials", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UseCallerCredentials
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceDynamodbConfig), fullyQualifiedName: "aws.AppsyncDatasourceDynamodbConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncDatasourceDynamodbConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "useCallerCredentials", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UseCallerCredentials
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
