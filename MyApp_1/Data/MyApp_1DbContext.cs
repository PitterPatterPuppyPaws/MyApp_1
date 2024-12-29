using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApp_1.Models;


namespace MyApp_1.Data;

public class MyApp_1DbContext: DbContext
{
    public MyApp_1DbContext(DbContextOptions<MyApp_1DbContext> options)
        : base(options)
    {}

    public DbSet<MyApp_1.Models.FirstModel> FirstModel { get; set; }
}