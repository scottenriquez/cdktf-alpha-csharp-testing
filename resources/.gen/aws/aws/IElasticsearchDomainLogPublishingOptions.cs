using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainLogPublishingOptions), fullyQualifiedName: "aws.ElasticsearchDomainLogPublishingOptions")]
    public interface IElasticsearchDomainLogPublishingOptions
    {
        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string CloudwatchLogGroupArn
        {
            get;
        }

        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        string LogType
        {
            get;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainLogPublishingOptions), fullyQualifiedName: "aws.ElasticsearchDomainLogPublishingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainLogPublishingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudwatchLogGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
            public string LogType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
