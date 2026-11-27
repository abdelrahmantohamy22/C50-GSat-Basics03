

using System.Drawing;
using System.Text;

namespace C50_GSat_Basics03
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Question 1
            ////1-Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //////both title and upperTitle to show that title did not change.
            string title = "clean code";
            title.ToUpper();
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region Question 2
            //Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //    to check if they point to the same object in memory.
            string STR1 = "clean code";
            string str2 = "clean code";
            Console.WriteLine(ReferenceEquals(STR1, str2));



            #endregion

            #region Question 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //    object.Print the final result.  

            StringBuilder sbj = new StringBuilder();
            sbj.Append("Book List");
            sbj.Append("- Updated");
            Console.WriteLine(sbj);



            #endregion
        }
    }
}
