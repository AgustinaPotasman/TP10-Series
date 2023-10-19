﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp10_Series.Models;

namespace Tp10_Series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.listaSeries = BD.infoSeries();
        return View();
    }
    public List<Temporadas> DetallesAjaxTemporada (int IdSerie)
    {
        ViewBag.temp = BD.infoTemperadas(IdSerie);
        return ViewBag.temp;
    }

    public List<Actores> DetallesAjaxActores(int IdSerie)
    {
        ViewBag.act = BD.infoActores(IdSerie);
        return ViewBag.act;
    }
   public Series DetallesAjaxSerie(int IdSerie)
    {
        return BD.infoSerie(IdSerie);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}