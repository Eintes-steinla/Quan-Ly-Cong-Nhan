# 🏭 QLCN - Hệ thống Quản Lý Công Nhân

## 📖 Giới thiệu
QLCN là một phần mềm quản lý công nhân được phát triển bằng **C# WinForms** và **SQL Server**.  
Phần mềm hỗ trợ doanh nghiệp trong việc quản lý thông tin công nhân, chấm công, nghỉ phép, tăng ca, phân ca, báo cáo và phân quyền người dùng.

---

## 🚀 Chức năng chính
- **Đăng nhập/Đăng xuất**: Xác thực người dùng.
- **Quản lý công nhân**: Thêm, sửa, xóa, tìm kiếm thông tin công nhân.
- **Chấm công**: Ghi nhận giờ vào/ra hằng ngày.
- **Nghỉ phép**: Quản lý đơn xin nghỉ phép.
- **Tăng ca**: Lưu lại giờ làm thêm.
- **Ca làm & Phân ca**: Tạo và sắp xếp ca làm việc.
- **Báo cáo**: Xuất báo cáo chấm công, tăng ca, nghỉ phép.
- **Người dùng & Phân quyền**: Quản lý user, role.
- **Cài đặt hệ thống**: Cấu hình thông tin công ty, kết nối CSDL, ngôn ngữ, giao diện.
- **Nhật ký hệ thống**: Theo dõi lịch sử hoạt động của người dùng.

---

## 🛠️ Công nghệ sử dụng
- **Ngôn ngữ**: C#
- **Giao diện**: WinForms
- **Cơ sở dữ liệu**: SQL Server
<!-- - **ORM / Data Access**: ADO.NET (SqlConnection, SqlCommand)
- **Quản lý gói**: NuGet (System.Data.SqlClient hoặc Microsoft.Data.SqlClient) -->

---

## 📂 Cấu trúc dự án
```
QLCN/
│
├── QLCN/
│ ├── FormLogin.cs
│ ├── FormMain.cs
│ ├── FormProfile.cs
│ ├── FormChangePassword.cs
│ ├── FormCongNhan.cs
│ ├── FormChamCong.cs
│ ├── FormNghiPhep.cs
│ ├── FormTangCa.cs
│ ├── FormCaLam.cs
│ ├── FormPhanCa.cs
│ ├── FormBaoCao.cs
│ ├── FormUser.cs
│ ├── FormSettings.cs
│ └── FormNhatKyHeThong.cs
│
├── Database/
│ └── QLCN.sql (script tạo CSDL & bảng)
│
├── README.md
└── QLCN.sln
```