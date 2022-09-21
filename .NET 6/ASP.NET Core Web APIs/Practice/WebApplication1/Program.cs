namespace WebApplication1
	{
		public class Program
			{
				public static void Main(string[] args)
					{
WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);  // declaring a nullable type of WebApplicationBuilder class

builder.Services.AddControllers();  // Add services to the container.

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
}
}
}