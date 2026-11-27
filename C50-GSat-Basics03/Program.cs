

using System.Drawing;
using System.Runtime.Intrinsics.X86;
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

            #region Question 4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            sbj.Replace("Book list", "Library");
            Console.WriteLine($" the final result is {sbj}");


            #endregion
            #region Question 5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //    Pages: 464" using the + operator.

            string title1 = "Clean Code";
            int pages = 464;




            #endregion

            #region Question 6
            //Build the same sentence as above, but using string interpolation ($"...").
              Console.WriteLine($"Book: {title1}, Pages: {pages}");
            #endregion
            #region Question 7
            //Build the same sentence again, but using string.Format().
            Console.WriteLine(string .Format("tittle1:{0}, pages:{1}", title1, pages));


            #endregion


        }
    }
}
