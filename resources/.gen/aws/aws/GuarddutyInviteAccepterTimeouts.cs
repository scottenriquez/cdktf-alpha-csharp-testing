using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GuarddutyInviteAccepterTimeouts")]
    public class GuarddutyInviteAccepterTimeouts : aws.IGuarddutyInviteAccepterTimeouts
    {
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
