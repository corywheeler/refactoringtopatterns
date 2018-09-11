using System;

namespace EncapsulateClassesWithFactory.InitialCode.Descriptors
{
    public class ReferenceDescriptor: AttributeDescriptor
    {

        public ReferenceDescriptor(string descriptorName, Type mapperType, Type forType)
            : base(descriptorName, mapperType, forType)
        {
        }
    }
}