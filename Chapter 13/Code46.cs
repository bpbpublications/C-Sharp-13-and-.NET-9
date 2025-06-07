using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyEfCoreApp.DbContexts;
using MyEfCoreApp.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Mvc;

namespace MyEfCoreApp.Controllers;
public class ProductsController(ApplicationDbContext context, IHttpClientFactory clientFactory) : Controller
{ ...
