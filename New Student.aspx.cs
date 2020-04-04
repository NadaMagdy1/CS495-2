using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class New_Student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        // Create Connection Object
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";

        // Create SQL Insert Statement
        string strInsert = "INSERT INTO [dbo].[student] "
            + " VALUES('" + Name.Text + "', '"
            + ID.Text + "', '"
            + rblSex.SelectedValue + "', '"
            + Calendar1.SelectedDate + "', '"
            + Email.Text + "', '"
            + PhoneNumber.Text + "', '"
            + Address.Text + "')"
            + Password.Text + "', '"
            + Confirm.Text + "', '"
            + Nationality.SelectedValue + "', '"
            + facullty.SelectedValue + "', '"
            + bbus.SelectedValue + "', '";



        // Create SQL Command
        SqlCommand cmdInsert = new SqlCommand(strInsert, conn);


        conn.Open();
        cmdInsert.ExecuteNonQuery();
        conn.Close();
    }
}