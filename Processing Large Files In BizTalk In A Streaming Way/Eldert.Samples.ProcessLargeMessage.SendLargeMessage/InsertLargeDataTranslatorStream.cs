using System;
using System.IO;
using System.Text;
using System.Xml;

using Microsoft.BizTalk.Streaming;

namespace Eldert.Samples.ProcessLargeMessage
{
    /// <summary>
    /// XmlTranslatorStream used to insert the contents we previously extracted back into a node.
    /// </summary>
    public class InsertLargeDataTranslatorStream : XmlTranslatorStream
    {
        /// <summary>
        /// Boolean indicating if we are processing the node with the data.
        /// </summary>
        private bool _atLargeDataNode;

        /// <summary>
        /// Name of the node with the data we want to extract.
        /// </summary>
        internal string LargeDataNodeName { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public InsertLargeDataTranslatorStream(XmlReader reader) : base(reader)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public InsertLargeDataTranslatorStream(XmlReader reader, Encoding encoding) : base(reader, encoding)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public InsertLargeDataTranslatorStream(XmlReader reader, Encoding encoding, MemoryStream outputStream) : base(reader, encoding, outputStream)
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
                // Get data from temp file
                var data = File.ReadAllText(s);

                // Replace temporary file path with actual data in node
                base.TranslateText(data);

                try
                {
                    // Delete temporary file
                    File.Delete(s);
                }
                catch (Exception)
                {
                    // ignored
                }

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