using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.ElasticsearchDomainAdvancedSecurityOptions")]
    public interface IElasticsearchDomainAdvancedSecurityOptions
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? InternalUserDatabaseEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>master_user_options block.</summary>
        [JsiiProperty(name: "masterUserOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions[]? MasterUserOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAdvancedSecurityOptions), fullyQualifiedName: "aws.ElasticsearchDomainAdvancedSecurityOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainAdvancedSecurityOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? InternalUserDatabaseEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>master_user_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions[]? MasterUserOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions[]?>();
            }
        }
    }
}
