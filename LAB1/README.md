Bài 1 
abstract class CHinhVe{
    protected int MaLoaiHinhVe;
      public abstract float DienTich();
      public abstract float ChuVi();
      public abstract void Ve();
}

public class CDiem {
    private float x;
    private float y;

    public CDiem() {
    }

    public CDiem(float x, float y) {
        this.x = x;
        this.y = y;
    }

    public float getX() {
        return x;
    }

    public float getY() {
        return y;
    }

    public void setX(float x) {
        this.x = x;
    }

    public void setY(float y) {
        this.y = y;
    }
}

public class CTamGiac extends CHinhVe {
    protected CDiem cDiemP1;
    protected CDiem cDiemP2;
    protected CDiem cDiemP3;

    public CTamGiac() {
        cDiemP1 = new CDiem();
        cDiemP2 = new CDiem();
        cDiemP3 = new CDiem();
    }

    @Override
    public float dienTich() {
        float x1 = cDiemP1.getX();
        float y1 = cDiemP1.getY();

        float x2 = cDiemP2.getX();
        float y2 = cDiemP2.getY();

        float x3 = cDiemP3.getX();
        float y3 = cDiemP3.getY();

        return Math.abs(
            (x1 * (y2 - y3)
            + x2 * (y3 - y1)
            + x3 * (y1 - y2)) / 2
        );
    }

    @Override
    public float chuVi() {
        float a = khoangCach(cDiemP1, cDiemP2);
        float b = khoangCach(cDiemP2, cDiemP3);
        float c = khoangCach(cDiemP3, cDiemP1);

        return a + b + c;
    }

    private float khoangCach(CDiem p1, CDiem p2) {
        float dx = p1.getX() - p2.getX();
        float dy = p1.getY() - p2.getY();

        return (float) Math.sqrt(dx * dx + dy * dy);
    }

    @Override
    public void ve() {
        System.out.println("Vẽ hình tam giác");
    }
}
public class CTuGiac extends CHinhVe {
    protected CDiem cDiemP1;
    protected CDiem cDiemP2;
    protected CDiem cDiemP3;
    protected CDiem cDiemP4;

    public CTuGiac() {
        cDiemP1 = new CDiem();
        cDiemP2 = new CDiem();
        cDiemP3 = new CDiem();
        cDiemP4 = new CDiem();
    }

    @Override
    public float dienTich() {
        float s1 = dienTichTamGiac(
            cDiemP1, cDiemP2, cDiemP3
        );

        float s2 = dienTichTamGiac(
            cDiemP1, cDiemP3, cDiemP4
        );

        return s1 + s2;
    }

    private float dienTichTamGiac(CDiem p1, CDiem p2, CDiem p3) {
        return Math.abs(
            (p1.getX() * (p2.getY() - p3.getY())
            + p2.getX() * (p3.getY() - p1.getY())
            + p3.getX() * (p1.getY() - p2.getY())) / 2
        );
    }

    @Override
    public float chuVi() {
        return khoangCach(cDiemP1, cDiemP2)
             + khoangCach(cDiemP2, cDiemP3)
             + khoangCach(cDiemP3, cDiemP4)
             + khoangCach(cDiemP4, cDiemP1);
    }

    private float khoangCach(CDiem p1, CDiem p2) {
        float dx = p1.getX() - p2.getX();
        float dy = p1.getY() - p2.getY();

        return (float) Math.sqrt(dx * dx + dy * dy);
    }

    @Override
    public void ve() {
        System.out.println("Vẽ hình tứ giác");
    }
}
public class CEllipse extends CHinhVe {
    protected CDiem cDiemTam;
    protected float a;
    protected float b;

    public CEllipse() {
        cDiemTam = new CDiem();
        a = 0;
        b = 0;
    }

    @Override
    public float dienTich() {
        return (float) (Math.PI * a * b);
    }

    @Override
    public float chuVi() {
        // Công thức xấp xỉ Ramanujan
        return (float) (
            Math.PI * (
                3 * (a + b)
                - Math.sqrt((3 * a + b) * (a + 3 * b))
            )
        );
    }

    @Override
    public void ve() {
        System.out.println("Ve hinh ellipse");
    }
}
public class Main {
    public static void main(String[] args) {

        CHinhVe hinh1 = new CTamGiac();
        CHinhVe hinh2 = new CTuGiac();
        CHinhVe hinh3 = new CEllipse();

        hinh1.ve();
        hinh2.ve();
        hinh3.ve();

        System.out.println("Dien tich tam giac: "
                + hinh1.dienTich());

        System.out.println("Dien tich tu giac: "
                + hinh2.dienTich());

        System.out.println("Dien tich ellipse: "
                + hinh3.dienTich());
    }
}

Bài 2
1. Giai đoạn phân tích (Analysis)
Mục đích của việc phân tích là để hiểu rõ được vấn đề và bắt đầu phát triển một mô hình
trực quan về hệ thống đang xây dựng, chuyển những yêu cầu chức năng vào khái niệm
phần mềm
1.1. Phân tích yêu cầu
1.1.1. Xác định yêu cầu chức năng của hệ thống
Hệ thống thư viện trực tuyến được xây dựng nhằm hỗ trợ cán bộ, giảng viên, nhân viên và sinh viên của trường trong việc tra cứu và sử dụng các nguồn tài nguyên thư viện thông qua mạng nội bộ Intranet. Hệ thống cung cấp các chức năng phục vụ việc tìm kiếm, đọc và tải tài liệu điện tử, đăng ký mượn sách tại thư viện, đặt mua tài liệu điện tử, đồng thời hỗ trợ thủ thư trong công tác quản lý tài liệu, quản lý mượn trả và thống kê hoạt động của thư viện.
Các yêu cầu chức năng chính của hệ thống được xác định như sau:
Thứ nhất, quản lý tài khoản người dùng. Hệ thống cho phép độc giả đăng ký tài khoản và đăng nhập vào hệ thống. Tài khoản được sử dụng để xác thực người dùng và cung cấp quyền truy cập phù hợp đối với từng chức năng. Thủ thư cũng phải có tài khoản để thực hiện các chức năng quản lý.
Thứ hai, tìm kiếm và tra cứu tài liệu. Người dùng có thể tìm kiếm tài liệu theo nhiều tiêu chí khác nhau như tên sách, tên tác giả, chủ đề, loại tài liệu, năm xuất bản hoặc từ khóa. Sau khi thực hiện tìm kiếm, hệ thống hiển thị danh sách các tài liệu phù hợp và cho phép người dùng xem thông tin chi tiết của từng tài liệu.
Thứ ba, khai thác tài liệu điện tử. Đối với sách điện tử, độc giả có thể đọc trực tuyến trên hệ thống. Trong trường hợp muốn tải tài liệu về, độc giả phải cung cấp Mã thẻ thư viện để hệ thống thực hiện xác thực.
Thứ tư, đăng ký mượn sách. Đối với sách được lưu trữ tại thư viện, hệ thống hiển thị tình trạng và số lượng sách hiện còn. Độc giả có thể đăng ký mượn nếu sách còn khả dụng. Khi thực hiện đăng ký mượn, độc giả phải cung cấp Mã thẻ thư viện để hệ thống xác định và kiểm tra thông tin độc giả.
Thứ năm, đặt mua tài liệu điện tử. Độc giả có thể gửi yêu cầu đặt mua tài liệu điện tử thông qua hệ thống. Để thực hiện chức năng này, người dùng phải có tài khoản và đăng nhập vào hệ thống. Khi gửi yêu cầu, độc giả cần cung cấp các thông tin bao gồm tên sách, tên tác giả và năm xuất bản.
Thứ sáu, quản lý mượn và trả sách. Thủ thư có quyền quản lý thông tin mượn và trả sách của độc giả. Hệ thống hỗ trợ thủ thư theo dõi các tài liệu đang được mượn, xác định độc giả đang giữ sách, kiểm tra thời hạn trả và phát hiện các trường hợp mượn sách quá hạn.
Thứ bảy, quản lý danh mục tài liệu. Thủ thư có quyền thêm mới, cập nhật và xóa thông tin tài liệu. Các loại tài liệu được quản lý bao gồm sách trong thư viện và sách điện tử. Hệ thống cũng cho phép cập nhật số lượng và tình trạng của tài liệu.
Thứ tám, xử lý yêu cầu đặt mua. Thủ thư có thể xem danh sách các yêu cầu đặt mua tài liệu của độc giả và thực hiện việc chấp nhận hoặc từ chối từng yêu cầu.
Thứ chín, thông báo nhắc hạn trả sách. Hệ thống có chức năng tự động kiểm tra thời hạn trả sách. Đối với những trường hợp còn ba ngày đến hạn trả, hệ thống tự động gửi email đến độc giả nhằm thông báo và nhắc nhở việc hoàn trả tài liệu đúng thời hạn.
Thứ mười, báo cáo và thống kê. Hệ thống cung cấp chức năng báo cáo và thống kê phục vụ công tác quản lý thư viện. Các báo cáo có thể bao gồm số lượng tài liệu, số lượng sách đang được mượn, số lượng sách quá hạn, tình hình mượn trả và tình trạng xử lý các yêu cầu mua tài liệu.
1.1.2. Xây dựng bảng thuật ngữ của hệ thống
Trong quá trình phân tích, việc xây dựng bảng thuật ngữ giúp xác định thống nhất ý nghĩa của các khái niệm được sử dụng trong hệ thống. Các thuật ngữ chính được xác định như sau:
Thuật ngữ	Định nghĩa
Độc giả	Là người sử dụng tài nguyên thư viện, bao gồm sinh viên, giảng viên và cán bộ, nhân viên của trường.
Thủ thư	Là người chịu trách nhiệm quản lý và vận hành các hoạt động của thư viện trên hệ thống.
Tài khoản	Thông tin dùng để xác thực người dùng khi truy cập hệ thống, bao gồm tên đăng nhập và mật khẩu.
Thẻ thư viện	Thẻ được cấp cho độc giả nhằm xác định quyền sử dụng các dịch vụ và tài nguyên của thư viện.
Mã thẻ thư viện	Mã định danh của thẻ thư viện, được sử dụng để xác thực độc giả trong một số chức năng.
Tài liệu	Là các nguồn tài nguyên được lưu trữ và quản lý trong thư viện, bao gồm sách, báo, tạp chí và tài liệu điện tử.
Sách giấy	Là tài liệu được lưu trữ dưới dạng vật lý tại thư viện và có thể được độc giả đăng ký mượn.
Sách điện tử	Là tài liệu được lưu trữ dưới dạng điện tử, cho phép độc giả đọc trực tuyến hoặc tải về theo quy định.
Tác giả	Là người sáng tác hoặc tạo ra nội dung của tài liệu.
Chủ đề	Là lĩnh vực hoặc nội dung chính mà tài liệu đề cập đến.
Mượn sách	Là hoạt động độc giả đăng ký sử dụng sách trong thư viện trong một khoảng thời gian nhất định.
Trả sách	Là hoạt động hoàn trả sách đã mượn về cho thư viện.
Quá hạn	Là trạng thái xảy ra khi độc giả chưa trả sách sau thời hạn được quy định.
Yêu cầu mua	Là yêu cầu do độc giả gửi đến thư viện nhằm đề nghị mua một tài liệu điện tử.
Báo cáo, thống kê	Là chức năng tổng hợp và trình bày dữ liệu phục vụ việc theo dõi và quản lý hoạt động thư viện.
Email nhắc hạn	Là thông báo do hệ thống tự động gửi đến độc giả trước thời hạn trả sách ba ngày.

1.1.3. Mô hình hóa yêu cầu chức năng sử dụng use case model
− Xác định các Actor
Qua quá trình phân tích yêu cầu, hệ thống xác định ba Actor chính gồm Độc giả, Thủ thư và Hệ thống Email.
Độc giả
Độc giả là đối tượng sử dụng trực tiếp các tài nguyên và dịch vụ của thư viện. Độc giả bao gồm sinh viên, giảng viên và cán bộ, nhân viên của trường. Để sử dụng tài nguyên thư viện, độc giả phải có thẻ thư viện.
Độc giả có thể thực hiện các chức năng như đăng ký tài khoản, đăng nhập, tìm kiếm tài liệu, xem thông tin tài liệu, đọc sách điện tử, tải sách điện tử, đăng ký mượn sách và đặt mua tài liệu điện tử.
Thủ thư
Thủ thư là đối tượng chịu trách nhiệm quản lý hoạt động của thư viện. Thủ thư phải có tài khoản để đăng nhập và thực hiện các chức năng quản lý.
Ngoài các chức năng tương tự như độc giả, thủ thư có thêm quyền quản lý mượn và trả sách, theo dõi tình trạng tài liệu, quản lý danh mục tài liệu, xử lý yêu cầu đặt mua và thực hiện báo cáo, thống kê.
Trong mô hình Use Case, Thủ thư có thể được biểu diễn là Actor kế thừa từ Độc giả, bởi vì thủ thư cũng có thể thực hiện các chức năng mà một độc giả thông thường được phép thực hiện.
Hệ thống Email
Hệ thống Email là tác nhân bên ngoài hỗ trợ chức năng gửi thông báo nhắc hạn trả sách. Khi hệ thống xác định một lượt mượn còn ba ngày đến hạn trả, hệ thống sẽ thực hiện gửi email thông báo đến địa chỉ email của độc giả.
− Xác định các use case và đặt ID cho từng use case
Các Use Case của hệ thống được xác định và đặt mã định danh như sau:
ID	Tên Use Case	Actor thực hiện
UC01	Đăng ký tài khoản	Độc giả
UC02	Đăng nhập	Độc giả, Thủ thư
UC03	Đăng xuất	Độc giả, Thủ thư
UC04	Tìm kiếm tài liệu	Độc giả, Thủ thư
UC05	Xem thông tin tài liệu	Độc giả, Thủ thư
UC06	Đọc sách điện tử	Độc giả, Thủ thư
UC07	Tải sách điện tử	Độc giả, Thủ thư
UC08	Đăng ký mượn sách	Độc giả, Thủ thư
UC09	Đặt mua tài liệu	Độc giả, Thủ thư
UC10	Quản lý mượn sách	Thủ thư
UC11	Quản lý trả sách	Thủ thư
UC12	Xem tình trạng sách	Thủ thư
UC13	Quản lý danh mục tài liệu	Thủ thư
UC14	Xử lý yêu cầu mua	Thủ thư
UC15	Gửi email nhắc hạn	Hệ thống Email
UC16	Báo cáo và thống kê	Thủ thư


− Vẽ Use case model
 
- Mẫu đặc tả use case
Luồng sự kiện chính
1.	Người dùng chọn chức năng Tìm kiếm tài liệu. 
2.	Hệ thống hiển thị biểu mẫu tìm kiếm. 
3.	Người dùng nhập một hoặc nhiều tiêu chí tìm kiếm. 
4.	Người dùng nhấn nút Tìm kiếm. 
5.	Hệ thống tiếp nhận và xử lý yêu cầu. 
6.	Hệ thống hiển thị danh sách tài liệu phù hợp. 
Luồng sự kiện thay thế
Nếu không tìm thấy tài liệu phù hợp, hệ thống hiển thị thông báo “Không tìm thấy tài liệu theo yêu cầu”.
Người dùng có thể thay đổi tiêu chí và thực hiện tìm kiếm lại hoặc kết thúc chức năng.
UC07 – Tải sách điện tử
Tên Use Case: Tải sách điện tử
Actor: Độc giả, Thủ thư
Mô tả: Cho phép người dùng tải sách điện tử về thiết bị sau khi xác thực Mã thẻ thư viện.
Tiền điều kiện: Tài liệu được chọn là sách điện tử.
Hậu điều kiện: Tài liệu được tải về thiết bị của người dùng nếu Mã thẻ thư viện hợp lệ.
Luồng sự kiện chính
1.	Người dùng tìm kiếm và lựa chọn sách điện tử. 
2.	Người dùng chọn chức năng Tải về. 
3.	Hệ thống yêu cầu nhập Mã thẻ thư viện. 
4.	Người dùng nhập Mã thẻ. 
5.	Hệ thống kiểm tra Mã thẻ. 
6.	Nếu hợp lệ, hệ thống cho phép tải tài liệu. 
7.	Người dùng tải tài liệu về thiết bị. 
Luồng sự kiện thay thế
Nếu Mã thẻ thư viện không hợp lệ, hệ thống thông báo lỗi và không cho phép tải tài liệu.
UC08 – Đăng ký mượn sách
Tên Use Case: Đăng ký mượn sách
Actor: Độc giả, Thủ thư
Mô tả: Cho phép độc giả đăng ký mượn sách đang được lưu trữ tại thư viện.
Tiền điều kiện: Sách tồn tại trong hệ thống.
Hậu điều kiện: Yêu cầu mượn sách được ghi nhận.
Luồng sự kiện chính
1.	Người dùng tìm kiếm sách. 
2.	Người dùng lựa chọn sách muốn mượn. 
3.	Hệ thống hiển thị số lượng sách còn lại. 
4.	Người dùng chọn chức năng Đăng ký mượn. 
5.	Hệ thống yêu cầu nhập Mã thẻ thư viện. 
6.	Người dùng nhập Mã thẻ. 
7.	Hệ thống kiểm tra Mã thẻ và tình trạng sách. 
8.	Hệ thống ghi nhận yêu cầu mượn. 
9.	Hệ thống thông báo đăng ký mượn thành công. 
Luồng sự kiện thay thế
•	Nếu số lượng sách còn lại bằng 0, hệ thống thông báo sách hiện không khả dụng. 
•	Nếu Mã thẻ thư viện không hợp lệ, hệ thống từ chối yêu cầu mượn. 
•	Nếu độc giả không đáp ứng điều kiện mượn, hệ thống thông báo lý do. 
UC09 – Đặt mua tài liệu
Tên Use Case: Đặt mua tài liệu
Actor: Độc giả, Thủ thư
Mô tả: Cho phép độc giả gửi yêu cầu đề nghị thư viện mua tài liệu điện tử.
Tiền điều kiện: Độc giả đã có tài khoản và đăng nhập vào hệ thống.
Hậu điều kiện: Yêu cầu mua tài liệu được lưu vào hệ thống.
Luồng sự kiện chính
1.	Độc giả đăng nhập hệ thống. 
2.	Chọn chức năng Đặt mua tài liệu. 
3.	Hệ thống hiển thị biểu mẫu đặt mua. 
4.	Độc giả nhập tên sách, tác giả và năm xuất bản. 
5.	Độc giả gửi yêu cầu. 
6.	Hệ thống kiểm tra thông tin. 
7.	Hệ thống lưu yêu cầu mua. 
8.	Hệ thống thông báo gửi yêu cầu thành công. 
Luồng sự kiện thay thế
Nếu người dùng chưa đăng nhập, hệ thống yêu cầu người dùng thực hiện đăng nhập trước khi tiếp tục.
Nếu thông tin tài liệu không đầy đủ hoặc không hợp lệ, hệ thống thông báo lỗi và yêu cầu người dùng nhập lại.
UC10 – Quản lý mượn sách
Tên Use Case: Quản lý mượn sách
Actor: Thủ thư
Mô tả: Cho phép thủ thư quản lý và theo dõi thông tin các lượt mượn sách của độc giả.
Tiền điều kiện: Thủ thư đã đăng nhập.
Hậu điều kiện: Thông tin mượn sách được cập nhật chính xác trong hệ thống.
Luồng sự kiện chính
1.	Thủ thư đăng nhập hệ thống. 
2.	Chọn chức năng Quản lý mượn sách. 
3.	Hệ thống hiển thị danh sách các lượt mượn. 
4.	Thủ thư tìm kiếm hoặc lựa chọn một lượt mượn. 
5.	Hệ thống hiển thị thông tin chi tiết. 
6.	Thủ thư thực hiện cập nhật khi cần thiết. 
7.	Hệ thống lưu thông tin thay đổi. 
UC11 – Quản lý trả sách
Tên Use Case: Quản lý trả sách
Actor: Thủ thư
Mô tả: Cho phép thủ thư ghi nhận việc trả sách và cập nhật tình trạng tài liệu.
Tiền điều kiện: Thủ thư đã đăng nhập và tồn tại thông tin mượn sách.
Hậu điều kiện: Trạng thái sách và thông tin trả sách được cập nhật.
Luồng sự kiện chính
1.	Thủ thư chọn chức năng Quản lý trả sách. 
2.	Hệ thống hiển thị danh sách sách đang được mượn. 
3.	Thủ thư tìm kiếm lượt mượn cần xử lý. 
4.	Thủ thư xác nhận việc trả sách. 
5.	Hệ thống cập nhật trạng thái lượt mượn. 
6.	Hệ thống cập nhật số lượng sách. 
7.	Hệ thống lưu thông tin trả sách. 
Luồng sự kiện thay thế
Nếu ngày trả vượt quá thời hạn quy định, hệ thống xác định lượt mượn là quá hạn và ghi nhận trạng thái tương ứng.
UC13 – Quản lý danh mục tài liệu
Tên Use Case: Quản lý danh mục tài liệu
Actor: Thủ thư
Mô tả: Cho phép thủ thư quản lý thông tin sách trong thư viện và sách điện tử.
Luồng sự kiện chính
1.	Thủ thư đăng nhập hệ thống. 
2.	Chọn chức năng Quản lý danh mục tài liệu. 
3.	Hệ thống hiển thị danh sách tài liệu. 
4.	Thủ thư lựa chọn thêm, sửa hoặc xóa tài liệu. 
5.	Thủ thư nhập hoặc cập nhật thông tin tài liệu. 
6.	Hệ thống kiểm tra dữ liệu. 
7.	Hệ thống lưu thông tin. 
Luồng sự kiện thay thế
Nếu thông tin tài liệu không hợp lệ, hệ thống thông báo lỗi và yêu cầu thủ thư nhập lại.
UC14 – Xử lý yêu cầu mua
Tên Use Case: Xử lý yêu cầu mua
Actor: Thủ thư
Mô tả: Cho phép thủ thư xem và xử lý các yêu cầu mua tài liệu do độc giả gửi.
Luồng sự kiện chính
1.	Thủ thư đăng nhập hệ thống. 
2.	Chọn chức năng Xử lý yêu cầu mua. 
3.	Hệ thống hiển thị danh sách yêu cầu. 
4.	Thủ thư lựa chọn một yêu cầu. 
5.	Hệ thống hiển thị thông tin chi tiết. 
6.	Thủ thư lựa chọn Chấp nhận hoặc Từ chối. 
7.	Hệ thống cập nhật trạng thái yêu cầu. 
8.	Hệ thống lưu kết quả xử lý. 
UC15 – Gửi email nhắc hạn
Tên Use Case: Gửi email nhắc hạn
Actor: Hệ thống Email
Mô tả: Hệ thống tự động gửi thông báo đến độc giả trước thời hạn trả sách ba ngày.
Luồng sự kiện chính
1.	Hệ thống định kỳ kiểm tra các lượt mượn. 
2.	Hệ thống xác định các lượt mượn còn ba ngày đến hạn. 
3.	Hệ thống lấy thông tin email của độc giả. 
4.	Hệ thống tạo nội dung thông báo. 
5.	Hệ thống gửi email nhắc hạn. 
6.	Hệ thống ghi nhận trạng thái gửi thông báo. 
Luồng sự kiện thay thế
Nếu quá trình gửi email xảy ra lỗi, hệ thống ghi nhận trạng thái gửi thất bại để phục vụ việc kiểm tra và xử lý.
UC16 – Báo cáo và thống kê
Tên Use Case: Báo cáo và thống kê
Actor: Thủ thư
Mô tả: Cung cấp các báo cáo tổng hợp nhằm hỗ trợ thủ thư theo dõi và đánh giá hoạt động của thư viện.
Luồng sự kiện chính
1.	Thủ thư đăng nhập hệ thống. 
2.	Chọn chức năng Báo cáo và thống kê. 
3.	Hệ thống hiển thị các loại báo cáo. 
4.	Thủ thư lựa chọn loại báo cáo cần xem. 
5.	Hệ thống truy xuất dữ liệu. 
6.	Hệ thống tổng hợp và xử lý dữ liệu. 
7.	Hệ thống hiển thị kết quả báo cáo.

