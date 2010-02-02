using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Novacode;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Playing_around 
    {
        [Test]
        public void Try_something()
        {
            // Load the document that you want to manipulate

            DocX document = DocX.Load(@"C:\temp\test.docx");

            // Loop through the paragraphs in the document

            foreach (Paragraph p in document.Paragraphs)
            {

                /* 


                * Replace each instance of the string pear with the string banana.


                * Specifying true as the third argument informs DocX to track the


                * changes made by this replace. The fourth argument tells DocX to


                * ignore case when matching the string pear.


                */


                p.ReplaceText("This is a test", "ffsd sd sf afe", false, RegexOptions.IgnoreCase);


            }

            // Save changes made to this document

            document.Save();

        }
    }
}
