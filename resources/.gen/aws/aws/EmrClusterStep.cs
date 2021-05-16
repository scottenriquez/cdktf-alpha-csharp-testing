using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.EmrClusterStep")]
    public class EmrClusterStep : aws.IEmrClusterStep
    {
        [JsiiOptional]
        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ActionOnFailure
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hadoopJarStep", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStepHadoopJarStep\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterStepHadoopJarStep[]? HadoopJarStep
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
