using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildProjectSource")]
    public class CodebuildProjectSource : aws.ICodebuildProjectSource
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>auth block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSourceAuth\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectSourceAuth[]? Auth
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
        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSourceGitSubmodulesConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectSourceGitSubmodulesConfig[]? GitSubmodulesConfig
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
