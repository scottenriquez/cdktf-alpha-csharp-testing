using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierJsonClassifier), fullyQualifiedName: "aws.GlueClassifierJsonClassifier")]
    public interface IGlueClassifierJsonClassifier
    {
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        string JsonPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierJsonClassifier), fullyQualifiedName: "aws.GlueClassifierJsonClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueClassifierJsonClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
