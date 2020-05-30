using System;

namespace MoveAccumulationToCollectingParameter.InitialCode
{
    public class TagNode
    {
        private string _tagName;
        private string _attributes;

        public TagNode(string tagName, string attributes)
        {
            _attributes = attributes;
            _tagName = tagName;
        }

        public override string ToString()
        {
            string result = String.Empty;

            result += "<" + _tagName + " " + _attributes + ">";

            result += "</" + _tagName + ">";
            return result;
        }
    }
}