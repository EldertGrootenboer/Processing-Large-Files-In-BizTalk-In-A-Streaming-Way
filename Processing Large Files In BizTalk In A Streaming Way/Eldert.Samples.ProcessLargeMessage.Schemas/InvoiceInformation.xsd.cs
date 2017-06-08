namespace Eldert.Samples.ProcessLargeMessage.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Eldert/ProcessLargeDataSample/V1-0",@"InvoiceInformation")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InvoiceInformation"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Eldert.Samples.ProcessLargeMessage.Schemas.InvoiceInformationTypes", typeof(global::Eldert.Samples.ProcessLargeMessage.Schemas.InvoiceInformationTypes))]
    public sealed class InvoiceInformation : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://Eldert/ProcessLargeDataSample/V1-0"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://Eldert/ProcessLargeDataSample/V1-0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Eldert.Samples.ProcessLargeMessage.Schemas.InvoiceInformationTypes"" />
  <xs:element name=""InvoiceInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SalesOrdernummer"" />
        <xs:element ref=""Customer"" />
        <xs:element ref=""Amount"" />
        <xs:element ref=""Invoice"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InvoiceInformation() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InvoiceInformation";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
