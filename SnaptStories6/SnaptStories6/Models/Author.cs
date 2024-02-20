namespace SnaptStories6.Models
{
    public class author
    {
        //the author ID
        public int authorID { get; set; }
        //the author name
        public string authorName { get; set; }
        //the author description
        public string authorDescription { get; set; }
        //the author email
        public string authorEmail { get; set; }
        //the author password
        public string authorPassword { get; set; }
        //the author Phone number
        public string authorPhoneNumber { get; set; }
        //the author image
        public string authorImage { get; set; }
        //the author status
        public string authorStatus { get; set; }
        //the author url
        public string authorUrl { get; set; }
        //the author facebook account
        public string authorFacebook { get; set; }
        //the author twitter account
        public string authorTwitter { get; set; }
        //the author linkedin account
        public string authorLinkedin { get; set; }
        //the author youtube account
        public string authorYoutube { get; set; }
        //the author instagram account
        public string authorInstagram { get; set; }
        // the number of short stories create by the author
        public int NumberOfShortStories { get; set; }
    }
}
