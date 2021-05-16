using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodepipelineStage), fullyQualifiedName: "aws.CodepipelineStage")]
    public interface ICodepipelineStage
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineStageAction\"},\"kind\":\"array\"}}")]
        aws.ICodepipelineStageAction[] Action
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineStage), fullyQualifiedName: "aws.CodepipelineStage")]
        internal sealed class _Proxy : DeputyBase, aws.ICodepipelineStage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineStageAction\"},\"kind\":\"array\"}}")]
            public aws.ICodepipelineStageAction[] Action
            {
                get => GetInstanceProperty<aws.ICodepipelineStageAction[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
