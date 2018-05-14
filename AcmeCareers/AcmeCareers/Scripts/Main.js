

$(document).ready(function () {
    $.ajax({
        method: "POST",
        url: "../jobinfo/Details"//,
        //data: { name: "John", location: "Boston" }
    }).done(function (data) {
        fillJobTable(jQuery.parseJSON(data));
    });
});


function fillJobTable(data) {
    var html = "";
    var firstUpper = "";
    html += "<tr id = 'LoadJobInfoData' >";
    //$.each(data[0], function (key, value) {
    //    firstUpper = key.toString().toLowerCase().replace(/\b[a-z]/g, function (letter) {
    //        return letter.toUpperCase();
    //    });
    //    html += "<th>" + firstUpper +"</th>";
    //});
    html += "</tr>";
    for (var i = 0; i < data.length; i++) {
        html += '<tr><td>' + data[i].title + '</td><td>' + data[i].location + '</td><td>' + data[i].contactPerson + '</td></tr>';
    }
    $("#JobInfoTable").append(html);
}
function onBegin() {
    $("#submitBtn").hide();
}
function onComplete() {
    $("#submitBtn").show();
}

