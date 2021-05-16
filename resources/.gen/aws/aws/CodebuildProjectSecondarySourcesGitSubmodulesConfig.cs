using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
    public class CodebuildProjectSecondarySourcesGitSubmodulesConfig : aws.ICodebuildProjectSecondarySourcesGitSubmodulesConfig
    {
        [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool FetchSubmodules
        {
            get;
            set;
        }
    }
}
