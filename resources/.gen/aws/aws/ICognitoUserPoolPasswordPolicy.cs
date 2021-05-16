using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolPasswordPolicy), fullyQualifiedName: "aws.CognitoUserPoolPasswordPolicy")]
    public interface ICognitoUserPoolPasswordPolicy
    {
        [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumLength
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireLowercase", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireLowercase
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireNumbers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireNumbers
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireSymbols", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireSymbols
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireUppercase", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireUppercase
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "temporaryPasswordValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TemporaryPasswordValidityDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolPasswordPolicy), fullyQualifiedName: "aws.CognitoUserPoolPasswordPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolPasswordPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumLength
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireLowercase", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireLowercase
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireNumbers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireNumbers
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireSymbols", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireSymbols
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireUppercase", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireUppercase
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "temporaryPasswordValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TemporaryPasswordValidityDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
