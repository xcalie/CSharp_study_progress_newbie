namespace _309_Linear_storage
{
    internal class Program
    {
        public class Linklist<T>
        {
            public LinkNote<T> head;
            public LinkNote<T> last;

            public void Add(T value)
            {
                LinkNote<T> node = new LinkNote<T>(value);
                if (head == null)
                {
                    head = node;
                    last = node;
                }
                else
                {
                    last.NextLinkNote = node;
                    last = node;
                }
            }

            public void Remove(T value)
            {
                if (head == null)
                {
                    return;
                }

                if (head.value.Equals(value))
                {
                    head = head.NextLinkNote;
                    if (head == null)
                    {
                        last = null;
                    }
                    return;
                }
                
                LinkNote<T> node = head;
                while (node.NextLinkNote != null)
                {
                    if (node.NextLinkNote.value.Equals(value))
                    {
                        node.NextLinkNote = node.NextLinkNote.NextLinkNote;
                    }
                }
            }
        }
        
        public class LinkNote<T>
        {
            public T value;
            public LinkNote<T> NextLinkNote;

            public LinkNote(T value)
            {
                this.value = value;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
