using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WorkspacesIpGroupRules")]
    public class WorkspacesIpGroupRules : aws.IWorkspacesIpGroupRules
    {
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Source
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
