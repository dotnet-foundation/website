const fs = require('fs');

module.exports = function (context, req) {
    var filepath = __dirname + '/index.rss'
    fs.readFile(filepath, 'utf8', function (err, content) {
        if (err) {
            context.log.error(err);
            context.done(err);
        }
        
        context.res = {
        status: 200,
        headers: {
              'Content-Type': 'application/rss+xml'
            },
        body: content
      };
        context.done();
    });
}