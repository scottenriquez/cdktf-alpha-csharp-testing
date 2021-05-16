using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticsearchDomainAdvancedSecurityOptions")]
    public class ElasticsearchDomainAdvancedSecurityOptions : aws.IElasticsearchDomainAdvancedSecurityOptions
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? InternalUserDatabaseEnabled
        {
            get;
            set;
        }

        /// <summary>master_user_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterUserOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions[]? MasterUserOptions
        {
            get;
            set;
        }
    }
}
