using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySourcesGitSubmodulesConfig), fullyQualifiedName: "aws.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
    public interface ICodebuildProjectSecondarySourcesGitSubmodulesConfig
    {
        [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"primitive\":\"boolean\"}")]
        bool FetchSubmodules
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySourcesGitSubmodulesConfig), fullyQualifiedName: "aws.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectSecondarySourcesGitSubmodulesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool FetchSubmodules
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
