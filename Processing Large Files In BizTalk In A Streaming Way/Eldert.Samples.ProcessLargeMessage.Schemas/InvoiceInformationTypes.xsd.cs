namespace Eldert.Samples.ProcessLargeMessage.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SalesOrdernummer", @"Customer", @"Amount", @"Invoice"})]
    public sealed class InvoiceInformationTypes : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SalesOrdernummer"" type=""xs:unsignedLong"" />
  <xs:element name=""Customer"" type=""xs:string"" />
  <xs:element name=""Amount"" type=""xs:unsignedInt"" />
  <xs:element name=""Invoice"" type=""xs:string"" />
</xs:schema>";
        
        public InvoiceInformationTypes() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "SalesOrdernummer";
                _RootElements[1] = "Customer";
                _RootElements[2] = "Amount";
                _RootElements[3] = "Invoice";
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
        
        [Schema(@"",@"SalesOrdernummer")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SalesOrdernummer"})]
        public sealed class SalesOrdernummer : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SalesOrdernummer() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SalesOrdernummer";
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
        
        [Schema(@"",@"Customer")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Customer"})]
        public sealed class Customer : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Customer() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Customer";
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
        
        [Schema(@"",@"Amount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Amount"})]
        public sealed class Amount : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Amount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Amount";
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
        
        [Schema(@"",@"Invoice")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Invoice"})]
        public sealed class Invoice : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Invoice() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Invoice";
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
}
