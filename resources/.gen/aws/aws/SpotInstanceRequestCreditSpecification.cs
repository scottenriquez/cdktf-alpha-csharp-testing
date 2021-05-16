using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SpotInstanceRequestCreditSpecification")]
    public class SpotInstanceRequestCreditSpecification : aws.ISpotInstanceRequestCreditSpecification
    {
        [JsiiOptional]
        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CpuCredits
        {
            get;
            set;
        }
    }
}
