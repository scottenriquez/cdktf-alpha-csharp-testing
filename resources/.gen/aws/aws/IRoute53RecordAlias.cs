using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordAlias), fullyQualifiedName: "aws.Route53RecordAlias")]
    public interface IRoute53RecordAlias
    {
        [JsiiProperty(name: "evaluateTargetHealth", typeJson: "{\"primitive\":\"boolean\"}")]
        bool EvaluateTargetHealth
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordAlias), fullyQualifiedName: "aws.Route53RecordAlias")]
        internal sealed class _Proxy : DeputyBase, aws.IRoute53RecordAlias
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "evaluateTargetHealth", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool EvaluateTargetHealth
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
