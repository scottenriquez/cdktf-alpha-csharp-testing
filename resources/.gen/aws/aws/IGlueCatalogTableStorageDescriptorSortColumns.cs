using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableStorageDescriptorSortColumns), fullyQualifiedName: "aws.GlueCatalogTableStorageDescriptorSortColumns")]
    public interface IGlueCatalogTableStorageDescriptorSortColumns
    {
        [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
        string Column
        {
            get;
        }

        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
        double SortOrder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableStorageDescriptorSortColumns), fullyQualifiedName: "aws.GlueCatalogTableStorageDescriptorSortColumns")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueCatalogTableStorageDescriptorSortColumns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
            public string Column
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double SortOrder
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
