using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpecListenerPortMapping), fullyQualifiedName: "aws.AppmeshVirtualRouterSpecListenerPortMapping")]
    public interface IAppmeshVirtualRouterSpecListenerPortMapping
    {
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpecListenerPortMapping), fullyQualifiedName: "aws.AppmeshVirtualRouterSpecListenerPortMapping")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualRouterSpecListenerPortMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
