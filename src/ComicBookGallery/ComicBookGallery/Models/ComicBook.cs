namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber{ get; set; }
        public string DescriptionHtml { get; set; } 
        public Artist[] Artists { get; set; }  
        public bool Favorite { get; set; }

        //This property will be readonly(inother words value cannot be changed by a setter,since no setter
        public string DisplayText
        {
            get
            {
                return SeriesTitle + "#" + IssueNumber;
            }
        }


        //series-title-issuNumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}
