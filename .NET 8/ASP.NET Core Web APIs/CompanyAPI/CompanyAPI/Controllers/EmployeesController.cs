using CompanyAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

// Namespaces
namespace CompanyAPI.Controllers
	{
		// Attributes
		[Route("api/[controller]")]
		[ApiController]

		// Classes
		public class EmployeesController : ControllerBase
			{
				// Fields
				private readonly IConfiguration _configuration;
				private readonly IWebHostEnvironment _env;

				// Constructors(Parameters)
				public EmployeesController(IConfiguration configuration, IWebHostEnvironment env)
					{
						_configuration = configuration;
						_env = env;
					}

				// [Attributes]
				// Methods(Parameters)
				[HttpGet]
				public JsonResult Get()
					{
						string query = @"SELECT EmployeeID,
						                        EmployeeName,
												Department,
												convert(varchar(10), DateOfJoining, 120) as DateOfJoining,
												PhotoFileName
									     FROM Employees
										";
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
				public JsonResult Post(Employees emp)
					{
						string query = @"INSERT INTO Employees(EmployeeName, Department, DateOfJoining, PhotoFileName)
						                 VALUES('"+ emp.EmployeeName +@"',
											    '"+ emp.Department +@"',
											    '"+ emp.DateOfJoining +@"',
											    '"+ emp.PhotoFileName +@"')
									    ";
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
				public JsonResult Put(Employees emp)
					{
						string query = @"UPDATE Employees SET
						                     EmployeeName = '"+ emp.EmployeeName +@"',
											 Department = '"+ emp.Department +@"',
											 DateOfJoining = '"+ emp.DateOfJoining +@"'
											 WHERE EmployeeID = "+ emp.EmployeeID +@"
									    ";
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
						string query = @"DELETE FROM Employees
						                 WHERE EmployeeID = " + ID + @"
										";
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

				[Route("SaveFile")]
				[HttpPost]
				public JsonResult SaveFile()
					{
						try
							{
								IFormCollection httpRequest = Request.Form;
								IFormFile postedFile = httpRequest.Files[0];
								string fileName = postedFile.FileName;
								string physicalPath = _env.ContentRootPath + "/Photos/" + fileName;

								using (FileStream stream = new FileStream(physicalPath, FileMode.Create))
									{
										postedFile.CopyTo(stream);
									}
								return new JsonResult(fileName);
							}
						catch (Exception)
							{
								return new JsonResult("anonymous.png");
							}
					}

				[Route("GetAllDepartmentNames")]
				public JsonResult GetAllDepartmentNames()
					{
						string query = @"SELECT DepartmentName FROM Departments
										";
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
			}
	}