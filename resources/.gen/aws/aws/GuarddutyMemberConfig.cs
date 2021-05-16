using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GuarddutyMemberConfig")]
    public class GuarddutyMemberConfig : aws.IGuarddutyMemberConfig
    {
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AccountId
        {
            get;
            set;
        }

        [JsiiProperty(name: "detectorId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DetectorId
        {
            get;
            set;
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Email
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableEmailNotification", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DisableEmailNotification
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "invitationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InvitationMessage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "invite", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Invite
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.GuarddutyMemberTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IGuarddutyMemberTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
