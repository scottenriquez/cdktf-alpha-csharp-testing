using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupEc2TagSet), fullyQualifiedName: "aws.CodedeployDeploymentGroupEc2TagSet")]
    public interface ICodedeployDeploymentGroupEc2TagSet
    {
        /// <summary>ec2_tag_filter block.</summary>
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSetEc2TagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupEc2TagSetEc2TagFilter[]? Ec2TagFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupEc2TagSet), fullyQualifiedName: "aws.CodedeployDeploymentGroupEc2TagSet")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupEc2TagSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ec2_tag_filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSetEc2TagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupEc2TagSetEc2TagFilter[]? Ec2TagFilter
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEc2TagSetEc2TagFilter[]?>();
            }
        }
    }
}
