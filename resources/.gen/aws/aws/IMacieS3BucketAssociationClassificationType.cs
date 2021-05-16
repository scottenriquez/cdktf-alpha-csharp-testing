using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMacieS3BucketAssociationClassificationType), fullyQualifiedName: "aws.MacieS3BucketAssociationClassificationType")]
    public interface IMacieS3BucketAssociationClassificationType
    {
        [JsiiProperty(name: "continuous", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Continuous
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "oneTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OneTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacieS3BucketAssociationClassificationType), fullyQualifiedName: "aws.MacieS3BucketAssociationClassificationType")]
        internal sealed class _Proxy : DeputyBase, aws.IMacieS3BucketAssociationClassificationType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "continuous", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Continuous
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "oneTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OneTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
