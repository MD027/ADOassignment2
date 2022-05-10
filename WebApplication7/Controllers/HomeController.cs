using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Savedata()
        {
            ViewBag.result = "";
            return View();
        }
        [HttpPost]
        public ActionResult SaveData(int busid ,string boardingpoint,DateTime traveldate,decimal amount,int rating)
        {
            String constring = "Data Source=DESKTOP-2NLC227\\SQLEXPRESS; Initial Catalog=Sample; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "addResult";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname,sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@BusId",Convert.ToInt32(busid));
            com.Parameters.AddWithValue("@BoardingPoint", boardingpoint);
            com.Parameters.AddWithValue("@TravelDate", traveldate);
            com.Parameters.AddWithValue("@Amount", amount);
            com.Parameters.AddWithValue("@Rating",rating);
            com.ExecuteNonQuery();
            sqlcon.Close();
            ViewBag.result = "Record Has Been Saved Successfully";
            return View();

        }
    }
}