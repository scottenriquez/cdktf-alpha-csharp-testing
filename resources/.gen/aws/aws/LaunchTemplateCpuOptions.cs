using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateCpuOptions")]
    public class LaunchTemplateCpuOptions : aws.ILaunchTemplateCpuOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CoreCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ThreadsPerCore
        {
            get;
            set;
        }
    }
}
