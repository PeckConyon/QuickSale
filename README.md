# QuickSale
Sales app for easy and fast ordering - ASP.NET MVC - CORE 2.1


### Create Database using Sql Server 

```Database name - "YourDatabaseName"```

### Change Coonection String According Your Sql Server

### change appsettings.json file'

```var connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";```
```services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(connectionString));```

### Add migreation cmd using package manager console 

```Add-Migration InitialCreate```
```Update-Database```

### Run Application 