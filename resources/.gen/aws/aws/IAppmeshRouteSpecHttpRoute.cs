using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRoute), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRoute")]
    public interface IAppmeshRouteSpecHttpRoute
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteAction\"},\"kind\":\"array\"}}")]
        aws.IAppmeshRouteSpecHttpRouteAction[] Action
        {
            get;
        }

        /// <summary>match block.</summary>
        [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatch\"},\"kind\":\"array\"}}")]
        aws.IAppmeshRouteSpecHttpRouteMatch[] Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRoute), fullyQualifiedName: "aws.AppmeshRouteSpecHttpRoute")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshRouteSpecHttpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteAction\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshRouteSpecHttpRouteAction[] Action
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecHttpRouteAction[]>()!;
            }

            /// <summary>match block.</summary>
            [JsiiProperty(name: "match", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshRouteSpecHttpRouteMatch\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshRouteSpecHttpRouteMatch[] Match
            {
                get => GetInstanceProperty<aws.IAppmeshRouteSpecHttpRouteMatch[]>()!;
            }
        }
    }
}
