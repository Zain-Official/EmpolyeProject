using System;
using System.Collections.Generic;
using System.Text;

namespace EmpolyeProject.Project
{
    class Validation
    {
        public StringBuilder Validate(Employe employe)
        {

            StringBuilder sb = new StringBuilder();
            bool flag = true;

            if (employe.empno <= 0)
            {
                sb.AppendLine("Employe No Invalid, Please Enter > 0 Value\n\r");
                flag = false;
            }
            if (employe.name.Length <= 4)
            {
                sb.AppendLine("Name Must Be Minimun 5 chars \r\n");
                flag = false;
            }

            if (employe.dept.Equals("DotNet") || employe.dept.Equals("C#"))
            {
                sb.AppendLine("Either DotNet Or C# Only Allowed");
                flag = false;

            }
            if (employe.basics <= 2000)
            {
                sb.AppendLine("Salary Must Be > than 2k");
                flag = false;
            }
            if (flag == true)
            {
                sb.AppendLine("All Validation Are Correct");

            }

            return sb;
        }
    }
}
