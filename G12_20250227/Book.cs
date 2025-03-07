namespace G12_20250227
{
    class Book : Comparable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Pages})";
        }

        public override int CompareTo(object obj, int compareBy)
        {
            if (obj is not Book book)
            {
                throw new Exception("Not car object");
            }
            
            if (compareBy == 0)
            {
                if (Pages > book.Pages)
                {
                    return 1;
                }
            
                if (Pages < book.Pages)
                {
                    return -1;
                }
            }
            
            else if (compareBy == 1)
            {
                for (int i = 0, j = 0; i < Author.Length && j < book.Author.Length; i++, j++)
                {
                    if (Author[i] >= book.Author[j])
                    {
                        if (Author[i] == book.Author[j])
                        {
                            continue;
                        }
                        return 1;
                    }

                    if (Author[i] < book.Author[j])
                    {
                        return -1;
                    }
                }
            }

            else if (compareBy == 2)
            {
                    for (int i = 0, j = 0; i < Title.Length && j < book.Title.Length; i++, j++)
                    {
                        if (Title[i] >= book.Title[j])
                        {
                            if (Title[i] == book.Title[j])
                            {
                                continue;
                            }
                            return 1;
                        }

                        if (Title[i] < book.Title[j])
                        {
                            return -1;
                        }
                    }
            }
            else
            {
                throw new Exception("Wrong sort number");
            }
            return 0;
        }
    }
}
