using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO 3.3 Set the text value of the finalGrade label to "Submit your grade percentage to see your final grade!". Watch out for post backs
            if(!IsPostBack) finalGrade.Text = "Submit your grade percentage to see your final grade!";
        }

        protected void ConvertGrade(object sender, EventArgs e)
        {
            double percentage = Convert.ToDouble(percentageGrade.Text);

            // Calculate the equivalent numerical grade based on the specified GPA system
            string final_Grade = CalculateGPA(percentage);

            // Display the result
            finalGrade.Text = final_Grade;

            // Additional logic for special cases (e.g., perfect score)
            if (percentage == 100)
            {
                // Show a JavaScript alert
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Congratulations! Perfect score!');", true);
            }
        }

        private string CalculateGPA(double percentage)
        {
            // Your custom logic to determine the GPA equivalent
            // Example: A, B, C, etc.
            // You can replace this with your own grading system
            if (percentage >= 95)
                return "1.00 (Excellent)";
            else if (percentage >= 90)
                return "1.25 (Very Good)";
            else if (percentage >= 85)
                return "1.50 (Good)";
            else if (percentage >= 80)
                return "2.00 (Good)";
            else if (percentage >= 75)
                return "2.25 (Pass)";
            else if (percentage >= 70)
                return "2.50 (Pass)";
            else if (percentage >= 65)
                return "2.75 (Pass)";
            else if (percentage >= 60)
                return "3.00 (Pass-ang awa)";
            else
                return "5.00 (Fail)";
        }

    }
}