using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDbOptionGroupOption), fullyQualifiedName: "aws.DbOptionGroupOption")]
    public interface IDbOptionGroupOption
    {
        [JsiiProperty(name: "optionName", typeJson: "{\"primitive\":\"string\"}")]
        string OptionName
        {
            get;
        }

        [JsiiProperty(name: "dbSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DbSecurityGroupMemberships
        {
            get
            {
                return null;
            }
        }

        /// <summary>option_settings block.</summary>
        [JsiiProperty(name: "optionSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DbOptionGroupOptionOptionSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDbOptionGroupOptionOptionSettings[]? OptionSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "vpcSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupMemberships
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbOptionGroupOption), fullyQualifiedName: "aws.DbOptionGroupOption")]
        internal sealed class _Proxy : DeputyBase, aws.IDbOptionGroupOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "optionName", typeJson: "{\"primitive\":\"string\"}")]
            public string OptionName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "dbSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DbSecurityGroupMemberships
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>option_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "optionSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DbOptionGroupOptionOptionSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDbOptionGroupOptionOptionSettings[]? OptionSettings
            {
                get => GetInstanceProperty<aws.IDbOptionGroupOptionOptionSettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupMemberships
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
