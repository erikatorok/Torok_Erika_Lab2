namespace Torok_Erika_Lab2.Models
{
    public class Author
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public int LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
