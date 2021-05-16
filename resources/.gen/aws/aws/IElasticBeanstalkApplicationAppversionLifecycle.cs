using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticBeanstalkApplicationAppversionLifecycle), fullyQualifiedName: "aws.ElasticBeanstalkApplicationAppversionLifecycle")]
    public interface IElasticBeanstalkApplicationAppversionLifecycle
    {
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRole
        {
            get;
        }

        [JsiiProperty(name: "deleteSourceFromS3", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DeleteSourceFromS3
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxAgeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAgeInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticBeanstalkApplicationAppversionLifecycle), fullyQualifiedName: "aws.ElasticBeanstalkApplicationAppversionLifecycle")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticBeanstalkApplicationAppversionLifecycle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "deleteSourceFromS3", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DeleteSourceFromS3
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxAgeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAgeInDays
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
