using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSourceGitSubmodulesConfig), fullyQualifiedName: "aws.CodebuildProjectSourceGitSubmodulesConfig")]
    public interface ICodebuildProjectSourceGitSubmodulesConfig
    {
        [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"primitive\":\"boolean\"}")]
        bool FetchSubmodules
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSourceGitSubmodulesConfig), fullyQualifiedName: "aws.CodebuildProjectSourceGitSubmodulesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectSourceGitSubmodulesConfig
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
