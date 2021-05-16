using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierXmlClassifier), fullyQualifiedName: "aws.GlueClassifierXmlClassifier")]
    public interface IGlueClassifierXmlClassifier
    {
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        string Classification
        {
            get;
        }

        [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
        string RowTag
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierXmlClassifier), fullyQualifiedName: "aws.GlueClassifierXmlClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueClassifierXmlClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
            public string Classification
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
            public string RowTag
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
