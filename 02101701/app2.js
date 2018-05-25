var express = require('express');
var app = express();

app.get('/', function(req,res){res.send('Hey hey')});

app.listen(3030, function(){console.log('server listening on port 3030')});