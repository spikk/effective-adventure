﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NavWS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        Controllers.Controller cont = new Controllers.Controller();
        [WebMethod]
        public List<string> GetEmployees()
        {

            Controllers.Controller cont = new Controllers.Controller();
            return cont.showAllEmployees();
        }
        [WebMethod]
        public List<Models.EmployeeModel> ShowAllEmployeesListDAL()
        {
            Controllers.Controller cont = new Controllers.Controller();
            return cont.ShowAllEmployeesListDAL();
        }
        [WebMethod]
        public List<List<string>> GetEmployeesList()
        {
            Controllers.Controller cont = new Controllers.Controller();
            return cont.GetEmployees();
        }


        [WebMethod]
        public List<List<string>> GetRelative()
        {

            return GetRelative();
        }

        [WebMethod]
        public List<List<string>> GetEmployeeAbsence()
        {
            return cont.GetEmployeeAbsence();
        }

        [WebMethod]
        public List<List<string>> GetSickestEmployee()
        {
            return cont.GetSickestEmployee();
        }

        //SQL META
        [WebMethod]
        public List<List<string>> GetKeys()
        {
            return cont.GetKeys();
        }

        [WebMethod]
        public List<List<string>> GetIndexes()
        {
            return cont.GetIndexes();
        }

        [WebMethod]
        public List<List<string>> GetConstraints()
        {
            return cont.GetConstraints();
        }

        [WebMethod]
        public List<List<string>> GetAllTables()
        {
            return cont.GetAllTables();
        }

        [WebMethod]
        public List<List<string>> GetAllTables2()
        {
            return cont.GetAllTables2();
        }

        [WebMethod]
        public List<List<string>> GetEmployeesMeta()
        {
            return cont.GetEmployeesMeta();
        }

        [WebMethod]
        public List<List<string>> GetEmployeesMeta2()
        {
            return cont.GetEmployeesMeta2();
        }

        //-----Add/remove/insert/update---------

        [WebMethod]
        public Models.EmployeeModel GetEmployee(string id)
        {
            SqlDataReader sqlReader = cont.GetEmployee(id);

            Models.EmployeeModel emp = null;

            while (sqlReader.Read())
            {
                emp = new Models.EmployeeModel();
                emp.Employee_No_ = sqlReader.GetString(0);
                emp.First_Name = sqlReader.GetString(1);
            }

            return emp;
        }

        [WebMethod]
        public void AddEmployee(string id, string firstName)
        {
            cont.AddEmployee(id, firstName);
        }

        [WebMethod]
        public void DeleteEmployee(string id)
        {
            cont.DeleteEmployee(id);
        }

        [WebMethod]
        public void UpdateEmployee(string id, string firstName)
        {
            cont.UpdateEmployee(id, firstName);
        }
    }
}