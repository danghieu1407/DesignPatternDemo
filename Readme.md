# TIỂU LUẬN DESIGN PATTERN
## Giới thiệu về ứng dụng
Trong thời đại 4.0 hiện nay, việc order đồ ăn tại các cửa hàng bán đồ ăn nhanh đã qua quen thuộc với mọi người, vì thế việc ra đời app đặt đồ ăn nhanh đã trở nên quan trọng hơn. Nhóm chúng em chọn ra một cách để giới thiệu ứng dụng này là: "App đặt đồ ăn nhanh bá cháy". App này có nhiệm vụ là giúp người dùng có thể đặt đồ ăn nhanh vào cửa hàng bán đồ ăn nhanh. Để tối ưu hóa hệ thống, app đã sử dụng các design pattern mà chúng em đã từng học để thiết kế.
## Yêu cầu thư viện, tool hỗ trợ, database
- Thư viện sử dụng: 
- IDE: Visual Studio
- Database: SQL Server
## Cách khởi chạy
- Clone project từ link: [Github](https://github.com/danghieu1407/DesignPatternDemo.git) bằng cách mở cmd và nhập lệnh ```git clone https://github.com/danghieu1407/DesignPatternDemo.git``` về máy của bạn
- Mở folder ```DesignPatternDemo```, double click vào file ``` DesignPatternMidterm.sln``` và chọn mở bằng Visual Studio để mở project
- Đăng nhập vào SQL Server bằng chế độ ```SQL Server Authentication``` và import database từ file ```DemoDatabase.sql``` vào SQL Server
- Truy cập vào Visual Studio chọn ```Server Explorer``` và click chuột phải vào ```Data Connections``` chọn ```Add Connection```. Ở mục ```Log on to the server``` chọn ```SQL Server Authentication```, nhập vào các thông tin sau: ```User name ```,```Password``` và chọn tên database là ```DemoDatabase``` ở mục ```Server Name```.
- Nhấn ```F5``` để chạy project
## Các kiến thức về patterns và lý do ứng dụng patterns
### Các kiến thức về patterns
- **Singleton Pattern**: Là một trong những design pattern thuộc nhóm khởi tạo – Creational Patterns. Singleton thường được sử dụng khi chúng ta mong muốn chỉ có một đối tượng tồn tại duy nhất và có thể truy cập ở mọi lúc. Singleton đảm bảo rằng 1 class chỉ có 1 instance duy nhất tồn tại ở bất kỳ thời điểm nào class đó được request
- **Decorator Pattern**: Là một trong những Pattern thuộc nhóm cấu trúc (Structural Pattern). Nó cho phép người dùng thêm chức năng mới vào đối tượng hiện tại mà không muốn ảnh hưởng đến các đối tượng khác. Kiểu thiết kế này có cấu trúc hoạt động như một lớp bao bọc (wrap) cho lớp hiện có
- **MVC Pattern**: Là design pattern (mẫu thiết kế) phổ biến được sử dụng cho lớp trình bày (Presentation Layer). ASP.NET Core MVC tuân theo pattern này và nó là căn bản nhất để mọi thứ xoay quanh nó.MVC là một pattern mạnh mẽ và biểu lộ rõ ràng kỹ thuật chia để trị (separating of concerns). Kiến trúc MVC chia ứng dụng ra làm 3 phần độc lập và duy nhất. Bao gồm layer Model, View và Controller.Mỗi một layer trên có một trách nhiệm cụ thể. Model chứa dữ liệu. View tạo ra giao diện người dùng từ dữ liệu ở Model và tương tác với người dùng. View sẽ chuyển tương tác từ người dùng đến Controller, từ đó Controller sẽ build Model và cập nhật View
- **Command Pattern**: Là một trong 23 design pattern Gang of Four nổi tiếng. Command pattern thuộc nhóm các pattern hành vi: Đóng gói tất cả thông tin cần thiết vào 1 đối tượng để thực hiện hành động hay kích hoạt một sự kiện thực hiện sau đó. Các thông tin có thể bao gồm tên phương thức, các biến và giá trị cần thiết...hay đơn giản hơn đó là nó cho phép chuyển yêu cầu thành đối tượng độc lập, có thể được sử dụng để tham số hóa các đối tượng với các yêu cầu khác nhau như log, queue (undo/redo), transtraction
- **Template Method Pattern**: Là một trong những Pattern thuộc nhóm hành vi (Behavior Pattern). Pattern này nói rằng “Định nghĩa một bộ khung của một thuật toán trong một chức năng, chuyển giao việc thực hiện nó cho các lớp con.
### Lý do ứng dụng patterns
- **Singleton Pattern**: Khi sử dụng thì không nên để quá nhiều chức năng, cũng như tạo quá nhiều thực thể kết nối. Do đó Singleton Pattern áp dụng vào đây thì hợp lí, tất cả chức năng nên sử dụng chung một thực thể kết nối.
- **Decorator Pattern**: Decorator Pattern phù hợp với các việc có sự thay đổi, ở đây sự thay đổi là khi thêm Phần thêm hoặc Topping(tuỳ theo sở thích mà khách hàng lựa chọn có hoặc không, hay có thể là cửa hàng có thêm Phần thêm hoặc Topping khác) dù có thay đổi thì cũng không gây ảnh hưởng đến các lớp cũ .Trong bài, Decorator dùng để bổ sung một số thức ăn là Phần thêm, Topping cho món ăn hoặc thức uống. Ở đây, thực đơn chia làm 6 món, trong đó có 3 món được áp dụng Decorator vào đó là Gà rán và Trà sữa. Decorator được dụng để thêm các Topping cho món ăn hoặc thức uống(món ăn là Gà rán, thức thuốc là Trà sữa)
- **MVC Pattern**: Áp dụng MVC (Model - View - Controller) để dễ dàng thao tác dữ liệu giữa Frontend và Backend, dễ dàng hơn trong việc kiểm tra, phát hiện lỗi để đảm bảo chất lượng phần mềm có kết quả cao hơn
- **Command Pattern**: Dùng để quản lý các nút chọn món ở trong phần đặt món. Command Pattern trong bài này có nhiệm vụ làm cho một số nút cùng Enable, Disable, đổi về cùng một màu, ẩn nút và hiện nút. Điều này giúp cho viêc lập trình bớt phức tạp và không còn bị thiếu hoặc thừa câu lệnh về nút (ví dụ như quên Enable nút hoặc Disable nhầm nút).
- **Template Method Pattern**: Template Method Pattern là một quá trình bao gồm các bước theo thứ tự không thay đổi, và cũng có những bước thường xuyên thay đổi tuỳ vào nhu cầu. Do đó ở đây dùng để nêu ra một số phương thức chung dùng để chế biến các món ăn và việc thực hiện cụ thể các món ăn đó được nêu rõ ở mỗi món nêu cụ thể
## Chi tiết triển khai
## Thông tin người phát triển
- Nguyen Dang Hieu - 51900073
- Giang Vinh Dien - 51900035
- Dang Phuc Huy - 51900087
- Tran Gia Huy - 51900685