alert("no me sale mas todavia");


$.get("/Productos/ListarProductos", function (data) {

    CrearListado(data);
}
);

function CrearListado(data) {

   

    var contenido = "";


    contenido += "<table class='table table-striped table-dark'>";
    contenido += "<thead>";
    contenido += "<tr>";
    contenido += "<th>ID</th>";
    contenido += "<th>DESCRIPCION</th>";
    contenido += "<th>PRECIO</th>";
    contenido += "<th>STOCK</th>";
    contenido += "<th>FECHA_VENCIMIENTO</th>"
    contenido += "<th>ACTIVO</th>";
    contenido += "</tr>";
    contenido += "</thead>";
    contenido += "<tbody>";
    
    for (var i = 0; i < data.length; i++) {

        contenido += "<tr>";
        contenido += "<td>" + data[i].ID + "</td>";
        contenido += "<td>" + data[i].DESCRIPCION + "</td>";
        contenido += "<td>" + data[i].PRECIO + "</td>";
        contenido += "<td>" + data[i].STOCK + "</td>";
        contenido += "<td>" + data[i].FECHA_VENCIMIENTO + "</td>";
        contenido += "<td>" + data[i].ACTIVO + "</td>";
        contenido += "</tr>";

    }
       
    contenido += "</tbody>";
    contenido += "</table>";

    document.getElementById("tabla-productos").innerHTML = contenido;

};