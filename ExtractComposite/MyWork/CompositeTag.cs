namespace ExtractComposite.MyWork
{
    public abstract class CompositeTag: Tag
    {
        protected CompositeTag(string openingTag, string closingTag) : base(openingTag, closingTag)
        {
        }
    }
}