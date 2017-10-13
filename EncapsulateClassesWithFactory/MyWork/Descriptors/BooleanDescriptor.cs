using System;

namespace EncapsulateClassesWithFactory.MyWork.Descriptors
{
    public class BooleanDescriptor : AttributeDescriptor
    {


        internal BooleanDescriptor(string descriptorName, Type mapperType, Type forType) 
            : base(descriptorName, mapperType, forType)
        {

        }
    }
}