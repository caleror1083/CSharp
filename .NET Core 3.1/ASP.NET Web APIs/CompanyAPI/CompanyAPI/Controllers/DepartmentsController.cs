using CompanyAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

// Namespaces
namespace CompanyAPI.Controllers
	{
		// Attributes
		[Route("api/[controller]")]
		[ApiController]

		// Classes
		public class DepartmentsController : ControllerBase
			{
				// Fields
				private readonly IConfiguration _configuration;

				// Constructors(Parameters)
				public DepartmentsController(IConfiguration configuration)
					{
						_configuration = configuration;
					}

				[HttpGet]
				public JsonResult Get()
					{
						string query = @"SELECT DepartmentID, DepartmentName FROM Departments";
						DataTable table = new DataTable();
						string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
						SqlDataReader myReader;
						using (SqlConnection myCon = new SqlConnection(sqlDataSource))
							{
								myCon.Open();
								using (SqlCommand myCommand = new SqlCommand(query, myCon))
									{
										myReader = myCommand.ExecuteReader();
										table.Load(myReader);
										myReader.Close();
										myCon.Close();
									}
							}
						return new JsonResult(table);
					}

				[HttpPost]
				public JsonResult Post(Departments dep)
					{
						string query = @"INSERT INTO Departments VALUES('"+ dep.DepartmentName +@"')";
						DataTable table = new DataTable();
						string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
						SqlDataReader myReader;
						using (SqlConnection myCon = new SqlConnection(sqlDataSource))
							{
								myCon.Open();
								using (SqlCommand myCommand = new SqlCommand(query, myCon))
									{
										myReader = myCommand.ExecuteReader();
										table.Load(myReader);
										myReader.Close();
										myCon.Close();
									}
							}
						return new JsonResult("Added Successfully!");
					}

				[HttpPut]
				public JsonResult Put(Departments dep)
					{
						string query = @"UPDATE Departments SET DepartmentName = '"+ dep.DepartmentName +@"' WHERE DepartmentID = "+ dep.DepartmentID +@"";
						DataTable table = new DataTable();
						string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
						SqlDataReader myReader;
						using (SqlConnection myCon = new SqlConnection(sqlDataSource))
							{
								myCon.Open();
								using (SqlCommand myCommand = new SqlCommand(query, myCon))
									{
										myReader = myCommand.ExecuteReader();
										table.Load(myReader);
										myReader.Close();
										myCon.Close();
									}
							}
						return new JsonResult("Updated Successfully!");
					}

				[HttpDelete("{ID}")]
				public JsonResult Delete(int ID)
					{
						string query = @"DELETE FROM Departments WHERE DepartmentID = " + ID + @"";
						DataTable table = new DataTable();
						string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
						SqlDataReader myReader;
						using (SqlConnection myCon = new SqlConnection(sqlDataSource))
							{
								myCon.Open();
								using (SqlCommand myCommand = new SqlCommand(query, myCon))
									{
										myReader = myCommand.ExecuteReader();
										table.Load(myReader);
										myReader.Close();
										myCon.Close();
									}
							}
						return new JsonResult("Deleted Successfully!");
					}
			}
	}