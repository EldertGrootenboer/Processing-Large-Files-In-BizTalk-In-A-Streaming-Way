using System.IO;
using System.Text;
using System.Xml;

using Microsoft.BizTalk.Streaming;

namespace Eldert.Samples.ProcessLargeMessage
{
    /// <summary>
    /// XmlTranslatorStream used to extract contents from a node, and save them in a temporary location.
    /// </summary>
    public class ExtractLargeDataTranslatorStream : XmlTranslatorStream
    {
        /// <summary>
        /// Boolean indicating if we are processing the node with the data.
        /// </summary>
        private bool _atLargeDataNode;

        /// <summary>
        /// Path where we want to store our temporary file.
        /// </summary>
        public string TempPath { get; set; }

        /// <summary>
        /// Name of the node with the data we want to extract.
        /// </summary>
        internal string LargeDataNodeName { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public ExtractLargeDataTranslatorStream(XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public ExtractLargeDataTranslatorStream(XmlReader reader, Encoding encoding) : base(reader, encoding)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public ExtractLargeDataTranslatorStream(XmlReader reader, Encoding encoding, MemoryStream outputStream) : base(reader, encoding, outputStream)
        {
        }

        /// <summary>
        /// Override, will fire when processing a start element.
        /// </summary>
        protected override void TranslateStartElement(string prefix, string localName, string nsURI)
        {
            // Check if this is the node with the data we are looking for
            if (localName == LargeDataNodeName)
            {
                // Set boolean, so next time we enter TranslateText we know we are in the data node
                _atLargeDataNode = true;
            }

            // Continue processing as we normally would
            base.TranslateStartElement(prefix, localName, nsURI);
        }

        /// <summary>
        /// Override, will fire when processing a text node.
        /// </summary>
        protected override void TranslateText(string s)
        {
            // Check if we are processing the data node
            if (_atLargeDataNode)
            {
                // Create output file name
                // In case no path was specified, we will use the default temp path
                // Make sure to always specify a path in case of a group with multiple servers
                var outputFileName = Path.Combine(string.IsNullOrWhiteSpace(TempPath) ? Path.GetTempPath() : TempPath, Path.GetRandomFileName());

                // Write the file
                File.WriteAllText(outputFileName, s);

                // Replace the large data with a pointer to the temporary file
                base.TranslateText(outputFileName);

                // We have finished processing the node with the large data
                _atLargeDataNode = false;
            }
            else
            {
                // Process normal
                base.TranslateText(s);
            }
        }
    }
}