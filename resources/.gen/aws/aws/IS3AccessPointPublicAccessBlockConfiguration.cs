using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3AccessPointPublicAccessBlockConfiguration), fullyQualifiedName: "aws.S3AccessPointPublicAccessBlockConfiguration")]
    public interface IS3AccessPointPublicAccessBlockConfiguration
    {
        [JsiiProperty(name: "blockPublicAcls", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? BlockPublicAcls
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "blockPublicPolicy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? BlockPublicPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ignorePublicAcls", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IgnorePublicAcls
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "restrictPublicBuckets", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RestrictPublicBuckets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3AccessPointPublicAccessBlockConfiguration), fullyQualifiedName: "aws.S3AccessPointPublicAccessBlockConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IS3AccessPointPublicAccessBlockConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "blockPublicAcls", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? BlockPublicAcls
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "blockPublicPolicy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? BlockPublicPolicy
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ignorePublicAcls", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IgnorePublicAcls
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "restrictPublicBuckets", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RestrictPublicBuckets
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
