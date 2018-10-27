Source code demo cho bài viết xây dựng Microservices với RabbitMQ
Hướng dẫn chạy demo

**Bước 1. Chạy service Receive trên môi trường NodeJs**
  * Command lệnh tới đường dần *cd duongdantrenmay/TutorialRabbitMQ/Receive*
  * Trong file index.js chỉnh sửa lại đường dần tới server RabbitMQ của bạn (*amqp://yourUsername:yourPassword@host/yourVituarlhost*)
  * Command lệnh *npm i* để cài đặt node_modules
  * Command lệnh *node index.js* (Lưu ý: Bạn cần cài môi trường NodeJs trước khi chạy service)
  * Trên màn hình sẽ hiện ra thông báo: [*] Waiting for messages in %s. To exit press CTRL+C

**Bước 2. Chạy service Sender trên môi trường Windown**
  * Mở dự án tại địa chỉ * duongdantrenmay/TutorialRabbitMQ/Sender
  * Sửa file Program.js thay đường dần kết nối tới server RabbitMQ của bạn (dòng code 15)
  * Start dự án 
  * *Lưu ý: Nếu máy tính của bạn không thể cài visual studio, bạn có thể chạy dự án SenderJS trên môi trường NodeJs với các bước tương tự service Receive*

**Bước 3. Kiểm tra kết quả**
  * Trên màn hình console log của service Receive bạn sẽ thấy hiển thị thêm dòng: [*] Received Hello World!