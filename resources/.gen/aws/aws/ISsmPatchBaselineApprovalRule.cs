using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmPatchBaselineApprovalRule), fullyQualifiedName: "aws.SsmPatchBaselineApprovalRule")]
    public interface ISsmPatchBaselineApprovalRule
    {
        [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        double ApproveAfterDays
        {
            get;
        }

        /// <summary>patch_filter block.</summary>
        [JsiiProperty(name: "patchFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineApprovalRulePatchFilter\"},\"kind\":\"array\"}}")]
        aws.ISsmPatchBaselineApprovalRulePatchFilter[] PatchFilter
        {
            get;
        }

        [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComplianceLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnableNonSecurity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmPatchBaselineApprovalRule), fullyQualifiedName: "aws.SsmPatchBaselineApprovalRule")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmPatchBaselineApprovalRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
            public double ApproveAfterDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>patch_filter block.</summary>
            [JsiiProperty(name: "patchFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineApprovalRulePatchFilter\"},\"kind\":\"array\"}}")]
            public aws.ISsmPatchBaselineApprovalRulePatchFilter[] PatchFilter
            {
                get => GetInstanceProperty<aws.ISsmPatchBaselineApprovalRulePatchFilter[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComplianceLevel
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnableNonSecurity
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
