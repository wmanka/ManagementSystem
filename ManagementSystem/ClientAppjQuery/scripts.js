var list = {};

$(document).ready(function(){
    $.get("http://localhost:57977/api/reservations", function (data, status) {
        list = data;
        constructTable('#table');
    });

});

function constructTable(selector) {
    var cols = Headers(list, selector);

    for (var i = 0; i < list.length; i++) {
        var row = $('<tr/>');
        for (var colIndex = 0; colIndex < cols.length; colIndex++) {
            var val = list[i][cols[colIndex]];

            if (val == null) val = "";

            if (Array.isArray(val)) {
                var guests = "";
                for (let x of val) {
                    guests += (x.Name).concat(" ", x.Surname);
                }
                val = guests;
            }
            row.append($('<td/>').html(val));
        }

        $(selector).append(row);
    }
}

function Headers(list, selector) {
    var columns = [];
    var header = $('<tr/>');

    for (var i = 0; i < list.length; i++) {
        var row = list[i];

        for (var k in row) {
            if ($.inArray(k, columns) == -1) {
                columns.push(k);

                header.append($('<th/>').html(k));
            }
        }
    }

    $(selector).append(header);
    return columns;
}