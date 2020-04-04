$.get("/Productos/ListarProductos", function (data) {

    CrearListado(data);
});

var idioma_ES_datatable = {
    "sProcessing": "Procesando...",
    "sLengthMenu": "Mostrar _MENU_ registros",
    "sZeroRecords": "No se encontraron resultados",
    "sEmptyTable": "Ningún dato disponible en esta tabla =(",
    "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
    "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
    "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
    "sInfoPostFix": "",
    "sSearch": "Buscar:",
    "sUrl": "",
    "sInfoThousands": ",",
    "sLoadingRecords": "Cargando...",
    "oPaginate": {
        "sFirst": "Primero",
        "sLast": "Último",
        "sNext": "Siguiente",
        "sPrevious": "Anterior"
    },
    "oAria": {
        "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
        "sSortDescending": ": Activar para ordenar la columna de manera descendente"
    },
    "buttons": {
        "copy": "Copiar",
        "colvis": "Visibilidad"
    }
}

function CrearListado(data) {

    var contenido = "";

    contenido += "<table id='tabla-producto' class='table table-striped'>";
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
        contenido += "<td>" + parsearMoneda(data[i].PRECIO) + "</td>";
        contenido += "<td>" + data[i].STOCK + "</td>";
        contenido += "<td>" + parsearFecha(data[i].FECHA_VENCIMIENTO) + "</td>";
        contenido += "<td>" + parsearBoolean(data[i].ACTIVO) + "</td>";
        contenido += "</tr>";

    }

    contenido += "</tbody>";
    contenido += "</table>";

    document.getElementById("idTablaProducto").innerHTML = contenido;

    $("#tabla-producto").dataTable({searching:false});
};

function parsearBoolean(booleano) {

    if (booleano == true) {
        return "SI";
    } else { return "NO"; }
};

function parsearMoneda(decimal) {

    return new Intl.NumberFormat("es-AR", { style: "currency", currency: "ARS" }).format(decimal);
};

function parsearFecha(fecha) {


    if (fecha != null) {

        moment.locale("es");

        return moment(fecha).format('L');

    } else {

        return "No Aplica"
    }


};


var boton = document.getElementById("btnBuscar");

var txtBusqueda = document.getElementById("txtBusqueda");

txtBusqueda.onkeyup = function () {


    alert(txtBusqueda);

    $.get("/Productos/BuscarPorDescripcion/?idParametro=" + txtBusqueda, function (data) {

        CrearListado(data);
    })
};

boton.onclick = function () {


    var busqueda = document.getElementById("txtBusqueda").value;

    alert(busqueda);

    $.get("/Productos/BuscarPorDescripcion/?idParametro=" + busqueda, function (data) {

        CrearListado(data);
    })
}
