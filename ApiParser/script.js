$(document).on("click", "#refreshAll", function() {
      $.ajax({
        type: "get",
        url: "http://localhost:5000/api/getposts/" + $("#postOrUser").val(),
        success: function(r) {
          var msg = "";
          if(Array.isArray(r)) {
            for(var i = 0; i < r.length; i++) {
                msg += "<h3>" + r[i].title + "</h3>";
                msg += "<p>" + r[i].content + "</p>";
                msg += "<p>by " + r[i].author + "</p>";
            }
          }
          else {
            msg += "<h3>" + r.title + "</h3>";
            msg += "<p>" + r.content + "</p>";
            msg += "<p>by " + r.author + "</p>";
          }
          document.getElementById("allPosts").innerHTML = msg;
        },
        error: function(r) {
          console.log(r);
        }
      });
      $.ajax({
        type: "get",
        url: "http://localhost:5000/api/getusers/" + $("#postOrUser").val(),
        success: function(r) {
          var msg = "";
          if(Array.isArray(r)) {
            for(var i = 0; i < r.length; i++) {
                msg += "<h3>" + r[i].username + "</h3>";
            }
          }
          else {
            msg += "<h3>" + r.username + "</h3>";
          }
          document.getElementById("allUsers").innerHTML = msg;
        },
        error: function(r) {
          console.log(r);
        }
      });
});

$("#postOrUser").on("input", function() {
  var val = $("#postOrUser").val();
  if(val.length > 0)
    $("#refreshAll").html("Search for " + val);
  else
    $("#refreshAll").html("Refresh all");
});
