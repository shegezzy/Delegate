namespace Delegate
{

    /// <summary>
    /// Main program
    /// </summary>
    public class Program
    {
        public delegate bool Predicate(XClass x);       //predicate

        public bool WhereOne(Predicate y)       //method that takes in the delegate
        {
            return true;
        }
        static void Main(string[] args)
        {
            var repoUser = new Program();
            var t = new XClass();
            var likelyUsername = t.FirstName + "." + t.LastName;
            var dUserCount = repoUser.WhereOne(x => x.UserName == likelyUsername);
        }

    }
    /// <summary>
    /// Public class with the properties
    /// </summary>
    public class XClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string UserName { get; set; }
    }
}