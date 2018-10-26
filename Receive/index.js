var amqp = require('amqplib/callback_api');

amqp.connect('amqp://yourUsername:yourPassword@host/yourVituarlhost', function(err, conn) {
  conn.createChannel(function(err, ch) {
    var queue = 'hello';

    ch.assertQueue(queue, {durable: false});
    console.log(" [*] Waiting for messages in %s. To exit press CTRL+C", queue);
    ch.consume(queue, function(msg) {
      console.log(" [x] Received %s", msg.content.toString());
    }, {noAck: true});
  });
});