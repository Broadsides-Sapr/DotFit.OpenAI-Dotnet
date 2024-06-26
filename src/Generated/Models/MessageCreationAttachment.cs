// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class MessageCreationAttachment
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public MessageCreationAttachment(string fileId, IEnumerable<ToolDefinition> tools)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));
            Argument.AssertNotNull(tools, nameof(tools));

            FileId = fileId;
            Tools = tools.ToList();
        }

        internal MessageCreationAttachment(string fileId, IReadOnlyList<ToolDefinition> tools, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            Tools = tools;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal MessageCreationAttachment()
        {
        }

        public string FileId { get; }
    }
}
