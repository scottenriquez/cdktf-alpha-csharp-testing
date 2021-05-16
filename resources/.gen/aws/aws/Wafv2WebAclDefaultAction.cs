using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2WebAclDefaultAction")]
    public class Wafv2WebAclDefaultAction : aws.IWafv2WebAclDefaultAction
    {
        /// <summary>allow block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclDefaultActionAllow\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclDefaultActionAllow[]? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclDefaultActionBlock\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclDefaultActionBlock[]? Block
        {
            get;
            set;
        }
    }
}
