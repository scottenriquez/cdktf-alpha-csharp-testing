using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildProjectSecondarySources")]
    public class CodebuildProjectSecondarySources : aws.ICodebuildProjectSecondarySources
    {
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceIdentifier
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>auth block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySourcesAuth\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectSecondarySourcesAuth[]? Auth
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Buildspec
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? GitCloneDepth
        {
            get;
            set;
        }

        /// <summary>git_submodules_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectSecondarySourcesGitSubmodulesConfig[]? GitSubmodulesConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "insecureSsl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? InsecureSsl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Location
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ReportBuildStatus
        {
            get;
            set;
        }
    }
}
