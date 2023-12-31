Đề tài: **QUẢN LÝ CÔNG DÂN THÀNH PHỐ**

**Môn học: Lập trình trên Windows**



**MỤC LỤC**

[LỜI NÓI ĐẦU**	1](#_toc135002217)

[**PHẦN NỘI DUNG**	2](#_toc135002218)

[**2. Giao diện thiết kế hệ thống**	2](#_toc135002220)

[**2.1 Form đăng nhập**	2](#_toc135002221)

[**2.2 Đăng nhập với vai trò công dân**	3](#_toc135002222)

[**2.2.1 Thông tin cá nhân**	3](#_toc135002223)

[**2.2.2 Hộ khẩu**	3](#_toc135002224)

[**2.3 Đăng nhập với vai trò quản lý**	4](#_toc135002225)

[**2.3.1 Thông tin công dân**	4](#_toc135002226)

[**2.3.2 Căn cước công dân**	6](#_toc135002227)

[**2.3.3 Khai sinh**	6](#_toc135002228)

[**2.3.4 Khai tử**	8](#_toc135002229)

[**2.3.5 Kết hôn**	10](#_toc135002230)

[**2.3.6 Ly hôn**	12](#_toc135002231)

[**2.3.7 Hộ khẩu**	14](#_toc135002232)

[**2.3.8 Tạm trú / tạm vắng**	14](#_toc135002233)

[**2.3.9 Thuế**	16](#_toc135002234)

[**3. Quá trình thực hiện đồ án**	16](#_toc135002235)

[**4. Framework và công nghệ kỹ thuật dùng trong đồ án:**	17](#_toc135002236)

[**5. Tài khoản login**	17](#_toc135002237)

[**TÀI LIỆU THAM KHẢO**	18](#_toc135002238)
**




# <a name="_toc134582475"></a><a name="_toc134828442"></a><a name="_toc135002217"></a>**LỜI NÓI ĐẦU**
Ở bài đồ án trong môn học Lập trình trên Windows lần này, tôi lựa chọn thực hiện xây dựng chương trình ứng dụng “Quản lý công dân thành phố”. Chương trình được thực hiện có áp dụng kiến thức cơ bản của mô hình ba lớp như tạo ra các lớp đối tượng là DAO (Data Access Object) dùng để gọi thực thi hàm từ SQL lên C# và DTO (Data Transfer Object) là các class đối tượng dùng để lưu giá trị của một dữ liệu được chuyển hóa từ dữ liệu từ cơ sở dữ liệu trong SQL để thực hiện và xử lý các nghiệp vụ trên form. Ngoài ra, chương trình còn được hiện với hai phiên bản là Entity và ADO.net.

Chương trình “Quản lý công dân thành phố” này có các nghiệp vụ cơ bản sau đây: quản lý thông tin công dân; căn cước công dân, khai sinh, khai tử, kết hôn, ly hôn, hộ khẩu, tạm trú – tạm vắng và thuế… Ứng dụng có hai đối tượng người dùng, cụ thể là công dân và người quản lý. Mỗi công dân khi được cấp một tài khoản để đăng nhập vào ứng dụng, tùy vào loại tài khoản đó là công dân hay người quản lý thì người dùng đó có thể thực hiện các chức năng và nghiệp vụ khác nhau. Đối với công dân, người dùng có thể xem được thông tin cá nhân và căn cước công dân của bản thân, có thể thay đổi ảnh đại diện và mật khẩu; xem các bản thuế và đóng thuế; xem được thông tin các thành viên trong hộ khẩu thường trú của mình; và có thể xem và in các loại giấy tờ như: đơn đăng ký tạm trú/ tạm vắng, giấy khai sinh, giấy khai tử, đơn kết hôn và đơn ly hôn. Còn đối với người quản lý, người dùng có thể đăng nhập với hai vai trò là công dân và cả quản lý. Quản lý có thể xem và chỉnh sửa toàn bộ thông tin của công dân, đăng ký căn cước công dân; đăng ký, chỉnh sửa và in các loại giấy tờ như: khai sinh, khai tử, kết hôn, ly hôn và tạm trú/ tạm vắng; mở hộ khẩu, nhập khẩu, cắt khẩu; và khai mã số thuế cho các công dân.
# <a name="_toc134582476"></a><a name="_toc134828443"></a><a name="_toc135002218"></a>**PHẦN NỘI DUNG**

## <a name="_toc134828445"></a><a name="_toc135002220"></a>**2. Giao diện thiết kế hệ thống**
### <a name="_toc134828446"></a><a name="_toc135002221"></a>**2.1 Form đăng nhập**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.003.png)


### <a name="_toc134828447"></a><a name="_toc135002222"></a>**2.2 Đăng nhập với vai trò công dân**
#### <a name="_toc135002223"></a>**2.2.1 Thông tin cá nhân**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.004.png)

#### <a name="_toc135002224"></a>**2.2.2 Hộ khẩu**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.005.png)
**

### <a name="_toc135002225"></a>**2.3 Đăng nhập với vai trò quản lý**
#### <a name="_toc135002226"></a>**2.3.1 Thông tin công dân**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.006.png)
**


**Giấy thông tin công dân**

![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.007.png)
**

#### <a name="_toc135002227"></a>**2.3.2 Căn cước công dân**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.008.png)

#### <a name="_toc135002228"></a>**2.3.3 Khai sinh**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.009.png)
**


**Giấy khai sinh**

![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.010.png)
**

#### <a name="_toc135002229"></a>**2.3.4 Khai tử**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.011.png)
**


**Giấy khai tử**

![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.012.png)
**

#### <a name="_toc135002230"></a>**2.3.5 Kết hôn**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.013.png)
**


**Giấy đăng ký kết hôn**

![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.014.png)
**

#### <a name="_toc135002231"></a>**2.3.6 Ly hôn**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.015.png)
**


**Giấy đăng ký ly hôn**

![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.016.png)
**

#### <a name="_toc135002232"></a>**2.3.7 Hộ khẩu**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.017.png)

#### <a name="_toc135002233"></a>**2.3.8 Tạm trú / tạm vắng**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.018.png)
**


**Giấy đăng ký tạm trú / tạm vắng**

![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.019.png)
**

#### <a name="_toc135002234"></a>**2.3.9 Thuế**
![](/images/Aspose.Words.a6fe0751-ca94-4f06-b93a-3bd535e61799.020.png)

## <a name="_toc135002235"></a>**3. Quá trình thực hiện đồ án**
**Tuần 3:** Khái quát sơ lược và thiết kế giao diện ban đầu cho ứng dụng.

**Tuần 4:** Phân chia lại giao diện cho từng nghiệp vụ, chức năng cần phải làm.

**Tuần 5:** Tìm hiểu GIT, nhưng gặp lỗi, chuyển sang gửi và gộp thông thường.

**Tuần 6:** Tạo CSDL và chỉnh sửa lại giao diện, tìm hiểu về mở Child Form trên form chính, code phần đăng nhập.

**Tuần 7:** Phát triển ý tưởng có một tính năng hòm thư để công dân sử dụng app có thể liên lạc được với nhau và có thể liên hệ với quản lý khi cần thiết, các nghiệp vụ khác khi thực hiện đăng ký cũng có sự approve của quản lý và sẽ tự động gửi mail xác nhận. Tiếp tục chỉnh sửa lại CSDL.

**Tuần 8:** Chỉnh sửa lại CSDL, thêm các thuộc tính trạng thái (đã được approve và chưa được approve) cho một số nghiệp vụ đăng ký giấy tờ, nhóm xảy ra bất đồng quan điểm, quyết định tách nhóm.

**Tuần 9:** Chỉnh sửa lại giao diện và thực hiện theo ý tưởng cũ, code phần hòm thư (gửi, xóa, xem hộp thư) và thông tin thêm, xóa sửa công dân.

**Tuần 10:** Bỏ ý tưởng cũ, công dân không được đăng ký các giấy tờ mà người quản lý sẽ quản lý chỉnh sửa cũng như đăng ký giấy tờ và người dân khi sử dụng app chỉ có thể xem thông tin những giấy tờ mà mình đăng ký. Code thêm các nghiệp vụ như khai sinh, khai tử.

**Tuần 11:** Tiếp tục chỉnh sửa lại tổng quát giao diện, sửa lại code theo hướng mới. Tìm hiểu cách chèn ảnh từ C# và cập nhật ảnh trên CSDL. Xóa bỏ nghiệp vụ hòm thư vì không cần thiết.

**Tuần 12:** Vì CSDL sửa đổi quá nhiều lần, thực hiện chuyển đổi từ ADO.net sang kỹ thuật thêm Entity để update dữ liệu lại nhanh hơn.

**Tuần 13:** Code nghiệp vụ ly hôn, kết hôn, tìm hiểu cách in PDF từ C#, chỉnh sửa lại giao diện datagridview và thêm các icon cho button, căn chỉnh lại các khung cho phù hợp.

**Tuần 14:** Nghỉ lễ. Sửa lại nghiệp vụ khai sinh, code tiếp phần hộ khẩu, đăng ký thường trú, tạm trú / tạm vắng, chỉnh sửa và thêm các điều kiện ràng buộc, các trường hợp try / catch ngoại lệ… Hoàn thiện đồ án, map sang bản ADO.net và nộp fhqx. 

**Tuần 15:** Báo cáo đồ án lần 1, chỉnh sửa hoàn thiện sản phẩm (giao diện, tìm kiếm tác vụ, chuyển dữ liệu giữa các form…).

**Tuần 16:** Báo cáo đồ án lần 2, nộp bài.

## <a name="_toc135002236"></a>**4. Framework và công nghệ kỹ thuật dùng trong đồ án:**
Môi trường cài đặt và công nghệ sử dụng:

\- Hệ cơ sở dữ liệu Microsoft SQL Server Management Studio 18.

\- Chương trình Winform được viết bằng Microsoft Visual Studio 2022 - trên nền tảng ASP.NET Web Application (.NET Framework) C#.

\- Thiết kế theo mô hình 3 lớp (DAO, DTO…), hai phiên bản là Entity và ADO.net

## <a name="_toc135002237"></a>**5. Tài khoản login**
Tài khoản đăng nhập cho người quản lý (người quản lý có thể đăng nhập với cả hai vai trò là “Công dân” và “Quản lý”):

**Tài khoản:** tranthienphuong

**Mật khẩu:** 12345


# <a name="_toc135002238"></a>**TÀI LIỆU THAM KHẢO**

**1. Cách sử dụng Combobox Winform**

**[Lập trình C# Winform] - Bài 10: Combobox| HowKteam:**

<https://www.youtube.com/watch?v=Uw3vymbSPO0&list=LL&index=27>

**2. Cách chèn ảnh**

**How to insert Image in Sql Server using C#:**

<https://www.youtube.com/watch?v=0zWEtOD3e5E&list=LL&index=24&t=423s>

**[Window Forms Apps] Xử Lý Hình Ảnh Trên DataGridView (SQL Server) - C#:**

<https://www.youtube.com/watch?v=RRhMFZIvXSY&list=LL&index=21&t=1270s>

**How To Add Image or Button In DataGridView Column:**

<https://www.youtube.com/watch?v=u69ah4VkIzU&list=LL&index=12>

**3. Thiết kế Datagridview**

**Styling Winforms DatagridView:**

<https://www.youtube.com/watch?v=Y4WV1tQBW5I&list=LL&index=23&t=178s>

**How to Customize DataGridView using C#:**

<https://www.youtube.com/watch?v=2WkKhvxT0eg&list=LL&index=10&t=33s>

**4. Cách in nội dung PDF**

**Print document as PDF in C# | Save invoice as PDF C#:**

<https://www.youtube.com/watch?v=05v4CZ4jtDg&list=LL&index=20&t=300s>

**Print contents of WinForms Application using C# and VB.Net:**

<https://www.youtube.com/watch?v=mbMGlbMkavA&list=LL&index=15&t=561s>

**

**5. Hiển thị CellError**

**VB net: How prevent empty value in datagridview column using vlidating:**

<https://www.youtube.com/watch?v=T_8vqc389Rg&list=LL&index=11>

**C# Programming Tutorial - Cell Validating 1 - Validate on the Grid Cell:**

<https://www.youtube.com/watch?v=T1V8WonCxCA&list=LL&index=7&t=163s>

**6. Gộp các bản form trong các project khác nhau**

**C# WINDOW APPLICATION - COPY FORM FROM ONE PROJECT TO ANOTHER:**

<https://www.youtube.com/watch?v=OFX9LMGkLW4&list=LL&index=6&t=140s>

**7. Chuyển dữ liệu giữa các form**

**How Transfer Data from Child Form Back to Parent form:**

<https://www.youtube.com/watch?v=TFOLV4OzfGQ&list=LL&index=2&t=140s>
