using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsPricingProductFilters), fullyQualifiedName: "aws.DataAwsPricingProductFilters")]
    public interface IDataAwsPricingProductFilters
    {
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        string Field
        {
            get;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsPricingProductFilters), fullyQualifiedName: "aws.DataAwsPricingProductFilters")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsPricingProductFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
            public string Field
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
