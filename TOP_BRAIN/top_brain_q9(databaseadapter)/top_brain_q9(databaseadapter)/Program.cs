using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=ANUSHKA\\SQLEXPRESS;Initial Catalog=COLLEGE;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);

          
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

           
            DataSet ds = new DataSet();

         
            da.Fill(ds, "Students");

            Console.WriteLine("Data Loaded Successfully!");

            DataTable table = ds.Tables["Students"];

           
            if (table.Rows.Count > 0)
            {
                table.Rows[0]["Name"] = "Anushka";
                table.Rows[0]["Age"] = 23;
            }

          
            DataRow newRow = table.NewRow();
            newRow["Name"] = "Riya";
            newRow["Age"] = 21;
            table.Rows.Add(newRow);

            if (table.Rows.Count > 1)
            {
                table.Rows[1].Delete();
            }

         
            da.Update(ds, "Students");

            Console.WriteLine("Database Updated Successfully!");

            Console.ReadLine();
        }
    }
}