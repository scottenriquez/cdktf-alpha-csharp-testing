using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElastictranscoderPipelineContentConfigPermissions")]
    public class ElastictranscoderPipelineContentConfigPermissions : aws.IElastictranscoderPipelineContentConfigPermissions
    {
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Access
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantee", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Grantee
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GranteeType
        {
            get;
            set;
        }
    }
}
