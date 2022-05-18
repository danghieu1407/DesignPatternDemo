<div align="center">
<h3> TỔNG LIÊN ĐOÀN LAO ĐỘNG VIỆT NAM </h3>
<h3> TRƯỜNG ĐẠI HỌC TÔN ĐỨC THẮNG </h3>
<h3> KHOA CÔNG NGHỆ THÔNG TIN </h3>
  
![image](https://user-images.githubusercontent.com/80830264/169096132-bc4e6152-a77c-4612-b73d-81d4104ba950.png)
  <br>
  <br>
  <br>
  <h3> TIỂU LUẬN GIỮA KÌ MÔN DESIGN PATTERN </h3>
  <h2> TÌM HIỂU VỀ PATTERNS </h2>
  <br>
</div>
<div align="right">
  <br>
  <br>
  <br>
  <h3> <i> Người hướng dẫn </i>: ĐẶNG HUỲNH TRUNG TÍN </h3>
  <h3>
   <i> Người thực hiện </i>:  <b> ĐẶNG PHÚC HUY – 51900087 </b> </h3>
  
  <h3> GIANG VINH DIỄN – 51900035 </h3>
 <h3> NGUYỄN ĐẶNG HIẾU – 51900073 </h3>
 <h3> TRẦN GIA HUY - 51900685 </h3>
 <h3> Lớp       :    19050201 </h3>
 <h3> 19050202 </h3>
   <h3> 19050281 </h3>
 <h3> Khoá     :    23
  </h3>
  </div>
  <div  align="center">
  <h3> THÀNH PHỐ HỒ CHÍ MINH, NĂM 2022  </h3>
  <br>
  <h3> LỜI CẢM ƠN </h3>
</div>
<div style="text-indent: 30px">
    Đầu tiên, chúng em xin gửi lời cảm ơn chân thành đến Thầy Đặng Huỳnh Trung Tín. Thầy là người hỗ trợ và hướng dẫn tận tình cho chúng em trong quá trình nghiên cứu, tìm hiểu để hoàn thành bài tiểu luận giữa kỳ môn Design Pattern. Tiếp theo, chúng em xin gửi lời cảm ơn đến khoa Công Nghệ Thông Tin trường Đại học Tôn Đức Thắng vì đã tạo điều kiện cho chúng em được học tập và nghiên cứu môn học này. Khoa đã luôn sẵn sàng chia sẻ các kiến thức bổ ích cũng như kinh nghiệm tham khảo tài liệu, giúp ích không chỉ cho việc thực hiện và hoàn thành đề tài nghiên cứu mà còn giúp ích cho việc học tập và rèn luyện trong quá trình thực hành tại trường Đại học Tôn Đức Thắng nói chung. Cuối cùng, trong quá tình hoàn tất đề tài của mình nhờ vào sự hướng dẫn, giúp đỡ và những kiến thức học hỏi được từ Quý thầy cô. Do giới hạn về mặt kiến thức và khả năng lý luận nên chúng em còn nhiều thiếu sót, kính mong sự chỉ dẫn và đóng góp của Quý thầy cô giáo để bài nghiên cứu của chúng em được hoàn thiện hơn. Hơn nữa, nhờ những góp ý từ thầy cô và bạn bè, chúng em sẽ hoàn thành tốt hơn ở các bài nghiên cứu khác sau này. Chúng em mong Quý thầy cô và bạn bè sẽ luôn quan tâm và hỗ trợ chúng em và chúc Quý thầy cô và các bạn luôn tràn đầy sức khỏe. 
CHÚNG EM XIN CHÂN THÀNH CẢM ƠN!. 
<br>
  <br>
 </div>

# MỤC LỤC
[I. Giới thiệu về ứng dụng](#I)  

[II. Vấn đề đặt ra khi không áp dụng Design Pattern vào ứng dụng](#II)  

[III. Yêu cầu thư viện, tool hỗ trợ, database](#III)  

[IV. Cách khởi chạy](#IV)  

[V. Các kiến thức về patterns và lý do ứng dụng patterns](#V) 

[5.1 Các kiến thức về patterns](#51)  

[5.2 Lý do ứng dụng patterns](#52)  

[VI. Chi tiết thông tin ứng dụng pattern kèm theo class diagram](#VI) 

[6.1 Chi tiết thông tin ứng dụng](#61)  

[6.2 Usecase Diagram](#62)  

[6.3 Class Diagram](#63)  

[VII. Kết quả triển khai thực tế ](#VII) 

[VIII. Thông tin người phát triển ](#VIII) 

# DANH MỤC HÌNH
[Hình 1. Tạo kết nối database](#1)  

[Hình 2. Lấy connection String](#2)  

[Hình 3. Sơ đồ Usecase](#3)  

[Hình 4. Sơ đồ lớp](#4)  

[Hình 5. Trang đăng nhập](#5)

[Hình 6. Trang đăng ký](#6) 

[Hình 7. Trang chủ với role Admin](#7) 

[Hình 8. Trang chủ với role Staff](#8) 

[Hình 9. Trang chủ với role Customer](#9) 

[Hình 10. Trang giao diện đặt món ăn](#10) 

[Hình 11. Trang giao diện đặt món ăn hoàn tất](#11)

[Hình 12. Trang giao diện khu bếp](#12) 

[Hình 13. Trang giao diện chế biến món ăn hoàn tất](#13) 

[Hình 14. Trang giao diện quản lý tài khoản](#14) 


<a name = "I"></a>
## Giới thiệu về ứng dụng
Bumba là thương hiệu trà sữa có nguồn gốc thương hiệu tại Việt Nam. Nguyên vật liệu được kiểm duyệt và nhập khẩu từ Singapore và Đài Loan. Là thương hiệu đại
diện cho sản phẩm chất lượng và giá thành hợp lí. Cửa hàng đầu tiên Bumba ra đời vào năm 2012, mang phong cách loại hình takeaway - trà sữa mang đi, mô hình được ưa chuộng nhất lúc đó. Năm 2013 chính thức thành lập công ty CP TMDV Chào Ngày Mới và đến 2017 công ty nhận vốn góp từ công ty TNHH DIOS Investment Vina - một quỹ đầu tư trực tiếp vốn 100% từ Hàn Quốc. Trước đó bằng hình thức chuyển nhượng thương hiệu, Bumba đã thành công với iệc sỡ hữu 33 cửa hàng trên toàn quốc chủ yếu ở các thành phố lớn như TP. Hồ Chí inh, Đà Nẵng, Hà Nội. Sau khi kết hợp cùng công ty DIOS, Bumba chính thức mở rộng thêm 11 cửa hàng ở các tỉnh thành: Quảng Ninh, Bình Dương, Vũng Tàu..Với châm ngôn tuyệt đối không sử dụng nguyên liệu không rõ nguồn gốc xuất xứ, trà sữa Bumba tự hào mang lại cho khách hàng những sản phẩm chất lượng nhất. Buba luôn cảm kích về sự tin dùng và dễ thương của quý khách hàng. Một trong những điều làm nên thương hiệu của Bumbap là việc order có thể diễn ra một cách trực tuyến ,nhanh gọn, an toàn và tiện lợi nhờ vào app quản lý đặt đồ ăn nhanh do đội ngũ dev gồm 4 thành viên phát triển.
<a name = "II"></a>
## Vấn đề đặt ra khi không áp dụng Design Pattern vào ứng dụng
<a name = "III"></a>
## Yêu cầu thư viện, tool hỗ trợ, database
- Thư viện sử dụng: System.Text.RegularExpressions, System.Data
- IDE: Visual Studio, Microsoft SQL Server Management Studio
- Database: SQL
<a name = "IV"></a>
## Cách khởi chạy
- Clone project từ link: [Github](https://github.com/danghieu1407/DesignPatternDemo.git) bằng cách mở cmd và nhập lệnh ```git clone https://github.com/danghieu1407/DesignPatternDemo.git``` về máy của bạn.
- Mở folder ```DesignPatternDemo```, double click vào file ``` DesignPatternMidterm.sln``` và chọn mở bằng Visual Studio để mở project.
- Đăng nhập vào SQL Server bằng chế độ ```SQL Server Authentication``` và import database từ file ```DemoDatabase.sql``` vào SQL Server.
- Truy cập vào Visual Studio chọn ```Server Explorer``` và click chuột phải vào ```Data Connections``` chọn ```Add Connection```. Ở mục ```Log on to the server``` chọn ```SQL Server Authentication```, nhập vào các thông tin sau: ```User name ```,```Password``` và nhập tên server ở mục ```Server Name```, chọn tên database là ```DemoDatabase``` ở mục ```Select or enter a database name```.
<a name = "1"></a>
  ![SQLConnect](https://user-images.githubusercontent.com/80830264/165013246-ab60d127-9351-421d-a6ad-9d6f08573c89.jpg)

- Ở phần Properties, chọn và copy Connection String.
<a name = "2"></a>
 ![ConnecttionString](https://user-images.githubusercontent.com/80830264/168459178-a0a07334-6a50-4ccd-99dd-efc162b59f7b.jpg)

- Đổi ```Connection String``` ở file ./ConfigurationDTB/DatabaseProvide.cs dòng số 13.
- Nhấn ```F5``` để chạy project.
<a name = "V"></a>
## Các kiến thức về patterns và lý do ứng dụng patterns
<a name = "51"></a>
### Các kiến thức về patterns
- **Singleton Pattern**: Là một trong những design pattern thuộc nhóm khởi tạo – Creational Patterns. Singleton thường được sử dụng khi chúng ta mong muốn chỉ có một đối tượng tồn tại duy nhất và có thể truy cập ở mọi lúc. Singleton đảm bảo rằng 1 class chỉ có 1 instance duy nhất tồn tại ở bất kỳ thời điểm nào class đó được request.
- **Decorator Pattern**: Là một trong những Pattern thuộc nhóm cấu trúc (Structural Pattern). Nó cho phép người dùng thêm chức năng mới vào đối tượng hiện tại mà không muốn ảnh hưởng đến các đối tượng khác. Kiểu thiết kế này có cấu trúc hoạt động như một lớp bao bọc (wrap) cho lớp hiện có.
- **MVC Pattern**: Là design pattern (mẫu thiết kế) phổ biến được sử dụng cho lớp trình bày (Presentation Layer). ASP.NET Core MVC tuân theo pattern này và nó là căn bản nhất để mọi thứ xoay quanh nó.MVC là một pattern mạnh mẽ và biểu lộ rõ ràng kỹ thuật chia để trị (separating of concerns). Kiến trúc MVC chia ứng dụng ra làm 3 phần độc lập và duy nhất. Bao gồm layer Model, View và Controller.Mỗi một layer trên có một trách nhiệm cụ thể. Model chứa dữ liệu. View tạo ra giao diện người dùng từ dữ liệu ở Model và tương tác với người dùng. View sẽ chuyển tương tác từ người dùng đến Controller, từ đó Controller sẽ build Model và cập nhật View.
- **Command Pattern**: Là một trong 23 design pattern Gang of Four nổi tiếng. Command pattern thuộc nhóm các pattern hành vi: Đóng gói tất cả thông tin cần thiết vào 1 đối tượng để thực hiện hành động hay kích hoạt một sự kiện thực hiện sau đó. Các thông tin có thể bao gồm tên phương thức, các biến và giá trị cần thiết...hay đơn giản hơn đó là nó cho phép chuyển yêu cầu thành đối tượng độc lập, có thể được sử dụng để tham số hóa các đối tượng với các yêu cầu khác nhau như log, queue (undo/redo), transtraction.
- **Template Method Pattern**: Là một trong những Pattern thuộc nhóm hành vi (Behavior Pattern). Pattern này nói rằng “Định nghĩa một bộ khung của một thuật toán trong một chức năng, chuyển giao việc thực hiện nó cho các lớp con.
<a name = "52"></a>
### Lý do ứng dụng patterns
- **Singleton Pattern**: Khi sử dụng thì không nên để quá nhiều chức năng, cũng như tạo quá nhiều thực thể kết nối. Do đó Singleton Pattern áp dụng vào đây thì hợp lí, tất cả chức năng nên sử dụng chung một thực thể kết nối.
- **Decorator Pattern**: Decorator Pattern phù hợp với các việc có sự thay đổi, ở đây sự thay đổi là khi thêm Phần thêm hoặc Topping(tuỳ theo sở thích mà khách hàng lựa chọn có hoặc không, hay có thể là cửa hàng có thêm Phần thêm hoặc Topping khác) dù có thay đổi thì cũng không gây ảnh hưởng đến các lớp cũ .Trong bài, Decorator dùng để bổ sung một số thức ăn là Phần thêm, Topping cho món ăn hoặc thức uống. Ở đây, thực đơn chia làm 6 món, trong đó có 3 món được áp dụng Decorator vào đó là Gà rán và Trà sữa. Decorator được dụng để thêm các Topping cho món ăn hoặc thức uống(món ăn là Gà rán, thức uống là Trà sữa).
- **MVC Pattern**: Áp dụng MVC (Model - View - Controller) để dễ dàng thao tác dữ liệu giữa Frontend và Backend, dễ dàng hơn trong việc kiểm tra, phát hiện lỗi để đảm bảo chất lượng phần mềm có kết quả cao hơn.
- **Command Pattern**: Dùng để quản lý các nút chọn món ở trong phần đặt món. Command Pattern trong bài này có nhiệm vụ làm cho một số nút cùng Enable, Disable, đổi về cùng một màu, ẩn nút và hiện nút. Điều này giúp cho viêc lập trình bớt phức tạp và không còn bị thiếu hoặc thừa câu lệnh về nút (ví dụ như quên Enable nút hoặc Disable nhầm nút).
- **Template Method Pattern**: Template Method Pattern là một quá trình bao gồm các bước theo thứ tự không thay đổi, và cũng có những bước thường xuyên thay đổi tuỳ vào nhu cầu. Do đó ở đây dùng để nêu ra một số phương thức chung dùng để chế biến các món ăn và việc thực hiện cụ thể các món ăn đó được nêu rõ ở mỗi món nêu cụ thể.
<a name = "VI"></a>
## Chi tiết thông tin ứng dụng pattern kèm theo class diagram
<a name = "61"></a>
### Chi tiết thông tin ứng dụng
Ứng dụng đặt đồ ăn "BÁ CHÁY" gồm cái 3 tác nhân chính là người dùng, nhân viên và admin
- Người dùng: Có thể đăng nhập, đăng ký, quên mật khẩu và order món ăn.
- Nhân viên: Có các chức năng của người dùng và có thể chế biến món ăn.
- Admin: Có tất cả chức năng của người dùng và nhân viên và có thêm chức năng quản lý tài khoản (CURD tài khoản).
Account dùng trong ứng dụng:
- Account Admin: Email: PH123@gmail.com - Password: 123456
- Account Staff: Email: GD123@gmail.com - Password: GD1234
- Account Customer: Email: DH123@gmail.com - Password: DH1234
<a name = "62"></a>
### Usecase Diagram
<a name = "3"></a>
![UseCase](https://user-images.githubusercontent.com/102457174/165016879-e82210a3-f2c8-4e8a-a28c-533107a07cc2.png)
<a name = "63"></a>

### Class Diagram
<a name = "4"></a>
![dp drawio](https://user-images.githubusercontent.com/74227813/168469843-aebdeed9-4cc7-4967-8035-6dbcd68dc041.png)
<a name = "VII"></a>
## Kết quả triển khai thực tế 
### Trang đăng nhập ứng dụng
Người dùng nhập username và password để đăng nhập vào hệ thống, họ cũng có thể chọn nhớ tài khoản cho lần đăng nhập tiếp theo mà không cần nhập lại tài khoản. Nếu người dùng quên mật khẩu thì có thể chọn nút quên mật khẩu và nhập thông tin cần thiết để lấy lại mất khẩu.
<a name = "5"></a>
![LoginScreen](https://user-images.githubusercontent.com/80830264/164934048-02c294e3-1abe-4732-9ce3-743635144b06.jpg)

### Trang đăng ký ứng dụng
Người dùng nhập các thông tin cần thiết để đăng ký tài khoản nhằm mục đích sử dụng hệ thống.
<a name = "6"></a>
![Register](https://user-images.githubusercontent.com/80830264/164934091-e3123603-9222-43f8-8098-20134c01c06a.jpg)

### Trang chủ ứng dụng
Hiển thị các chức năng mà hệ thống có như Đặt món, Quản lí tài khoản, Khu bếp.
### Với role Admin
<a name = "7"></a>
![MainScreenAdmin](https://user-images.githubusercontent.com/80830264/164915720-87de9768-d295-4f0a-acb3-3eec1d378dbe.jpg)

### Với role Staff
<a name = "8"></a>
![MainScreenStaff](https://user-images.githubusercontent.com/80830264/164915730-1317c08e-b34f-40a5-ad90-500b3e9e2894.jpg)

### Với role Customer
<a name = "9"></a>
![MainScreenCustomer](https://user-images.githubusercontent.com/80830264/164915740-0e6f3ab2-dfab-40c5-abe0-1bf74deb4604.jpg)

### Giao diện đặt món ăn
Sau khi chọn chức năng Đặt món sẽ có giao diện như hình trên, tại đây có thể chọn các thức ăn hoặc thức uống có trên màn hình, có thể chọn thêm Phần thêm hoặc Topping. Có thể nhập số lượng món ăn cần mua, hiển thị tống giá tiền cần phải thanh toán.
<a name = "10"></a>
![OrderScreen](https://user-images.githubusercontent.com/80830264/164916232-43e494de-2ab1-4bfd-89cb-295529dbde57.jpg)

Say khi chọn món ấn đặt hàng. Hệ thống sẽ hiện lên số tiền bạn cần thanh toàn và yêu cầu bạn chuẩn bị đầy đủ số tiền để trả cho shipper.
<a name = "11"></a>
![OrderScreenComplete](https://user-images.githubusercontent.com/80830264/168463175-51104780-4ed8-47a4-86ef-72947e36139d.jpg)

### Giao diện chế biến món ăn ở Khu bếp
Khi chọn Khu bếp sẽ hiển thị giao diện chọn các món ăn chế biến. Khi chọn vào món ăn thì sẽ hiển thị cách thức thực hiện món ăn đó.
<a name = "12"></a>
![KitchenScreen](https://user-images.githubusercontent.com/80830264/164916407-ab2c8df8-f93a-45d9-a5b3-688bf0e89f98.jpg)

Sau khi chọn món ăn cần chế biến và nhấn chế biến. Hệ thống sẽ tiến hành chế biến món ăn.
<a name = "13"></a>
![KitchenScreenSuccess](https://user-images.githubusercontent.com/80830264/164916452-71de1428-f336-41ec-9620-20c2a5d01a72.jpg)

### Giao diện quản lý tài khoản
Đây là giao diện quản lý tài khoản cho admin. Tại đây admin có thể có các thao tác như Thêm account mới, Sửa thông tin account, xóa account.
<a name = "14"></a>
![ManageAccount](https://user-images.githubusercontent.com/80830264/164917023-fd82c105-b89a-4cd4-9c30-9390a88f3a59.jpg)
<a name = "VIII"></a>
## Thông tin người phát triển
- Nguyen Dang Hieu - 51900073
- Giang Vinh Dien - 51900035
- Dang Phuc Huy - 51900087
- Tran Gia Huy - 51900685

## PHÂN CÔNG CÔNG VIỆC
| STT | Họ và Tên | MSSV | CÔNG VIỆC | MỨC ĐỘ HOÀN THÀNH |
| ---- | -------- | ----- | ------- | ------------------|
| 1 | Đặng Phúc Huy | 51900087 | Tạo menu và áp dụng Decorator Pattern cho gà rán và trà sũa, viết README.md | 100% |
| ---- | -------- | ----- | ------- | ------------------|
| 2 | Giang Vinh Diễn | 51900035 | Command Pattern các nút món ăn, viết README.md | 100% |
| ---- | -------- | ----- | ------- | ------------------|
| 3 | Nguyễn Đặng Hiếu | 51900073 | MVC Pattern & Singleton Pattern, viết README.md | 100% |
| ---- | -------- | ----- | ------- | ------------------|
| 4 | Trần Gia Huy | 51900685 | Template Method pattern trong nhà bếp viết, README.md | 100% |
