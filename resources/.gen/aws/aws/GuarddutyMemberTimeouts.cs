using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GuarddutyMemberTimeouts")]
    public class GuarddutyMemberTimeouts : aws.IGuarddutyMemberTimeouts
    {
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Create
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
