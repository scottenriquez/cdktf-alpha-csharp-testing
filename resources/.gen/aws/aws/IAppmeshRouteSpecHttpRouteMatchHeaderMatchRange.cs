using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange")]
    public interface IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange
    {
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        double End
        {
            get;
        }

        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        double Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
            public double End
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
            public double Start
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
