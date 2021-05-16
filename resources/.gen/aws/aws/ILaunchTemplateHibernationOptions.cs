using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateHibernationOptions), fullyQualifiedName: "aws.LaunchTemplateHibernationOptions")]
    public interface ILaunchTemplateHibernationOptions
    {
        [JsiiProperty(name: "configured", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Configured
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateHibernationOptions), fullyQualifiedName: "aws.LaunchTemplateHibernationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateHibernationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "configured", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Configured
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
