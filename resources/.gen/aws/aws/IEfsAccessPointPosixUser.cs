using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEfsAccessPointPosixUser), fullyQualifiedName: "aws.EfsAccessPointPosixUser")]
    public interface IEfsAccessPointPosixUser
    {
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        double Gid
        {
            get;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        double Uid
        {
            get;
        }

        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SecondaryGids
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointPosixUser), fullyQualifiedName: "aws.EfsAccessPointPosixUser")]
        internal sealed class _Proxy : DeputyBase, aws.IEfsAccessPointPosixUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
            public double Gid
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
            public double Uid
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SecondaryGids
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
