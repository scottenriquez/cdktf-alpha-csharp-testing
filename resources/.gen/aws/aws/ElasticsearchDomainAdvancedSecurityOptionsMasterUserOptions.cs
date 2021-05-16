using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions")]
    public class ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions : aws.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "masterUserArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MasterUserArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MasterUserName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MasterUserPassword
        {
            get;
            set;
        }
    }
}
