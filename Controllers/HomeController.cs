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
    public List<Temporadas> DetallesAjaxTemporada (int IdTemporada)
    {
        List<Temporadas> temp = BD.infoTemperadas(IdTemporada);
        return temp;
    }

    public List<Actores> DetallesAjaxActores(int IdActor)
    {
        List<Actores> act = BD.infoActores(IdActor);
        return act;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}