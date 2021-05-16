using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions), fullyQualifiedName: "aws.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions")]
    public interface IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions
    {
        [JsiiProperty(name: "masterUserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterUserArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterUserName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "masterUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterUserPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions), fullyQualifiedName: "aws.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "masterUserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterUserArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterUserName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "masterUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterUserPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
