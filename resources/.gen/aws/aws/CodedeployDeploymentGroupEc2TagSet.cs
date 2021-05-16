using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupEc2TagSet")]
    public class CodedeployDeploymentGroupEc2TagSet : aws.ICodedeployDeploymentGroupEc2TagSet
    {
        /// <summary>ec2_tag_filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSetEc2TagFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupEc2TagSetEc2TagFilter[]? Ec2TagFilter
        {
            get;
            set;
        }
    }
}
