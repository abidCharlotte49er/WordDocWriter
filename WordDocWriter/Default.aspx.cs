using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Novacode; // DocX Namespace 

//Creating Shortcuts for Namespaces 
using WindowsBitmap = System.Drawing.Bitmap;
using WindowsBrushes = System.Drawing.Brushes;
using WindowsColor = System.Drawing.Color;
using WindowsFont = System.Drawing.Font;
using WindowsFontFamily = System.Drawing.FontFamily;
using WindowsGraphics = System.Drawing.Graphics;
using WindowsImageFormat = System.Drawing.Imaging.ImageFormat;

namespace WordDocWriter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  Btn_CreateDoc_Click(null, null); 
        }

        protected void Btn_CreateDoc_Click(object sender, EventArgs e)
        {
            string SaveFileAt = @"C:\Users\buddu\Documents\Visual Studio 2017\Projects\WordDocWriter\WordDocWriter\";
            string FileName = "HelloDocWorld.docx"; 
            using (DocX document = DocX.Create(SaveFileAt + FileName))
            {
                Paragraph para = document.InsertParagraph();


                if (string.IsNullOrEmpty(Inp_fName.Value) && string.IsNullOrEmpty(Inp_lName.Value))
                {
                    Inp_fName.Value = "Abid"; 
                    Inp_lName.Value = "Shaik";
                    Txt_Comment.Value = "Hello Doc World!! Comments comming from hard coded text"; 
                }

                para.Append(Inp_fName.Value + " " + Inp_lName.Value)
                    .Font(new Font("Algerian"))
                    .FontSize(18)
                    .Color(WindowsColor.Black).Bold(); 

                para.Append(Environment.NewLine).Append(Environment.NewLine);

                //document.Save(); 

                para.Append(Txt_Comment.Value).Font(new Font("Bell MT"))
                    .FontSize(24)
                    .Color(WindowsColor.Blue)
                    .Bold();
                para.KeepWithNext();

                Paragraph p1 = document.InsertParagraph();
                p1.InsertHorizontalLine("double", 6, 1, "red");
                Paragraph p2 = document.InsertParagraph();
                p2.InsertHorizontalLine("single", 6, 1, "red");
                Paragraph p3 = document.InsertParagraph();
                p3.InsertHorizontalLine("triple", 6, 1, "blue");
                Paragraph p4 = document.InsertParagraph();
                p4.InsertHorizontalLine("double", 3, 10, "red");

                Paragraph p = document.InsertParagraph();

                p.Append("I am ").Append("bold").Bold()
                .Append(" and I am ")
                .Append("italic").Italic().Append(".")
                .AppendLine("I am ")
                .Append("Arial Black")
                .Font(new Font("Arial Black"))
                .Append(" and I am not.")
                .AppendLine("I am ")
                .Append("BLUE").Color(WindowsColor.Blue)
                .Append(" and I am")
                .Append("Red").Color(WindowsColor.Red).Append(".");

                document.Save(); 
            }
        }
    }
}