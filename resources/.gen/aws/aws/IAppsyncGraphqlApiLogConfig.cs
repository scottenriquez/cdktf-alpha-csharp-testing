using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiLogConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiLogConfig")]
    public interface IAppsyncGraphqlApiLogConfig
    {
        [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string CloudwatchLogsRoleArn
        {
            get;
        }

        [JsiiProperty(name: "fieldLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        string FieldLogLevel
        {
            get;
        }

        [JsiiProperty(name: "excludeVerboseContent", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ExcludeVerboseContent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiLogConfig), fullyQualifiedName: "aws.AppsyncGraphqlApiLogConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncGraphqlApiLogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudwatchLogsRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "fieldLogLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldLogLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "excludeVerboseContent", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ExcludeVerboseContent
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
