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
          $("#Nombre").html("Series");
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
            let aux1= '';
            $("#Nombre").html("Actores");
          
          for(const NombreAct of response)
            {
              aux1+= "<p>"+ NombreAct.nombre + "</p>";
            }
            $("#info").html(aux1);
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
          
            $("#Nombre").html("Temporadas")
            for(const variable of response)
            {
                texto += "Numero de la temporada:  " +  variable.numeroTemporada + "<br>";
                texto += "Titulo de la temporada:  " +  variable.tituloTemporada + "<br>";
                
                texto+= "</p>";
            }
            
            
            $("#info").html(texto);
          
        }
      }
    )
  }