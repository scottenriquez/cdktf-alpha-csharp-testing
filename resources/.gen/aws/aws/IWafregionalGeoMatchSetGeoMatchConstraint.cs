using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalGeoMatchSetGeoMatchConstraint), fullyQualifiedName: "aws.WafregionalGeoMatchSetGeoMatchConstraint")]
    public interface IWafregionalGeoMatchSetGeoMatchConstraint
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalGeoMatchSetGeoMatchConstraint), fullyQualifiedName: "aws.WafregionalGeoMatchSetGeoMatchConstraint")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalGeoMatchSetGeoMatchConstraint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
