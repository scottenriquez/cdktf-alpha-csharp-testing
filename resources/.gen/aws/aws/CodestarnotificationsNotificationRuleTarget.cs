using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodestarnotificationsNotificationRuleTarget")]
    public class CodestarnotificationsNotificationRuleTarget : aws.ICodestarnotificationsNotificationRuleTarget
    {
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Address
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
