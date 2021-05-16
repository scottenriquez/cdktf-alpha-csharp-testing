using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SsmPatchBaseline), fullyQualifiedName: "aws.SsmPatchBaseline", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SsmPatchBaselineConfig\"}}]")]
    public class SsmPatchBaseline : HashiCorp.Cdktf.TerraformResource
    {
        public SsmPatchBaseline(Constructs.Construct scope, string id, aws.ISsmPatchBaselineConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmPatchBaseline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmPatchBaseline(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetApprovalRule")]
        public virtual void ResetApprovalRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApprovedPatches")]
        public virtual void ResetApprovedPatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApprovedPatchesComplianceLevel")]
        public virtual void ResetApprovedPatchesComplianceLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalFilter")]
        public virtual void ResetGlobalFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperatingSystem")]
        public virtual void ResetOperatingSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRejectedPatches")]
        public virtual void ResetRejectedPatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvalRuleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineApprovalRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISsmPatchBaselineApprovalRule[]? ApprovalRuleInput
        {
            get => GetInstanceProperty<aws.ISsmPatchBaselineApprovalRule[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvedPatchesComplianceLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApprovedPatchesComplianceLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvedPatchesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApprovedPatchesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineGlobalFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISsmPatchBaselineGlobalFilter[]? GlobalFilterInput
        {
            get => GetInstanceProperty<aws.ISsmPatchBaselineGlobalFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatingSystemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectedPatchesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RejectedPatchesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "approvalRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineApprovalRule\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmPatchBaselineApprovalRule[] ApprovalRule
        {
            get => GetInstanceProperty<aws.ISsmPatchBaselineApprovalRule[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "approvedPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApprovedPatches
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "approvedPatchesComplianceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApprovedPatchesComplianceLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineGlobalFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.ISsmPatchBaselineGlobalFilter[] GlobalFilter
        {
            get => GetInstanceProperty<aws.ISsmPatchBaselineGlobalFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rejectedPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RejectedPatches
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
