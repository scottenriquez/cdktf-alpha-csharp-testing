using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionAccepterAccepter), fullyQualifiedName: "aws.VpcPeeringConnectionAccepterAccepter")]
    public interface IVpcPeeringConnectionAccepterAccepter
    {
        [JsiiProperty(name: "allowClassicLinkToRemoteVpc", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowClassicLinkToRemoteVpc
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowRemoteVpcDnsResolution
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "allowVpcToRemoteClassicLink", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowVpcToRemoteClassicLink
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionAccepterAccepter), fullyQualifiedName: "aws.VpcPeeringConnectionAccepterAccepter")]
        internal sealed class _Proxy : DeputyBase, aws.IVpcPeeringConnectionAccepterAccepter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowClassicLinkToRemoteVpc", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowClassicLinkToRemoteVpc
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowRemoteVpcDnsResolution
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowVpcToRemoteClassicLink", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowVpcToRemoteClassicLink
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
