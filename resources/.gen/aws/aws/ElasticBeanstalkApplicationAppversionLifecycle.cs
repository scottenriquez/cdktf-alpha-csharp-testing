using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticBeanstalkApplicationAppversionLifecycle")]
    public class ElasticBeanstalkApplicationAppversionLifecycle : aws.IElasticBeanstalkApplicationAppversionLifecycle
    {
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRole
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteSourceFromS3", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeleteSourceFromS3
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAgeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxAgeInDays
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxCount
        {
            get;
            set;
        }
    }
}
