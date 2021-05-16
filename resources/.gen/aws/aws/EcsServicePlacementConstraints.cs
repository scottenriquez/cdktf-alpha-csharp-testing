using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsServicePlacementConstraints")]
    public class EcsServicePlacementConstraints : aws.IEcsServicePlacementConstraints
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Expression
        {
            get;
            set;
        }
    }
}
