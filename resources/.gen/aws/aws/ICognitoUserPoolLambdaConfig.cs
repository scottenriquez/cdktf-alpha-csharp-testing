using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolLambdaConfig), fullyQualifiedName: "aws.CognitoUserPoolLambdaConfig")]
    public interface ICognitoUserPoolLambdaConfig
    {
        [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreateAuthChallenge
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefineAuthChallenge
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostAuthentication
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostConfirmation
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreAuthentication
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreSignUp
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreTokenGeneration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserMigration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerifyAuthChallengeResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolLambdaConfig), fullyQualifiedName: "aws.CognitoUserPoolLambdaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICognitoUserPoolLambdaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreateAuthChallenge
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomMessage
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefineAuthChallenge
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostAuthentication
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostConfirmation
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreAuthentication
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreSignUp
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreTokenGeneration
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserMigration
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerifyAuthChallengeResponse
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
