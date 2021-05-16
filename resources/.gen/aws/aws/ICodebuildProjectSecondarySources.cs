using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySources), fullyQualifiedName: "aws.CodebuildProjectSecondarySources")]
    public interface ICodebuildProjectSecondarySources
    {
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string SourceIdentifier
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>auth block.</summary>
        [JsiiProperty(name: "auth", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySourcesAuth\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectSecondarySourcesAuth[]? Auth
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Buildspec
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GitCloneDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>git_submodules_config block.</summary>
        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectSecondarySourcesGitSubmodulesConfig[]? GitSubmodulesConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "insecureSsl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? InsecureSsl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReportBuildStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySources), fullyQualifiedName: "aws.CodebuildProjectSecondarySources")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectSecondarySources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auth block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySourcesAuth\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectSecondarySourcesAuth[]? Auth
            {
                get => GetInstanceProperty<aws.ICodebuildProjectSecondarySourcesAuth[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Buildspec
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GitCloneDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>git_submodules_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectSecondarySourcesGitSubmodulesConfig[]? GitSubmodulesConfig
            {
                get => GetInstanceProperty<aws.ICodebuildProjectSecondarySourcesGitSubmodulesConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "insecureSsl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? InsecureSsl
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReportBuildStatus
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
