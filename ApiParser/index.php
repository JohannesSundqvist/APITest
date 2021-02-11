<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8" />
    <link hreF="style.css" rel="stylesheet" />
    <title>API Parser</title>

    <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
  </head>
  <body>
    <h1>Posts</h1>
    <div id="allPosts"></div>

    <h1>Users</h1>
    <div id="allUsers"></div>

    <input type="text" id="postOrUser" placeholder="Search by user or post title" />
    <button type="button" id="refreshAll">Refresh All</button>
    <script src="script.js"></script>
  </body>
</html>
