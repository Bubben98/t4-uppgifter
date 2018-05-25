var http = require('http');
var url = require('url');

var server = http.createServer(function(req,res){
    res.writeHead(200, {"Content-Type" : "text/plain"});
    res.write("Hey");
    res.write(req.url);
    var q = url.parse(req.url, true).query;
    res.write("du angav " + q.anka);
    res.end("Hello Universe");
});

server.listen(6767);
