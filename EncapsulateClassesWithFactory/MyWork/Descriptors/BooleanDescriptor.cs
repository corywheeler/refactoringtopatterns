using System;

namespace EncapsulateClassesWithFactory.MyWork.Descriptors
{
    public class BooleanDescriptor : AttributeDescriptor
    {


        public BooleanDescriptor(string descriptorName, Type mapperType, Type forType) 
            : base(descriptorName, mapperType, forType)
        {

        }
    }
}