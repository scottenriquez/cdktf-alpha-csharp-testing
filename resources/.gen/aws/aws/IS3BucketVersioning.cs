using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketVersioning), fullyQualifiedName: "aws.S3BucketVersioning")]
    public interface IS3BucketVersioning
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "mfaDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? MfaDelete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketVersioning), fullyQualifiedName: "aws.S3BucketVersioning")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketVersioning
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "mfaDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? MfaDelete
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
