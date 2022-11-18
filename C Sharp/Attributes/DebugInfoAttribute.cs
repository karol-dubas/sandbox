using System;

namespace Attributes
{
    class DebugInfoAttribute : Attribute
    {
        public int CodeNumber { get; private set; }
        public string DeveloperName { get; private set; }
        public string LastReviewData { get; private set; }
        public string Message { get; set; }

        public DebugInfoAttribute(int codeNumber, string developerName, string lastReviewData)
        {
            CodeNumber = codeNumber;
            DeveloperName = developerName;
            LastReviewData = lastReviewData;
        }
    }
}
