namespace PolymorphicCreationWithFactoryMethod.MyWork
{
    public class DOMBuilderTest: AbstractBuilderTest
    {
        protected override OutputBuilder CreateBuilder(string rootName)
        {
            return new DOMBuilder(rootName);
        }
    }
}
