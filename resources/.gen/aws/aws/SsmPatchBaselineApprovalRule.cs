using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SsmPatchBaselineApprovalRule")]
    public class SsmPatchBaselineApprovalRule : aws.ISsmPatchBaselineApprovalRule
    {
        [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ApproveAfterDays
        {
            get;
            set;
        }

        /// <summary>patch_filter block.</summary>
        [JsiiProperty(name: "patchFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineApprovalRulePatchFilter\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ISsmPatchBaselineApprovalRulePatchFilter[] PatchFilter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ComplianceLevel
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableNonSecurity
        {
            get;
            set;
        }
    }
}
