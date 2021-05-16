using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2ClientVpnEndpointConfig), fullyQualifiedName: "aws.Ec2ClientVpnEndpointConfig")]
    public interface IEc2ClientVpnEndpointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>authentication_options block.</summary>
        [JsiiProperty(name: "authenticationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointAuthenticationOptions\"},\"kind\":\"array\"}}")]
        aws.IEc2ClientVpnEndpointAuthenticationOptions[] AuthenticationOptions
        {
            get;
        }

        [JsiiProperty(name: "clientCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string ClientCidrBlock
        {
            get;
        }

        /// <summary>connection_log_options block.</summary>
        [JsiiProperty(name: "connectionLogOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointConnectionLogOptions\"},\"kind\":\"array\"}}")]
        aws.IEc2ClientVpnEndpointConnectionLogOptions[] ConnectionLogOptions
        {
            get;
        }

        [JsiiProperty(name: "serverCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServerCertificateArn
        {
            get;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsServers
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "splitTunnel", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SplitTunnel
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransportProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2ClientVpnEndpointConfig), fullyQualifiedName: "aws.Ec2ClientVpnEndpointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2ClientVpnEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authentication_options block.</summary>
            [JsiiProperty(name: "authenticationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointAuthenticationOptions\"},\"kind\":\"array\"}}")]
            public aws.IEc2ClientVpnEndpointAuthenticationOptions[] AuthenticationOptions
            {
                get => GetInstanceProperty<aws.IEc2ClientVpnEndpointAuthenticationOptions[]>()!;
            }

            [JsiiProperty(name: "clientCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientCidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>connection_log_options block.</summary>
            [JsiiProperty(name: "connectionLogOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointConnectionLogOptions\"},\"kind\":\"array\"}}")]
            public aws.IEc2ClientVpnEndpointConnectionLogOptions[] ConnectionLogOptions
            {
                get => GetInstanceProperty<aws.IEc2ClientVpnEndpointConnectionLogOptions[]>()!;
            }

            [JsiiProperty(name: "serverCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerCertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsServers
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "splitTunnel", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SplitTunnel
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransportProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}