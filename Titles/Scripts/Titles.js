//Be sure to alter the port numbers here if you change where the server listens!

function buildModal(data) {
    $("#movieModal").css("width", "100%");
    $("#movieModalTitle").html(data.Name);
    var genres = ""
    for (let i = 0; i < data.Genres.length - 1; i++) {
        genres += data.Genres[i].Name + ", ";
    }
    genres += data.Genres[data.Genres.length - 1].Name;
    $("#movieGenre").html(genres);
    var awards = "";
    if (data.Awards.length > 0) {
        for (let i = 0; i < data.Awards.length; i++) {
            awards += "<li>" + data.Awards[i].Name;
            awards += " (" + data.Awards[i].Year + ")</li>";
        }
    }
    else {
        awards = "No awards";
    }
    $("#awards").html(awards);
    $("#story").html(data.StoryLines[0].Description);
    $("#movieModal").modal("show");
}
function showAll() {
    let url = "http://localhost:55484/api/titles";
    $.ajax(url).then(function (data) {
        var out = "";
        for (let i = 0; i < data.length; i++) {
            out += "<tr>";
            out += "<td><a id='" + data[i].Id + "' class='movieLink' href='javascript:showOne(" + data[i].Id + ")'>" + data[i].Name + "</a></td>";
            out += "<td>" + data[i].ReleaseYear + "</td>";
            out += "</tr>";
        }
        $("#table-body").append(out);
    });
}

function showOne(id) {
    let url = "http://localhost:55484/api/titles/";
    $.ajax(url + id).then(function (data) {
        buildModal(data);
    });
}

$(document).ready(function () {
    $("#showAllBtn").click(function () {
        showAll();
        $("#results").toggle();
        if ($("#showAllBtn").text() === "Hide All") {
            $("#showAllBtn").text("Show All Movies");
        }
        else {
            $("#showAllBtn").text("Hide All");
        }
        $("#bottomHr").toggle();
    });
    $("#searchBtn").click(function () {
        let url = "http://localhost:55484/api/titles";
        let searchName = $("#searchName").val();
        $.ajax(url + "?name=" + encodeURIComponent(searchName)).then(function (data) {
            buildModal(data);
        });
    });
});