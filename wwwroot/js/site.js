// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


  function infoSeries(IdS)
  {
    $.ajax
    (
      {
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/DetallesAjaxSerie',
        data:{IdSerie : IdS},
        success: 
        function(response)
        {
          
            let aux = '';
          aux += `<img src="${response.imagenSerie}">`
          aux += `<p>${response.nombre}</p>`
          aux += `<p>${response.añoInicio}</p>`
          aux += `<p>${response.sinopsis}</p>`
          $("#info").html(aux);
        }
    
      }
    )
  }

  function infoActores(IdS)
  {
    $.ajax
    (
      {
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/DetallesAjaxActores',
        data:{IdSerie : IdS},
        success: 
        function(response)
        {
            console.log(response)
            let texto="";
            $("#info").html("");
            for(const qsy of response)
            {
                texto+=`<p>${qsy.nombre}</p>`
            }
            $("#infoactores").html(texto);
        }
      }
    )
  }

  function infoTemporadas(IdS)
  {
    $.ajax
    (
      {
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/DetallesAjaxTemporada',
        data:{IdSerie : IdS},
        success: 
        function(response)
        {
            let texto="<p>";
            console.log(response);
            let i = 1;
            $("#Nombre").html("Temporadas")
            response.foreach(obj =>{
                texto += "Numero de la temporada:  " + i + obj.numeroTemporada + "<br>";
                texto += "Titulo de la temporada:  " + i + obj.tituloTemporada + "<br>";
                i= i +1;
            })
            texto+= "</p>";
            
            $("#info").html(texto);
          
        }
      }
    )
  }