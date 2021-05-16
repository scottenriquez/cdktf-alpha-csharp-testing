using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DbOptionGroupOption")]
    public class DbOptionGroupOption : aws.IDbOptionGroupOption
    {
        [JsiiProperty(name: "optionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string OptionName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? DbSecurityGroupMemberships
        {
            get;
            set;
        }

        /// <summary>option_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "optionSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DbOptionGroupOptionOptionSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDbOptionGroupOptionOptionSettings[]? OptionSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? VpcSecurityGroupMemberships
        {
            get;
            set;
        }
    }
}
