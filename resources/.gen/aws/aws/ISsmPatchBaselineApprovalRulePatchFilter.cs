using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmPatchBaselineApprovalRulePatchFilter), fullyQualifiedName: "aws.SsmPatchBaselineApprovalRulePatchFilter")]
    public interface ISsmPatchBaselineApprovalRulePatchFilter
    {
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmPatchBaselineApprovalRulePatchFilter), fullyQualifiedName: "aws.SsmPatchBaselineApprovalRulePatchFilter")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmPatchBaselineApprovalRulePatchFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
